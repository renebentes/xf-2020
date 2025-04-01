using Gallery.Primitives;

namespace Gallery.Controls;

public partial class FramePage : BasePage<FrameViewModel>
{
    public FramePage(FrameViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}
