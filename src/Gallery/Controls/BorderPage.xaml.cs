using Gallery.Primitives;

namespace Gallery.Controls;

public partial class BorderPage : BasePage<BorderViewModel>
{
    public BorderPage(BorderViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}
