using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Gallery.Controls;

public sealed partial class StepperViewModel : BaseViewModel
{
    [ObservableProperty]
    private double _currentValue;

    [ObservableProperty]
    private double _previousValue;

    [RelayCommand]
    private void Increment(EventArgs eventArgs)
    {
        if (eventArgs is ValueChangedEventArgs valueChangedEventArgs)
        {
            PreviousValue = valueChangedEventArgs.OldValue;
            CurrentValue = valueChangedEventArgs.NewValue;
        }
    }
}
