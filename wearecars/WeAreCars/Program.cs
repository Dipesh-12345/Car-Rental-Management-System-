using System;
using System.Windows.Forms;
using WeAreCars.Forms;

namespace WeAreCars
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Launch the SplashScreen as the first form
            Application.Run(new SplashScreen());
        }
    }
}