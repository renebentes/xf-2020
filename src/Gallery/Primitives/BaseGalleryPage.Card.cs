using CommunityToolkit.Maui.Markup;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace Gallery.Primitives;

public abstract partial class BaseGalleryPage<TViewModel>
    where TViewModel : BaseViewModel
{
    private sealed partial class Card : Border
    {
        public Card()
            => Content = new Grid
            {
                BackgroundColor = Colors.Transparent,
                RowSpacing = 4,

                RowDefinitions = Rows.Define(
                    (CardRow.Title, 24),
                    (CardRow.Description, Auto)
                ),

                ColumnDefinitions = Columns.Define(Star),

                Children =
                {
                    new Label()
                        .Row(CardRow.Title)
                        .Bind(
                            Label.TextProperty,
                            static(Section section) => section.Title,
                            mode:BindingMode.OneTime
                        )
                        .DynamicResource(
                            Label.StyleProperty,
                            "LabelGalleryCardTitle"
                        ),

                    new Label
                    {
                        MaxLines = 4,
                        LineBreakMode = LineBreakMode.WordWrap
                    }
                        .Row(CardRow.Description)
                        .Bind(
                            Label.TextProperty,
                            static(Section section) => section.Description,
                            mode:BindingMode.OneTime
                        )
                        .DynamicResource(
                            StyleProperty,
                            "LabelGalleryCardDescription"
                        )
                }
            };

        private enum CardRow
        {
            Title,
            Description
        }
    }
}
