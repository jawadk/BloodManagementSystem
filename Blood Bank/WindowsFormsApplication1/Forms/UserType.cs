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
    public partial class UserType : Form
    {
        public UserType()
        {
            InitializeComponent();
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            if (!radioButton_Donor.Checked && !radioButton_Patient.Checked)
            {
                MessageBox.Show("Please select any option");

            }
            if (radioButton_Donor.Checked)
            {
                this.Hide();
                NewDonorForm newDonorForm = new NewDonorForm();
                newDonorForm.Show();
            }
            else if (radioButton_Patient.Checked)
            {
                this.Hide();
                AddNewPatientForm addNewPatientForm = new AddNewPatientForm();
                addNewPatientForm.Show();
            }

        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            if (!radioButton_Donor.Checked && !radioButton_Patient.Checked)
            {
                MessageBox.Show("Please select any option");

            }
            if (radioButton_Donor.Checked)
            {
                this.Hide();
                DonorSearchForm donorSearchForm = new DonorSearchForm();
                donorSearchForm.Show();
            }
            else if (radioButton_Patient.Checked)
            {
                this.Hide();
                Form7 f7 = new Form7();
                f7.Show();
            }
        }

        private void button_GoBack(object sender, EventArgs e)
        {
            this.Hide();
            Cover cover = new Cover();
            cover.Show();
        }
    }
}
