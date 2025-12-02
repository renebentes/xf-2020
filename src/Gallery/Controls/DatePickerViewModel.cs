using CommunityToolkit.Mvvm.ComponentModel;

namespace Gallery.Controls;

public sealed partial class DatePickerViewModel
    : BaseViewModel
{
    [ObservableProperty]
    private DateTime _maximumDate = DateTime.Today.AddDays(5);

    [ObservableProperty]
    private DateTime _minimumDate = DateTime.Today.AddDays(-5);

    [ObservableProperty]
    private DateTime _selectedDate = DateTime.Today;
}