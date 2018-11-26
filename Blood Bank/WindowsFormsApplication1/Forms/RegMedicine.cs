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
    public partial class RegMedicine : Form
    {
        RegMedineTemp M;
        RegMedineManager regManager;
        Connection connect;
        public RegMedicine()
        {
            InitializeComponent();
        }

        private void RegMedicine_Load(object sender, EventArgs e)
        {   
            try
            {
                regManager = new RegMedineManager();
                OleDbDataReader reader = regManager.getPatients();
               
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "")
                {
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
                    {
                        DateTime d = dateTimePicker1.Value;
                        M = new RegMedineTemp(comboBox1.Text, textBox2.Text, textBox1.Text, textBox7.Text, textBox5.Text, textBox6.Text, textBox4.Text, textBox3.Text, d);
                        
                        regManager.insertData(M);
                        MessageBox.Show("Data inserted Successfully");

                        this.Hide();
                        Cover c = new Cover();
                        c.Show();
                    }
                    else
                    {
                        MessageBox.Show("All fields are required");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Patient ID can not be empty");
                }
                
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry Data Cannot be Saved");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cover c = new Cover();
            c.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}