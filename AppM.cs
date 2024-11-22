using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Hosting;
using System.Globalization;
using System.IO.IsolatedStorage;
using System.Reflection;

namespace RHOKSAutomationConsole;

public partial class AppM : ObservableObject
{

    // Assembly
    [ObservableProperty] Assembly? m_AppAssembly = Assembly.GetExecutingAssembly();

    // App
    [ObservableProperty] string? m_ApplicationName = Assembly.GetExecutingAssembly().GetName().Name;
    [ObservableProperty] CultureInfo? m_ApplicationCulture = CultureInfo.CurrentCulture;

    // Serilog
    [ObservableProperty] string? m_SerilogSettingsFilename;
    [ObservableProperty] IsolatedStorageFile m_SerilogIsolatedStorage = IsolatedStorageFile.GetMachineStoreForAssembly();
    [ObservableProperty] string? m_SerilogSettingsFolderFullPath;

    // AppSettings
    [ObservableProperty] string? m_AppSettingsFilename;
    [ObservableProperty] IsolatedStorageFile m_ApplicationIsolatedStorage = IsolatedStorageFile.GetMachineStoreForApplication();
    [ObservableProperty] string? m_AppSettingsFolderFullPath;

    // UserSettings

    //Command Line Arguments
    [ObservableProperty] string[]? m_CommandLineArgs = Environment.GetCommandLineArgs();


    public enum SettingsTypes
    {
        Application,
        Serilog,
        RangerDrillPlods,
        WSGDownholePlods,
        WSGWellReports,
        User
    }


    //SplashScreen
    [ObservableProperty] ManualResetEvent? m_ResetSplashCreated;
    [ObservableProperty] Thread? m_SplashThread;

    [ObservableProperty] IHost? m_ApplicationHost;

    [ObservableProperty] bool m_IsNetworkActive = false;

}