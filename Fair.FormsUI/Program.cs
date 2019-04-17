using System;
using System.Windows.Forms;

namespace Fair.FormsUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var standApplicationForm = new StandApplicationForm();
            Application.Run(standApplicationForm);
        }
    }
}