namespace Gallery.Controls;

public partial class HorizontalCard : ContentView
{
    private Color _backgroundColor;
    private string _description;
    private string _title;

    public HorizontalCard()
        => InitializeComponent();

    public new Color BackgroundColor
    {
        get => _backgroundColor;
        set
        {
            _backgroundColor = value;
            Card.BackgroundColor = BackgroundColor;
        }
    }

    public string Description
    {
        get => _description;
        set
        {
            _description = value;
            CardDescription.Text = Description;
        }
    }

    public string Title
    {
        get => _title;
        set
        {
            _title = value;
            CardTitle.Text = Title;
        }
    }
}