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
    public partial class Cover : Form
    {
        public Cover()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void hover(object sender, EventArgs e)
        {
            button1.Size = new Size(130, 120);
        }

        private void leave(object sender, EventArgs e)
        {
            button1.Size = new Size(91, 83);
        }

        private void ok(object sender, EventArgs e)
        {
            button2.Size = new Size(130, 120);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Size = new Size(91, 83);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.Size = new Size(130, 120);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Size = new Size(91, 83);
        }

        private void button3_DragOver(object sender, DragEventArgs e)
        {
            button1.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RegMedicine R = new RegMedicine();
            R.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blood_transfusion b = new Blood_transfusion();
            b.Show();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.Size = new Size(130, 120);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Size = new Size(91,83);
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.Size = new Size(130, 120);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.Size = new Size(91,83);
        }
    }
}
