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
    public partial class NewTest : Form
    {
        Patient p1;
        Connection connect;
        Reports R;
        public NewTest()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string radio = null;
                if (radioButton1.Checked)
                {
                    radio = radioButton1.Text;
                    textBox7.Text = "100 Rupees";
                }
                else if (radioButton2.Checked)
                {
                    radio = radioButton2.Text;
                    textBox7.Text = "200 Rupees";
                }
                else if (radioButton3.Checked)
                {
                    radio = radioButton3.Text;
                    textBox7.Text = "1500 Rupees";
                }
                else if (radioButton4.Checked)
                {
                    radio = radioButton4.Text;
                    textBox7.Text = "500 Rupees";
                }
                else if (radioButton5.Checked)
                {
                    radio = radioButton5.Text;
                    textBox7.Text = "300 Rupees";
                }

                DateTime d = dateTimePicker1.Value;
                DateTime d1 = dateTimePicker2.Value;
                R = new Reports(comboBox1.Text, textBox3.Text, textBox8.Text, textBox9.Text, textBox2.Text, textBox5.Text, d, d1, radio.ToString(), textBox7.Text);
                R.insertreport();
                label9.Visible = true;
                textBox7.Visible = true;
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Re-Enter the Valid Information");
            }
        }

        private void NewTest_Load(object sender, EventArgs e)
        {
            try
            {
                connect = new Connection();
                string q = "Select Patient_Number from patient";
                OleDbCommand cmd = new OleDbCommand(q, connect.connect());
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tbl = new DataTable();
                p1 = new Patient();
                tbl = p1.selectData(comboBox1.Text);
                comboBox1.Text = tbl.Rows[0]["Patient_Number"].ToString();
                comboBox1.Enabled = false;
                textBox2.Text = tbl.Rows[0]["Blood_Group"].ToString();
                textBox3.Text = tbl.Rows[0]["Patient_Name"].ToString();
                textBox9.Text = tbl.Rows[0]["Patient_DOB"].ToString();
                textBox5.Text = tbl.Rows[0]["Patient_Add1"].ToString();
                textBox6.Text = tbl.Rows[0]["Patient_Add2"].ToString();
                textBox12.Text = tbl.Rows[0]["Patient_Ph-No"].ToString();
                textBox8.Text = tbl.Rows[0]["Patient_Cell-No"].ToString();
                textBox10.Text = tbl.Rows[0]["Date"].ToString();
                textBox4.Text = tbl.Rows[0]["Branch_Location"].ToString();
                textBox11.Text = tbl.Rows[0]["city"].ToString();
                textBox1.Text = tbl.Rows[0]["Amount_of_Blood"].ToString();
                textBox13.Text = tbl.Rows[0]["Patient_Email"].ToString();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Data Couldn't be fetched");
            }
        }
    }
}
        
    

