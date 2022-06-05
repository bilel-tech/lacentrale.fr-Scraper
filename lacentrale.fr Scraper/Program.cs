using System;
using System.Windows.Forms;

namespace lacentrale.fr_Scraper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DevForm());
        }
    }
}
