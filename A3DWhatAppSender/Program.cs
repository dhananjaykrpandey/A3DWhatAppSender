

namespace A3DWhatAppSender
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ThemeResolutionService.ApplicationThemeName = "Fluent";

            var db = new LiteDB.LiteDatabase(Path.Combine(Application.StartupPath, "A3DWhatsapp.db"));
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMainMDI());
        }
    }
}