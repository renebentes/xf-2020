using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace Gallery.Primitives;

public abstract partial class BaseGalleryPage<TViewModel>
    where TViewModel : BaseViewModel
{
    private sealed class GalleryDataTemplate : DataTemplate
    {
        public GalleryDataTemplate()
            : base(CreateDataTemplate)
        {
        }

        private enum Column
        {
            LeftPadding,
            Content,
            RightPadding
        }

        private enum Row
        {
            TopPadding,
            Content,
            BottomPadding
        }

        private static Grid CreateDataTemplate()
            => new()
            {
                RowDefinitions = Rows.Define(
                    (Row.TopPadding, 8),
                    (Row.Content, Star),
                    (Row.BottomPadding, 8)
                ),

                ColumnDefinitions = Columns.Define(
                    (Column.LeftPadding, 24),
                    (Column.Content, Star),
                    (Column.RightPadding, 24)
                ),

                Children =
                {
                    new Card()
                        .Row(Row.Content)
                        .Column(Column.Content)
                        .DynamicResource(
                            StyleProperty,
                            "BorderGalleryCard"
                        )
                }
            };
    }
}