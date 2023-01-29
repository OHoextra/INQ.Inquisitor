using System.Reflection;
using Inquisitor.Application.Models.AppSettings;
using Inquisitor.Pages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using ILogger = Serilog.ILogger;
using Log = Serilog.Log;
using JsonSerializer = Inquisitor.Application.Utils.JsonSerializer;

#pragma warning disable CA1416 //App requires Android version to be 21.0 or later

namespace Inquisitor;

public static class MauiProgram
{
    private static ILogger _logger;

	public static MauiApp CreateMauiApp()
	{
        var builder = MauiApp.CreateBuilder();

        SetupLogging(builder);

        SetupConfiguration(builder);

        SetupServices(builder);

        builder
            .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

        return builder.Build();
	}

    private static void SetupServices(MauiAppBuilder builder)
    {
        builder.Services.AddTransient<HomePage>();
    }

    private static void SetupConfiguration(MauiAppBuilder builder)
    {
        var assembly = Assembly.GetExecutingAssembly();
        const string configFileName = "Inquisitor.AppSettings.json";
        using var stream = assembly.GetManifestResourceStream(configFileName);

        if (stream == null)
            throw new InvalidOperationException(configFileName + " does not seem to be included to the executing assembly as a EmbeddedResource");

        var config = new ConfigurationBuilder()
            .AddJsonStream(stream)
            .Build();

        builder.Configuration
            .AddConfiguration(config);

        var settings = config.GetRequiredSection("Settings").Get<Settings>();

        _logger.Information($"====== Configuration ======");
        _logger.Information($"Configuration file: {configFileName}");
        _logger.Information($"Configuration settings: {Environment.NewLine} {JsonSerializer.Serialize(settings)}");
    }

    private static void SetupLogging(MauiAppBuilder builder)
    {
        try
        {
            var myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            var logDirectoryPath = Path.Combine(myDocumentsPath, "Inquisitor-logs");
            if (!Directory.Exists(logDirectoryPath))
                Directory.CreateDirectory(logDirectoryPath);

            var logFilePath = Path.Combine(logDirectoryPath, "Inquisitor-logs.log");

            const string serilogTemplate =
                "{Timestamp:dd-MM-yyyy HH:mm:ss} [{Level:u3}][{SourceContext}]{Message}{NewLine}{Exception}";
#if DEBUG
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Console(
                    outputTemplate: serilogTemplate)
                .WriteTo.File(
                    logFilePath,
                    outputTemplate: serilogTemplate,
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 31)
                .CreateLogger();

            builder.Logging.AddDebug();
#else
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            .Enrich.FromLogContext()
            .WriteTo.File(
                logFilePath, 
                outputTemplate: serilogOutputTemplate,
                rollingInterval: RollingInterval.Day, 
                retainedFileCountLimit:31) 
            .CreateLogger();
#endif

            builder.Logging.AddSerilog(dispose: true);

            _logger = Log.ForContext(typeof(MauiProgram));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to setup logging.");
            Console.Write("Exception: " + JsonSerializer.Serialize(ex));
        }
    }
}
