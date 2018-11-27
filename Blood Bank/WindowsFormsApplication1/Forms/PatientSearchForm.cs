using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using WindowsFormsApplication1.Properties;
using WindowsFormsApplication1.DOA;

namespace WindowsFormsApplication1
{
    public partial class PatientSearchForm : Form
    {
        //Patient's Class Object
        Patient p1;
        PatientManager patientManager = new PatientManager();
        Blood B;
        Connection con;

        public PatientSearchForm()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            button6.Hide();
            button8.Hide();
            
            try
            {
                OleDbDataReader reader = patientManager.GetPatientsByNumber();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Couldn't find the Correct ID");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Select Quert to search a specific patient
            try
            {
                if (comboBox1.Text != "")
                {
                    DataTable ptable = new DataTable();
                    p1 = new Patient();
                    //ptable = patientManager.getTable("SELECT * From `patient` WHERE `Patient_Number` = " + comboBox1.Text);
                    ptable = patientManager.selectData(comboBox1.Text);
                    dataGridView1.DataSource = ptable;
                }
                else
                {
                    MessageBox.Show("Please selecy any Patient ID");
                }
                
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Couldn't Search the Data");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Delete Query to delete a specific patient
            try
            {
                if (comboBox1.Text != "")
                {
                    DataTable ptable = new DataTable();
                    ptable = patientManager.DeleteUser(comboBox1.Text);
                    dataGridView1.DataSource = ptable;
                    MessageBox.Show("Data Deleted Successfully");                    
                }
                else
                {
                    MessageBox.Show("Please selecy any Patient ID");
                }
                
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Couldn't Delete the Data");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Select Quert to search all patients
            try
            {
                DataTable ptable = new DataTable();
                p1 = new Patient();
                ptable = patientManager.getTable("SELECT * From patient");
                dataGridView1.DataSource = ptable;
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Couldn't Search the Data");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserTypeForm f2 = new UserTypeForm();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
                {
                    this.Hide();
                    PatientDetailForm patientDetailForm = new PatientDetailForm();
                    patientDetailForm.Show();                    
                }
                else
                {
                    MessageBox.Show("Please selecy any Patient ID");                    
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Join Query for Reports
            try
            {
                if (comboBox1.Text != "")
                {
                    DataTable ptable = new DataTable();
                    p1 = new Patient();
                    ptable = patientManager.joinTable("SELECT report.Patient_Number, report.Patient_Name, test.Report_Number, test.Report FROM report INNER JOIN test ON report.Patient_Number = test.Patient_Number where report.Patient_Number = " + comboBox1.Text);
                    dataGridView1.DataSource = ptable;                    
                }
                else
                {
                    MessageBox.Show("Please selecy any Patient ID");
                }
                
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Couln't Show the Reports");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "")
                {
                    DataTable ptable = new DataTable();
                    RegMedineTemp m = new RegMedineTemp();
                    string query = "SELECT * From `Medicine` WHERE `Patient_Number` = " + comboBox1.Text;
                    ptable = m.getTable(query);
                    dataGridView1.DataSource = ptable;                    
                }
                else
                {
                    MessageBox.Show("Please selecy any Patient ID");
                }
                
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Couldn't Search the Data");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
          try
            {
              if (comboBox1.Text != "")
                {
                    DataTable ptable = new DataTable();
                    BloodManager bloodManager = new BloodManager();
                    string query = "SELECT * From `Blood` WHERE Patient_Number = " + comboBox1.Text;
                    ptable = bloodManager.getTable(query);
                    dataGridView1.DataSource = ptable;                    
                }
                else
                {
                    MessageBox.Show("Please selecy any Patient ID");
                }
                
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Couldn't Search the Data");
            }
        }
    }
}   