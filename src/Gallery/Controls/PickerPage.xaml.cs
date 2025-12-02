namespace Gallery.Controls;

public partial class PickerPage
    : BasePage<PickerViewModel>
{
    public PickerPage(PickerViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}
