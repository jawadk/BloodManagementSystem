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
    public partial class Form1 : Form
    {
        Connection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con = new Connection();
                string q = "Select Blood_Group from donor";
                OleDbCommand cmd = new OleDbCommand(q, con.connect());
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                }

                con = new Connection();
                string a = "Select Branch_Location from donor";
                OleDbCommand cm = new OleDbCommand(a, con.connect());
                OleDbDataReader read = cm.ExecuteReader();
                while (read.Read())
                {
                    comboBox2.Items.Add(read[0].ToString());
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry, Couldn't Connect with the Database");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                      
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                Donor donor = new Donor(textBox1.Text, comboBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, comboBox2.Text, textBox11.Text, textBox12.Text, textBox13.Text);
                donor.insertData();
                MessageBox.Show("Successfully Saved");
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Data Couldn't be Saved");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            comboBox2.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            MessageBox.Show("Data has been Erased");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
