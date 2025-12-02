using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Gallery.Controls;

public sealed partial class ProgressBarViewModel
    : BaseViewModel
{
    [ObservableProperty]
    private double _progress;

    [RelayCommand]
    private void Process()
        => Progress = 1;
}