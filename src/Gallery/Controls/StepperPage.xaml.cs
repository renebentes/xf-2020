namespace Gallery.Controls;

public partial class StepperPage
    : BasePage<StepperViewModel>
{
    public StepperPage(StepperViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}