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

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        //Patient's Class Object
        Patient p1;
        FreeMedicine m;
        Blood B;
        Connection con;

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                con = new Connection();
                string q = "Select Patient_Number from patient";
                OleDbCommand cmd = new OleDbCommand(q, con.connect());
                OleDbDataReader reader = cmd.ExecuteReader();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Select Quert to search a specific patient
            try
            {
                DataTable ptable = new DataTable();
                p1 = new Patient();
                ptable = p1.getTable("SELECT * From `patient` WHERE `Patient_Number` = '" + comboBox1.Text + "'");
                dataGridView1.DataSource = ptable;
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Couldn't Search the Data");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Delete Query to delete a specific patient
            try
            {
                DataTable ptable = new DataTable();
                p1 = new Patient();
                ptable = p1.getTable("DELETE * From `patient` where Patient_Number = '" + comboBox1.Text + "'");
                dataGridView1.DataSource = ptable;
                MessageBox.Show("Data Deleted Successfully");
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
                ptable = p1.getTable("SELECT * From patient");
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
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Join Query for Reports
            try
            {
                DataTable ptable = new DataTable();
                p1 = new Patient();
                ptable = p1.joinTable("SELECT report.Patient_Number, report.Patient_Name, test.Report_Number, test.Report FROM report INNER JOIN test ON report.Patient_Number = test.Patient_Number where report.Patient_Number = '" + comboBox1.Text + "'");
                dataGridView1.DataSource = ptable;
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Couln't Show the Reports");
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable ptable = new DataTable();
                m = new FreeMedicine();
                ptable = m.getTable("SELECT * From `Medicine` WHERE `Patient_Number` = '" + comboBox1.Text + "'");
                dataGridView1.DataSource = ptable;
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Couldn't Search the Data");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
          try
            {
                DataTable ptable = new DataTable();
                B = new Blood();
                ptable = B.getTable("SELECT * From `Blood` WHERE `Patient_Number` = '" + comboBox1.Text + "'");
                dataGridView1.DataSource = ptable;
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Couldn't Search the Data");
            }
        }
    }
}   