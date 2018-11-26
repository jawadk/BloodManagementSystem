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
    public partial class NewDonorForm : Form
    {
        DonorManager donorManager;
        public NewDonorForm()
        {
            InitializeComponent();
        }

        private void NewDonorForm_Load(object sender, EventArgs e)
        {
            textBox1.Hide();
            label12.Hide();

            try
            {
                donorManager = new DonorManager();
                OleDbDataReader reader = donorManager.getBloodGroup();
              
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                }

                OleDbDataReader read = donorManager.GetBranchLocation();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserType userType = new UserType();
            userType.Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text != "" && comboBox1.Text != "")
                {
                    Donor donor = new Donor(textBox1.Text, comboBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, comboBox2.Text, textBox11.Text, textBox12.Text, textBox13.Text);
                    donorManager.insertData(donor);
                    MessageBox.Show("Successfully Saved");
                }
                else
                {
                    MessageBox.Show("Doner Name \n Blood Group can not be empty.!");
                }

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Data Couldn't be Saved");
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
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
    }
}
