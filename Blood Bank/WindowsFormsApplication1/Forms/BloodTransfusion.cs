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
    public partial class BloodTransfusion : Form
    {
        Blood B;
        BloodManager bloadManager;
        

        public BloodTransfusion()
        {
            InitializeComponent();
        }

        private void Blood_transfusion_Load(object sender, EventArgs e)
        {
            try
            {
                bloadManager = new BloodManager();
                OleDbDataReader reader = bloadManager.GetPatientNumber();
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
    
        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cover cover = new Cover();
            cover.Show();
        }

        private void Save_Click(object sender, EventArgs e)
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
                bloadManager.insertData(B);
                MessageBox.Show("Data Inserted Successfully");
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry, Data Cannot be Inserted");
            }
        }
    }
}
