using CommunityToolkit.Mvvm.ComponentModel;

namespace RHOKSAutomationConsole.CollarSurvey
{
    public partial class CollarSurveyPickupM : ObservableObject
    {

        [ObservableProperty] string m_OreDefSourcePROD = string.Empty;
        [ObservableProperty] string m_ProcessingRootPROD = string.Empty;
        [ObservableProperty] string m_OreDefSourceTEST = string.Empty;
        [ObservableProperty] string m_ProcessingRootTEST = string.Empty;


    }
}
