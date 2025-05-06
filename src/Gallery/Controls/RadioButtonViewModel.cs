using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Gallery.Controls;

public sealed partial class RadioButtonViewModel : BaseViewModel
{
    [ObservableProperty]
    private string _languageSelected = string.Empty;
}