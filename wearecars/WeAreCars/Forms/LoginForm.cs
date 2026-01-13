using System;
using System.Drawing;
using System.Windows.Forms;
using WeAreCars.Utils;

namespace WeAreCars.Forms
{
    /// <summary>
    /// Login form for user authentication
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            
            // Validate login credentials
            string validationError = Validator.ValidateLogin(username, password);
            
            if (validationError != null)
            {
                // Display error message
                lblError.Text = validationError;
                lblError.Visible = true;
                return;
            }
            
            // Login successful
            lblError.Visible = false;
            
            // Open main form and close login form
            this.Hide();
            var mainForm = new BookingForm();
            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.Show();
        }
        
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Set focus to username field
            txtUsername.Focus();
            
            // Hide error message initially
            lblError.Visible = false;
        }
    }
} 