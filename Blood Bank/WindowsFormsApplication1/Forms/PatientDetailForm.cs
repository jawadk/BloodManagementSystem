using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using WindowsFormsApplication1.DOA;

namespace WindowsFormsApplication1
{
    public partial class PatientDetailForm : Form
    {
        Patient p1;
        PatientManager patientManager = new PatientManager();
        Connection con;

        public PatientDetailForm()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (comboBox1.Text != "")
                {
                    p1 = new Patient(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text);
                    patientManager.updateData(Convert.ToInt32(comboBox1.Text), p1);
                    MessageBox.Show("Data Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Please selecy any Patient ID");
                }
                
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Data Couldn't be Updated");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "")
                {
                    DataTable tbl = new DataTable();
                    p1 = new Patient();
                    tbl = patientManager.selectData(comboBox1.Text);
                    comboBox1.Text = tbl.Rows[0]["Patient_Number"].ToString();
                    comboBox1.Enabled = false;
                    textBox2.Text = tbl.Rows[0]["Blood_Group"].ToString();
                    textBox3.Text = tbl.Rows[0]["Patient_Name"].ToString();
                    textBox4.Text = tbl.Rows[0]["Patient_DOB"].ToString();
                    textBox5.Text = tbl.Rows[0]["Patient_Add1"].ToString();
                    textBox6.Text = tbl.Rows[0]["Patient_Add2"].ToString();
                    textBox7.Text = tbl.Rows[0]["Patient_Ph-No"].ToString();
                    textBox8.Text = tbl.Rows[0]["Patient_Cell-No"].ToString();
                    textBox9.Text = tbl.Rows[0]["Date"].ToString();
                    textBox10.Text = tbl.Rows[0]["Branch_Location"].ToString();
                    textBox11.Text = tbl.Rows[0]["city"].ToString();
                    textBox12.Text = tbl.Rows[0]["Amount_of_Blood"].ToString();
                    textBox13.Text = tbl.Rows[0]["Patient_Email"].ToString();                    
                }
                else
                {
                    MessageBox.Show("Please selecy any Patient ID");
                }
                
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Data Couldn't be Retrieved");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            MessageBox.Show("Data has been Erased");
            comboBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void Form9_Load(object sender, EventArgs e)
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
    }
}
