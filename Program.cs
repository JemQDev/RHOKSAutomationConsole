using CommandLine;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RHOKSAutomationConsole.CollarSurvey;
using RHOKSAutomationConsole.EFACQ;
using RHOKSAutomationConsole.EFRHOKS2020;
using RHOKSAutomationConsole.EFRHOKS2024;
using RHOKSAutomationConsole.Pegging;
using RHOKSAutomationConsole.Settings;

namespace RHOKSAutomationConsole;

public class Options
{
    [Option("DataSource", Required = true, Default = "TEST", HelpText = "Data Source as TEST or PROD")]
    public string? DataSource { get; set; }
}

internal class Program
{
    //private static AppM? ApplicationData;
    private static AcquireCommandLineM? ACQCommandLineData;
    private static CollarSurveyPickupM? CollarSurveyPickupSettings;
    private static PeggingSettingsM? PeggingSettings;
    private static SerilogSettingsM? SerilogSettings;

    static void Main(string[] args)
    {
        Parser.Default.ParseArguments<Options>(args)
             .WithParsed<Options>(options =>
             {
                 
                 using IHost host = CreateHostBuilder(options).Build();
                 IConfiguration config = host.Services.GetRequiredService<IConfiguration>();

                 CollarSurveyPickupSettings = config.GetSection("CollarSurveyPickups").Get<CollarSurveyPickupM>() ?? new CollarSurveyPickupM();
                 PeggingSettings = config.GetSection("OreDefPegging").Get<PeggingSettingsM>() ?? new PeggingSettingsM();
                 SerilogSettings = config.GetSection("Serilog").Get<SerilogSettingsM>() ?? new SerilogSettingsM();

                 var cspvm = host.Services.GetService<CollarSurveyPickupVM>();
             });
    }

    #region HostBuilder
    public static IHostBuilder CreateHostBuilder(Options optionsq) =>
        Host.CreateDefaultBuilder()
        .ConfigureAppConfiguration((context, config) =>
        {
            config
            .AddJsonFile(string.Concat(Directory.GetCurrentDirectory(), "\\Settings\\appsettings.json"), optional: false, reloadOnChange: true)
            .AddJsonFile(string.Concat(Directory.GetCurrentDirectory(), "\\Settings\\SerilogSettings.json"), optional: false, reloadOnChange: true)
            .AddConfiguration(context.Configuration)
            .AddUserSecrets<Program>()
            .AddEnvironmentVariables();

        })
        .ConfigureServices((hostContext, services) =>
        {
            IConfiguration config = hostContext.Configuration;

            services.Configure<SerilogSettingsM>(options => config.GetSection("Serilog").Bind(options));
            services.Configure<AcquireCommandLineM>(options => config.GetSection("SECRET_ACQ_Credentials").Bind(options));
            services.Configure<CollarSurveyPickupM>(options => config.GetSection("CollarSurveyPickups").Bind(options));
            services.Configure<PeggingSettingsM>(options => config.GetSection("OreDefPegging").Bind(options));

            services.AddDbContext<RHOKS_2020Context>(
                options => options.UseSqlServer(
                    $"Data Source=" +
                    $"{config.GetSection("SqlConfigurations:VM.SQL:SQLServer").Get<string>()}" +
                    $"\\" +
                    $"{config.GetSection("SqlConfigurations:VM.SQL:SQLInstance").Get<string>()};" +
                    $"Initial Catalog={config.GetSection("SqlConfigurations:VM.SQL:SQLDatabaseRHOKS2020").Get<string>()}" +
                    $";Trusted_Connection=True;TrustServerCertificate=True;", x => x.UseNetTopologySuite()).EnableSensitiveDataLogging(true), ServiceLifetime.Transient);

            services.AddDbContext<RHOKS_2024Context>(
                options => options.UseSqlServer(
                    $"Data Source=" +
                    $"{config.GetSection("SqlConfigurations:VM.SQL:SQLServer").Get<string>()}" +
                    $"\\" +
                    $"{config.GetSection("SqlConfigurations:VM.SQL:SQLInstance").Get<string>()};" +
                    $"Initial Catalog={config.GetSection("SqlConfigurations:VM.SQL:SQLDatabaseRHOKS2024").Get<string>()}" +
                    $";Trusted_Connection=True;TrustServerCertificate=True;", x => x.UseNetTopologySuite()).EnableSensitiveDataLogging(true), ServiceLifetime.Transient);

            services.AddDbContext<ACQContext>(
                options => options.UseSqlServer(
                    $"Data Source=" +
                    $"{config.GetSection("SqlConfigurations:ACQ.SQL:SQLServer").Get<string>()}" +
                    $"\\" +
                    $"{config.GetSection("SqlConfigurations:ACQ.SQL:SQLInstance").Get<string>()};" +
                    $"Initial Catalog={config.GetSection("SqlConfigurations:ACQ.SQL:SQLDatabaseACQ").Get<string>()}" +
                    $";Trusted_Connection=True;TrustServerCertificate=True;", x => x.UseNetTopologySuite()).EnableSensitiveDataLogging(true), ServiceLifetime.Transient);

            services.AddSingleton<Options>(optionsq);

            services.AddSingleton<AppM>();

            services.AddTransient<AcquireCommandLineM>();
            services.AddSingleton<SerilogSettingsM>();

            services.AddSingleton<PeggingSettingsM>();

            services.AddSingleton<CollarSurveyPickupM>();
            services.AddSingleton<CollarSurveyPickupVM>();


        }
    //.UseSerilog((context, services, configuration) => configuration
    //.ReadFrom.Configuration(context.Configuration)
    //.ReadFrom.Services(services)
    );
    #endregion HostBuilder


}
