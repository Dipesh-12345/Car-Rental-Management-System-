using System;
using System.Drawing;
using System.Windows.Forms;

namespace WeAreCars.Forms
{
    public class LoginForm : Form
    {
        private TextBox _usernameTextBox;
        private TextBox _passwordTextBox;
        private Button _loginButton;
        private Label _statusLabel;

        // Fixed credentials for staff login
        private const string ValidUsername = "sta001";
        private const string ValidPassword = "givemethekeys123";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Initialize form properties
            this.Text = "WeAreCars - Staff Login";
            this.Size = new Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // Create title label
            Label titleLabel = new Label
            {
                Text = "Staff Login",
                Font = new Font("Arial", 20, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Size = new Size(800, 50),
                Location = new Point(0, 100)
            };

            // Create username label and textbox
            Label usernameLabel = new Label
            {
                Text = "Username:",
                Font = new Font("Arial", 12, FontStyle.Regular),
                Size = new Size(100, 25),
                Location = new Point(250, 200)
            };

            _usernameTextBox = new TextBox
            {
                Font = new Font("Arial", 12, FontStyle.Regular),
                Size = new Size(200, 25),
                Location = new Point(350, 200)
            };

            // Create password label and textbox
            Label passwordLabel = new Label
            {
                Text = "Password:",
                Font = new Font("Arial", 12, FontStyle.Regular),
                Size = new Size(100, 25),
                Location = new Point(250, 250)
            };

            _passwordTextBox = new TextBox
            {
                Font = new Font("Arial", 12, FontStyle.Regular),
                Size = new Size(200, 25),
                Location = new Point(350, 250),
                PasswordChar = '*'
            };

            // Create login button
            _loginButton = new Button
            {
                Text = "Login",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Size = new Size(120, 40),
                Location = new Point(340, 320),
                BackColor = Color.LightBlue
            };
            _loginButton.Click += LoginButton_Click;

            // Create status label for error messages
            _statusLabel = new Label
            {
                Text = "",
                Font = new Font("Arial", 10, FontStyle.Regular),
                ForeColor = Color.Red,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Size = new Size(500, 25),
                Location = new Point(150, 380)
            };

            // Add controls to form
            this.Controls.Add(titleLabel);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(_usernameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(_passwordTextBox);
            this.Controls.Add(_loginButton);
            this.Controls.Add(_statusLabel);

            // Set accept button for form
            this.AcceptButton = _loginButton;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = _usernameTextBox.Text.Trim();
            string password = _passwordTextBox.Text;

            // Check credentials
            if (username == ValidUsername && password == ValidPassword)
            {
                _statusLabel.Text = "Login successful!";
                _statusLabel.ForeColor = Color.Green;

                // Open the booking form
                var bookingForm = new BookingForm();
                bookingForm.Show();

                // Hide login form
                this.Hide();
            }
            else
            {
                _statusLabel.Text = "Invalid username or password. Please try again.";
                _statusLabel.ForeColor = Color.Red;
                _passwordTextBox.Text = "";
                _passwordTextBox.Focus();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            // Close the entire application if the login form is closed
            if (Application.OpenForms.Count == 1)
            {
                Application.Exit();
            }
        }
    }
}