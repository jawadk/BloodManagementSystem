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
    public partial class Form5 : Form
    {
        Connection connect;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                connect = new Connection();
                string q = "Select Blood_Group from patient";
                OleDbCommand cmd = new OleDbCommand(q, connect.connect());
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                }

                connect = new Connection();
                string a = "Select Branch_Location from patient";
                OleDbCommand cm = new OleDbCommand(a, connect.connect());
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

        private void label20_Click(object sender, EventArgs e)
        {

        }         

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Patient patient = new Patient(textBox1.Text, comboBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, comboBox2.Text, textBox11.Text, textBox12.Text, textBox13.Text);
                patient.insertData();
                MessageBox.Show("Successfully Saved");
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Data Couldn't be saved");
            }
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
