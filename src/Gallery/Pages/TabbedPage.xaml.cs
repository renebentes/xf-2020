namespace Gallery.Pages;

public sealed partial class TabbedPage : BasePage<TabbedViewModel>
{
    public TabbedPage(TabbedViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}