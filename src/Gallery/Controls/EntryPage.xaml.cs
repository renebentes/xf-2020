namespace Gallery.Controls;

public partial class EntryPage : BasePage<EntryViewModel>
{
    public EntryPage(EntryViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}