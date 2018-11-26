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
    public partial class DonorDetailForm : Form
    {
        Connection con;
        Donor d1;
        DonorManager donorManager = new DonorManager();

        public int ID { get; set; }
        public DonorDetailForm()
        {
            InitializeComponent();
        }

         public DonorDetailForm(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "")
                {
                    DataTable tbl = new DataTable();
                    //d1 = new Donor();
                    tbl = donorManager.selectData(comboBox1.Text);
                    //tbl = d1.selectData(comboBox1.Text);
                    //comboBox1.Text = tbl.Rows[0]["Donor_Number"].ToString();
                    comboBox1.Enabled = false;
                    textBox2.Text = tbl.Rows[0]["Blood_Group"].ToString();
                    textBox3.Text = tbl.Rows[0]["Donor_Name"].ToString();
                    textBox4.Text = tbl.Rows[0]["Donor_DOB"].ToString();
                    textBox5.Text = tbl.Rows[0]["Donor_Add1"].ToString();
                    textBox6.Text = tbl.Rows[0]["Donor_Add2"].ToString();
                    textBox7.Text = tbl.Rows[0]["Donor_Ph-No"].ToString();
                    textBox8.Text = tbl.Rows[0]["Donor_Cell-No"].ToString();
                    textBox9.Text = tbl.Rows[0]["date"].ToString();
                    textBox10.Text = tbl.Rows[0]["Branch_Location"].ToString();
                    textBox11.Text = tbl.Rows[0]["city"].ToString();
                    textBox12.Text = tbl.Rows[0]["Amount_of_Blood"].ToString();
                    textBox13.Text = tbl.Rows[0]["Donor_Email"].ToString();
                }
                else
                {
                    MessageBox.Show("Please select Donor ID");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Data Couldn't be Retrieved");
            }
        } 

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text != "" && comboBox1.Text != "")
                {
                    d1 = new Donor(comboBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text);
                    donorManager.updateData(Convert.ToInt32(comboBox1.Text), d1);
                    MessageBox.Show("Data Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Donor ID and Name can not be empty");
                }
                
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Data Couldn't be Updated");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            MessageBox.Show("Data has been Erased");
            comboBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonorSearchForm f8 = new DonorSearchForm();
            f8.Show();
        }

        private void Form10_Load(object sender, EventArgs e)
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
