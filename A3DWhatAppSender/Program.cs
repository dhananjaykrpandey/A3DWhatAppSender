

using A3DWhatAppSender.Classes.Common;

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

           
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMainMDI());
        }
    }
}