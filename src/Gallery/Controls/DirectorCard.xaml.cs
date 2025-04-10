namespace Gallery.Controls;

public partial class DirectorCard : ContentView
{
    public static readonly BindableProperty BoxViewBackgroundColorProperty = BindableProperty.Create(nameof(BoxViewBackgroundColor),
                                                                                                     typeof(Color),
                                                                                                     typeof(DirectorCard),
                                                                                                     Colors.Gray);

    public static readonly BindableProperty DescriptionProperty = BindableProperty.Create(nameof(Description),
                                                                                          typeof(string),
                                                                                          typeof(DirectorCard),
                                                                                          string.Empty);

    public static readonly BindableProperty NameProperty = BindableProperty.Create(nameof(Name),
                                                                                   typeof(string),
                                                                                   typeof(DirectorCard),
                                                                                   string.Empty);

    public DirectorCard()
        => InitializeComponent();

    public Color BoxViewBackgroundColor
    {
        get => (Color)GetValue(BoxViewBackgroundColorProperty);
        set => SetValue(BoxViewBackgroundColorProperty, value);
    }

    public string Description
    {
        get => (string)GetValue(DescriptionProperty);
        set => SetValue(DescriptionProperty, value);
    }

    public string Name
    {
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }
}