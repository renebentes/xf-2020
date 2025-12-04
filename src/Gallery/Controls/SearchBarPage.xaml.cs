
namespace Gallery.Controls;

public partial class SearchBarPage
    : BasePage<SearchBarViewModel>
{
    public SearchBarPage(SearchBarViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
        => BindingContext.Load();
}
