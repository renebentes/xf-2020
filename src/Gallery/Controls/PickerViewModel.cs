using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Gallery.Controls;

public sealed partial class PickerViewModel
    : BaseViewModel
{
    [ObservableProperty]
    private int _selectedIndex;

    [RelayCommand]
    private void ClearSelected()
        => SelectedIndex = -1;
}