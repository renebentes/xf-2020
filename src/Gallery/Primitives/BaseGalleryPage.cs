using CommunityToolkit.Maui.Markup;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace Gallery.Primitives;

public abstract partial class BaseGalleryPage<TViewModel>
    : BasePage<TViewModel> where TViewModel : BaseViewModel
{
    protected BaseGalleryPage(string title, TViewModel viewModel)
        : base(viewModel)
    {
        Title = title;

        Content = new CollectionView { SelectionMode = SelectionMode.Single };
    }

    sealed class Card : Border
    {
        enum CardRow
        {
            Title
        }

        public Card()
            => Content = new Grid
            {
                BackgroundColor = Colors.Transparent,
                RowSpacing = 4,

                RowDefinitions = Rows.Define( 24),

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
                }
            };
    }

}
