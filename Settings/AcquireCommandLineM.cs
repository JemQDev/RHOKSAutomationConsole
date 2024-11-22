using CommunityToolkit.Mvvm.ComponentModel;

namespace RHOKSAutomationConsole.Settings;

public partial class AcquireCommandLineM : ObservableObject
{
    [ObservableProperty] string m_CommandLineExe = string.Empty;
    [ObservableProperty] string m_ACQCommandLineUsername = string.Empty;
    [ObservableProperty] string m_ACQCommandLinePassword = string.Empty;
}
