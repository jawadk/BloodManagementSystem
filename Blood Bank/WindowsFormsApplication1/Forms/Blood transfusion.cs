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
    public partial class Blood_transfusion : Form
    {
        Blood B;
        Connection connect;

        public Blood_transfusion()
        {
            InitializeComponent();
        }

        private void Blood_transfusion_Load(object sender, EventArgs e)
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Rbutn = null;
                if (radioButton1.Checked)
                {
                    Rbutn = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    Rbutn = radioButton2.Text;
                }
                DateTime d = dateTimePicker1.Value;
                DateTime d1 = dateTimePicker2.Value;
                B = new Blood(comboBox1.Text, d, d1, Rbutn, textBox4.Text, textBox5.Text, textBox6.Text);
                B.insertData();
                MessageBox.Show("Data Inserted Successfully");
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry, Data Cannot be Inserted");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cover c1 = new Cover();
            c1.Show();
        }
    }
}
