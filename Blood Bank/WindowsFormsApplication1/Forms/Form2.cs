using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
            else if (radioButton2.Checked)
            {
                this.Hide();
                Form5 f5 = new Form5();
                f5.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cover c = new Cover();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.Hide();
                Form8 f8 = new Form8();
                f8.Show();
            }
            else if (radioButton2.Checked)
            {
                this.Hide();
                Form7 f7 = new Form7();
                f7.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
