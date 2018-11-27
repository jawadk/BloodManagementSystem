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
    public partial class AddNewPatientForm : Form
    {
        PatientManager patientManager = new PatientManager();
        
        public AddNewPatientForm()
        {
            InitializeComponent();
        }

        private void AddNewPatientForm_Load(object sender, EventArgs e)
        {
            textBox1.Hide();
            label2.Hide();
            try
            {
                OleDbDataReader reader = patientManager.GetBloodGroup();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                }


                OleDbDataReader read = patientManager.GetBranchLocation();
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text != "" && comboBox1.Text != "" && textBox4.Value.Date < DateTime.Today.Date)
                {
                    Patient patient = new Patient(comboBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, comboBox2.Text, textBox11.Text, textBox12.Text, textBox13.Text);
                    
                    //Inserting patient data in Database
                    patientManager.insertData(patient);
                    MessageBox.Show("Successfully Saved");                    
                }
                else
                {
                    MessageBox.Show("Please enter required fields: Name, Blood group and DOB should be less then today's date");
                }
                
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
            UserTypeForm f2 = new UserTypeForm();
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
