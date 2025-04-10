namespace Gallery.Layouts;

public partial class VerticalStackLayoutPage : BasePage<VerticalStackLayoutViewModel>
{
    public VerticalStackLayoutPage(VerticalStackLayoutViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}