using CommunityToolkit.Mvvm.ComponentModel;

namespace RHOKSAutomationConsole.Pegging
{
    public partial class PeggingSettingsM : ObservableObject
    {

        [ObservableProperty] string? m_OreDefSourcePROD;
        [ObservableProperty] string? m_ProcessingRootPROD;
        [ObservableProperty] string? m_OreDefSourceTEST;
        [ObservableProperty] string? m_ProcessingRootTEST;


    }
}
