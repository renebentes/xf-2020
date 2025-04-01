using Gallery.Primitives;

namespace Gallery.Controls;

public partial class ScrollViewPage : BasePage<ScrollViewViewModel>
{
    public ScrollViewPage(ScrollViewViewModel viewModel)
        : base(viewModel)
        => InitializeComponent();

    private void OnScrolled(object sender, ScrolledEventArgs e)
        => Position.Text = $"Posição: {e.ScrollX} - {e.ScrollY}";
}
