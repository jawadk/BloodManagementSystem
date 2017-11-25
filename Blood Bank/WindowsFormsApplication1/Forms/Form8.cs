using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class Form8 : Form
    {
        //Donor's Class Object
        Donor d1;
        Connection con;

        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Select Quert to search a specific donor
            try
            {
                if (comboBox1.Text != "")
                {
                    DataTable dtable = new DataTable();
                    d1 = new Donor();
                    dtable = d1.getTable("SELECT * From `donor` WHERE `Donor_Number` = " + comboBox1.Text);
                    dataGridView1.DataSource = dtable;                    
                }
                else
                {
                    MessageBox.Show("Please select Donor ID");
                }                
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Couldn't Search the Data");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Delete Quert to delete a specific donor
            try
            {
                if (comboBox1.Text != "")
                {
                    DataTable dtable = new DataTable();
                    d1 = new Donor();
                    dtable = d1.getTable("DELETE * From `donor` where Donor_Number = " + comboBox1.Text);
                    dataGridView1.DataSource = dtable;
                    MessageBox.Show("Data Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Please select donor id");
                }
                
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Couldn't Delete the Data");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Select Quert to search all donors
            try
            {
                DataTable dtable = new DataTable();
                d1 = new Donor();
                dtable = d1.getTable("SELECT * From donor");
                dataGridView1.DataSource = dtable;
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Couldn't find the Records");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                this.Hide();
                Form f10 = new Form10(Convert.ToInt32(comboBox1.Text));
                f10.Show();
            }
            else
            {
                MessageBox.Show("Please select donor ID");
            }
            
            
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            try
            {
                con = new Connection();
                string q = "Select Donor_Number from donor";
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
