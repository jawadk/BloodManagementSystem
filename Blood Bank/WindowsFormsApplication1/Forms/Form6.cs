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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible =true;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewTest T = new NewTest();
            T.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertResult I = new InsertResult();
            I.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Size = new Size(75, 43);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new Size(75, 27);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Size = new Size(99,38);
            
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Size = new Size(99, 27);
           
        }

     

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.Size = new Size(75, 27);
        }

        private void button3_MouseHover_1(object sender, EventArgs e)
        {
            button3.Size = new Size(115, 38);
        }

        private void button3_MouseLeave_1(object sender, EventArgs e)
        {
            button3.Size = new Size(115, 27);
        }
    }
}
