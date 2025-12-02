using CommunityToolkit.Mvvm.ComponentModel;

namespace Gallery.Controls;

public sealed partial class TimePickerViewModel
    : BaseViewModel
{
    [ObservableProperty]
    private TimeSpan _selectedTime;
}