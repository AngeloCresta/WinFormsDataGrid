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

            Application.Run(new Form1());
        }
    }
}