namespace Gallery.Controls;

public partial class ActivityIndicatorPage
    : BasePage<ActivityIndicatorViewModel>
{
    public ActivityIndicatorPage(ActivityIndicatorViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}
