using Gallery.Primitives;

namespace Gallery.Layouts;

public partial class StackLayoutPage : BasePage<StackLayoutViewModel>
{
    public StackLayoutPage(StackLayoutViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}
