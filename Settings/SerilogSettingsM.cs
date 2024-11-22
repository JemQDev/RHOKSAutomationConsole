using CommunityToolkit.Mvvm.ComponentModel;

namespace RHOKSAutomationConsole.Settings;

public partial class SerilogSettingsM : ObservableObject
{
    [ObservableProperty] string[]? m_Using;
    [ObservableProperty] MinimumLevelData m_MinimumLevel = new();

    [ObservableProperty] string[]? m_Enrich;
    [ObservableProperty] WriteToOptions[]? m_WriteTo;
}

public partial class MinimumLevelData : ObservableObject
{
    [ObservableProperty] string m_Default = "Information";
    [ObservableProperty] Dictionary<string, string>? m_Override;
}

public partial class Overridedata : ObservableObject
{
    [ObservableProperty] string? m_OverrideName;
    [ObservableProperty] string? m_OverrideValue;
}

public partial class WriteToOptions : ObservableObject
{
    [ObservableProperty] string? m_Name;
    [ObservableProperty] Dictionary<string, string>? m_Args;
}
