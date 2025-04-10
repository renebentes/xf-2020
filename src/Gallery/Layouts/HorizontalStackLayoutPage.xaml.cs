namespace Gallery.Layouts;

public partial class HorizontalStackLayoutPage : BasePage<HorizontalStackLayoutViewModel>
{
    public HorizontalStackLayoutPage(HorizontalStackLayoutViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}