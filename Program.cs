using CTI_RPA.SYS.Services;
using CTI_RPA.SYS.Services.Interface;
using Gma.System.MouseKeyHook;

namespace CTI_RPA.SYS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LoaderIntro loaderIntro = new LoaderIntro();
            Application.Run(loaderIntro);

            MainForm mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}