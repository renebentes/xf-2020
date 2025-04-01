using Gallery.Primitives;

namespace Gallery.Layouts;

public partial class AbsoluteLayoutPage : BasePage<AbsoluteLayoutViewModel>
{
    public AbsoluteLayoutPage(AbsoluteLayoutViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}
