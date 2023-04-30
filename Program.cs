using time_sheet.Forms.Change_User_Type;

namespace tome_sheet
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

            ApplicationConfiguration.Initialize();
            MainForm mainform = new MainForm();
            mainform.Show();
            Application.Run();
        }
    }
}