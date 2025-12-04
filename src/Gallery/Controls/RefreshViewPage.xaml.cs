namespace Gallery.Controls;

public partial class RefreshViewPage
    : BasePage<RefreshViewViewModel>
{
    public RefreshViewPage(RefreshViewViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}
