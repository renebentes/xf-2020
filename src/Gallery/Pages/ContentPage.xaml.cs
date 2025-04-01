using Gallery.Primitives;

namespace Gallery.Pages;

public partial class ContentPage : BasePage<ContentViewModel>
{
    public ContentPage(ContentViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}
