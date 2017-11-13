using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class InsertResult : Form
    {
        Connection con;
        Reports R;
        string Radio = null;
        public InsertResult()
        {
            InitializeComponent();
        }

        private void InsertResult_Load(object sender, EventArgs e)
        {
            try
            {
                con = new Connection();
                string q = "Select Report_Number from report";
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                R = new Reports();
                tbl = R.selectData(comboBox1.Text);
                comboBox1.Text = tbl.Rows[0]["Report_Number"].ToString();
                textBox1.Text = tbl.Rows[0]["Patient_Number"].ToString();
                textBox2.Text = tbl.Rows[0]["Patient_Name"].ToString();
                textBox5.Text = tbl.Rows[0]["Patient_Cell"].ToString();
                textBox4.Text = tbl.Rows[0]["Bill"].ToString();
                textBox7.Text = tbl.Rows[0]["Patient_Blood_Group"].ToString();
                textBox6.Text = tbl.Rows[0]["Patient_Address"].ToString();
                textBox10.Text = tbl.Rows[0]["Report_Date"].ToString();
                textBox3.Text = tbl.Rows[0]["Patient_Age"].ToString();
                textBox9.Text = tbl.Rows[0]["Test_Result"].ToString();
                textBox8.Text = tbl.Rows[0]["Types_of_Test"].ToString();
                groupBox1.Visible = true;
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " : " + "Please Enter Correct Report ID");
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
            
            
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                R = new Reports(comboBox1.Text, richTextBox1.Text, Radio, textBox1.Text);
                R.inserttest();
                MessageBox.Show("Report Inserted Sucessfully....");
                this.Hide();
                Form6 f6 = new Form6();
                f6.Show();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry Data Couoldn't be inserted");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Radio = radioButton1.Text;
                richTextBox1.Visible = true;
                button1.Visible = true;
            }
            else
                if (radioButton2.Checked)
                {
                    Radio = radioButton2.Text;
                    button1.Visible = true;                 
                }            
            }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.Show();
        }
    }
}
    

