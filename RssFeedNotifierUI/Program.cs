using RssFeedNotifier;
using System;
using System.Windows.Forms;

namespace RssFeedNotifierUI
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new RssFeederForm();
            Application.Run(form);
        }
    }
}
