namespace Gallery.Controls;

public class HyperlinkSpan : Span
{
    public static readonly BindableProperty UrlProperty =
       BindableProperty.Create(nameof(Url), typeof(string), typeof(HyperlinkSpan), string.Empty);

    public string Url
    {
        get => (string)GetValue(UrlProperty);
        set => SetValue(UrlProperty, value);
    }

    public HyperlinkSpan()
    {
        TextDecorations = TextDecorations.Underline;
        GestureRecognizers.Add(new TapGestureRecognizer
        {
            Command = new Command(async () => await Launcher.OpenAsync(Url))
        });
    }
}