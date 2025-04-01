using Gallery.Primitives;

namespace Gallery.Pages;

public partial class NavigationPage : BasePage<NavigationViewModel>
{
    public NavigationPage(NavigationViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}
