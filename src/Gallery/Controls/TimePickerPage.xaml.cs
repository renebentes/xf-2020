namespace Gallery.Controls;

public partial class TimePickerPage
    : BasePage<TimePickerViewModel>
{
    public TimePickerPage(TimePickerViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}
