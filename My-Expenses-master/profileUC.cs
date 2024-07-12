using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Expenses
{
    public partial class ProfileUC : UserControl
    {
        public static decimal UserSalary { get; private set; }
        public static string UserName { get; private set; }
        public static string UserSurname { get; private set; }

        public ProfileUC()
        {
            InitializeComponent();
            btnCapture.Click += btnCapture_Click;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            decimal salary;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
            {
                MessageBox.Show("Please enter your name and surname.");
                return;
            }

            if (!decimal.TryParse(txtSalary.Text, out salary))
            {
                MessageBox.Show("Please enter a valid salary.");
                return;
            }

            UserName = name;
            UserSurname = surname;
            UserSalary = salary;

            lblNameSurname.Text = $"{UserName} {UserSurname}";
            MessageBox.Show("Profile saved successfully!");
        }

        }
    }

