﻿using System;
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
            UserTypeForm f2 = new UserTypeForm();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f3 = new LoginForm();
            f3.Show();
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
            WelcomeForm f11 = new WelcomeForm();
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
            //Form4 R = new Form4();
            RegMedicineForm R = new RegMedicineForm();
            R.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            BloodTransfusion b = new BloodTransfusion();
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

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            BloodTransfusion bt = new BloodTransfusion();
            bt.Show();
        }
    }
}
