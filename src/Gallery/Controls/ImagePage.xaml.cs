namespace Gallery.Controls;

public partial class ImagePage : BasePage<ImageViewModel>
{
    public ImagePage(ImageViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}