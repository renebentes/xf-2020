using Gallery.Primitives;

namespace Gallery.Pages;

public partial class FlyoutPage : BasePage<FlyoutViewModel>
{
    public FlyoutPage(FlyoutViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}