
namespace Gallery.Controls;

public class FurtherDetailsLabel : Label
{
    public static readonly BindableProperty UrlProperty
        = BindableProperty.Create(
            nameof(Url),
            typeof(string),
            typeof(FurtherDetailsLabel),
            string.Empty,
            propertyChanged: OnUrlPropertyChanged);

    public FurtherDetailsLabel()
    {
        FontSize = 18;
        FormattedText = new FormattedString
        {
            Spans = {
                new Span {
                    Text="Para saber mais, consulte a "
                },
                new HyperlinkSpan {
                    Text = "documentação completa",
                    Url = Url
                },
                new Span {
                    Text="."
                }
            }
        };
        HorizontalOptions = LayoutOptions.Center;
        SetValue(SemanticProperties.HeadingLevelProperty, SemanticHeadingLevel.Level3);
    }

    public string Url
    {
        get => (string)GetValue(UrlProperty);
        set => SetValue(UrlProperty, value);
    }

    private static void OnUrlPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (newValue is null)
        {
            return;
        }

        if (bindable is FurtherDetailsLabel furtherDetailsLabel)
        {
            ((HyperlinkSpan)furtherDetailsLabel.FormattedText.Spans[1]).Url = newValue.ToString();
        }
    }
}
