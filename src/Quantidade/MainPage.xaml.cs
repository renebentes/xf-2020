namespace Quantidade;

public partial class MainPage : ContentPage
{
    private int _count = 1;

    public MainPage()
        => InitializeComponent();

    private void OnIncrement(object sender, EventArgs e)
    {
        _count++;
        Quantidade.Text = _count.ToString();
        SemanticScreenReader.Announce(Quantidade.Text);
    }

    private void OnDecrement(object sender, EventArgs e)
    {
        if (_count > 0)
        {
            _count--;
            Quantidade.Text = _count.ToString();
            SemanticScreenReader.Announce(Quantidade.Text);
        }
    }
}