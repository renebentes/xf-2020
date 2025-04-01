using Gallery.Primitives;

namespace Gallery.Controls;

public partial class BoxViewPage : BasePage<BoxViewModel>
{
    public BoxViewPage(BoxViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}