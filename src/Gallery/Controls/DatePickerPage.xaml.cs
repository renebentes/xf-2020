namespace Gallery.Controls;

public partial class DatePickerPage
    : BasePage<DatePickerViewModel>
{
    public DatePickerPage(DatePickerViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}
