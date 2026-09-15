using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDataGrid
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

#if NET9_0_OR_GREATER
            Application.SetColorMode(SystemColorMode.System);
#endif
#if NET11_0_OR_GREATER
            Application.SetDefaultVisualStylesMode(VisualStylesMode.Latest);
            Application.SetDefaultFormRevealMode(FormRevealMode.Deferred);
#endif

            Application.Run(new Form1());
        }
    }
}