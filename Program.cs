using CTI_RPA.SYS.Services;
using CTI_RPA.SYS.Services.Interface;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CTI_RPA.SYS;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // Note: The main entry point for the application.
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.s
        ApplicationConfiguration.Initialize();
        var loaderIntro = new LoaderIntro();
        Application.Run(loaderIntro);
        // Main Form Initialization
        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;
        try
        {
            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    public static IServiceProvider? ServiceProvider { get; private set; }
    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) => {
                services.AddScoped<IMacroService, MacroService>();
                services.AddScoped<IFileManagerService, FileManagerService>();
                services.AddScoped<MainForm>();
            });
    }

}
