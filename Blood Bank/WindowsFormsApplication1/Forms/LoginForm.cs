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
    public partial class LoginForm : Form
    {
        Login lg;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    lg = new Login(textBox1.Text, textBox2.Text);
                    bool login = lg.getLogin();
                    if (login == true)
                    {
                        this.Hide();
                        Form6 f6 = new Form6();
                        f6.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name or Password");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter User Name & Password to Login");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Couldn't connect with the Database");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cover c = new Cover();
            c.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
