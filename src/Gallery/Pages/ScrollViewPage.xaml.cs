namespace Gallery.Pages;

public partial class ScrollViewPage : ContentPage
{
    public ScrollViewPage()
        => InitializeComponent();

    private void OnScrolled(object sender, ScrolledEventArgs e)
        => Position.Text = $"Posição: {e.ScrollX} - {e.ScrollY}";
}
