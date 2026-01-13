using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace WeAreCars.Forms
{
    /// <summary>
    /// Welcome splash screen that displays when the application starts
    /// </summary>
    public partial class SplashScreen : Form
    {
        // Timer for automatic progression to login screen
        private System.Windows.Forms.Timer _timer;
        
        public SplashScreen()
        {
            InitializeComponent();
            
            // Create a timer to automatically close the splash screen after 5 seconds
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 5000; // 5 seconds
            _timer.Tick += Timer_Tick;
        }
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            
            // Open the login form
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }
        
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            // Start the timer when the form loads
            _timer.Start();
        }
    }
} 