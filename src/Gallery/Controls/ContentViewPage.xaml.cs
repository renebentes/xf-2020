namespace Gallery.Controls;

public partial class ContentViewPage : BasePage<ContentViewModel>
{
    public ContentViewPage(ContentViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}