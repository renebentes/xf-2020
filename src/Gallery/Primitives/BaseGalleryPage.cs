namespace Gallery.Primitives;

public abstract partial class BaseGalleryPage<TViewModel>
    : BasePage<TViewModel> where TViewModel : BaseViewModel
{
    protected BaseGalleryPage(string title, TViewModel viewModel)
        : base(viewModel)
    {
        Title = title;

        Content = new CollectionView { SelectionMode = SelectionMode.Single }
            .ItemTemplate(new GalleryDataTemplate())
            .Bind(
                ItemsView.ItemsSourceProperty,
                static (BaseGalleryViewModel vm) => vm.Sections,
                mode: BindingMode.OneTime
            )
            .Invoke(
                static collectionView => collectionView.SelectionChanged += HandleSelectionChanged
            );
    }

    private static async void HandleSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        ArgumentNullException.ThrowIfNull(sender);

        if (sender is CollectionView collectionView)
        {
            collectionView.SelectedItem = null;

            if (e.CurrentSelection.Count > 0 && e.CurrentSelection[0] is Section section)
            {
                await Shell.Current.GoToAsync(AppShell.GetPageRoute(section.ViewModelType));
            }
        }
    }
}