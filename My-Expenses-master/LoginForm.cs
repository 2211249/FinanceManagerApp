using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace My_Expenses
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Set form properties for border radius
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));

            // Add welcome label
            Label lblWelcome = new Label
            {
                Text = "Welcome Back",
                Font = new Font("Arial", 24, FontStyle.Bold),
                AutoSize = true
            };
            this.Controls.Add(lblWelcome);

            // Center the welcome label
            this.SizeChanged += (s, e) =>
            {
                lblWelcome.Location = new Point((this.Width - lblWelcome.Width) / 2, 20);
            };

            // Set placeholder text in textboxes
            SetPlaceholderText(txtUsername, "Enter username");
            SetPlaceholderText(txtPassword, "Enter password");
        }

        // Method to set placeholder text in TextBox
        private void SetPlaceholderText(TextBox textBox, string placeholder)
        {
            textBox.ForeColor = Color.Gray;
            textBox.Text = placeholder;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Hardcoded credentials
            string validUsername = "admin";
            string validPassword = "1234";

            // Validate credentials
            if (username == validUsername && password == validPassword)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials, please try again.");
            }
        }

        // P/Invoke to create a rounded rectangle region for the form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);
    }
}
