namespace Gallery.Controls;

public partial class EditorPage : BasePage<EditorViewModel>
{
    public EditorPage(EditorViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();
}