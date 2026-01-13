using System;
using System.Drawing;
using System.Windows.Forms;

namespace WeAreCars.Forms
{
    public class SplashScreen : Form
    {
        private Timer _timer;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Initialize form properties
            this.Text = "WeAreCars Rental System";
            this.Size = new Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // Create and add controls
            Label titleLabel = new Label
            {
                Text = "WeAreCars Rental System",
                Font = new Font("Arial", 24, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Size = new Size(800, 50),
                Location = new Point(0, 150)
            };

            Label welcomeLabel = new Label
            {
                Text = "Welcome to the car rental management system",
                Font = new Font("Arial", 16, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Size = new Size(800, 50),
                Location = new Point(0, 220)
            };

            Label instructionsLabel = new Label
            {
                Text = "Please wait while the system initializes...",
                Font = new Font("Arial", 12, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Size = new Size(800, 40),
                Location = new Point(0, 280)
            };

            this.Controls.Add(titleLabel);
            this.Controls.Add(welcomeLabel);
            this.Controls.Add(instructionsLabel);

            // Set up timer for automatic login form opening
            _timer = new Timer
            {
                Interval = 3000 // 3 seconds
            };
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            _timer.Stop();

            // Create and show login form
            var loginForm = new LoginForm();
            loginForm.Show();

            // Hide the splash screen
            this.Hide();
        }
    }
}