using Gallery.Layouts;
using Gallery.Pages;
using Gallery.Primitives;
using System.Collections.ObjectModel;

namespace Gallery;

/// <summary>
/// from https://github.com/CommunityToolkit/Maui/blob/main/samples/CommunityToolkit.Maui.Sample/AppShell.xaml.cs
/// </summary>
public partial class AppShell : Shell
{
    private static readonly ReadOnlyDictionary<Type, (Type GalleryPageType, Type ContentPageType)> _viewModelMappings =
        new Dictionary<Type, (Type GalleryPageType, Type ContentPageType)>([
            CreateViewModelMapping<AbsoluteLayoutPage, AbsoluteLayoutViewModel, LayoutsGalleryPage, LayoutsGalleryViewModel>(),
            CreateViewModelMapping<FlexLayoutPage, FlexLayoutViewModel, LayoutsGalleryPage, LayoutsGalleryViewModel>(),
            CreateViewModelMapping<GridPage, GridViewModel, LayoutsGalleryPage, LayoutsGalleryViewModel>(),
            CreateViewModelMapping<HorizontalStackLayoutPage, HorizontalStackLayoutViewModel, LayoutsGalleryPage, LayoutsGalleryViewModel>(),
            CreateViewModelMapping<StackLayoutPage, StackLayoutViewModel, LayoutsGalleryPage, LayoutsGalleryViewModel>(),
            CreateViewModelMapping<VerticalStackLayoutPage, VerticalStackLayoutViewModel, LayoutsGalleryPage, LayoutsGalleryViewModel>(),
            CreateViewModelMapping<Pages.ContentPage, ContentViewModel, PagesGalleryPage, PagesGalleryViewModel>(),
            CreateViewModelMapping<Pages.FlyoutPage, FlyoutViewModel, PagesGalleryPage, PagesGalleryViewModel>(),
            CreateViewModelMapping<Pages.NavigationPage, NavigationViewModel, PagesGalleryPage, PagesGalleryViewModel>(),
            CreateViewModelMapping<Pages.TabbedPage, TabbedViewModel, PagesGalleryPage, PagesGalleryViewModel>()

        ]).AsReadOnly();

    public AppShell()
        => InitializeComponent();

    public static string GetPageRoute<TViewModel>()
        where TViewModel : BaseViewModel
        => GetPageRoute(typeof(TViewModel));

    public static string GetPageRoute(Type viewModelType)
    {
        if (!viewModelType.IsAssignableTo(typeof(BaseViewModel)))
        {
            throw new ArgumentException($@"{nameof(viewModelType)} must implement {nameof(BaseViewModel)}", nameof(viewModelType));
        }

        if (!_viewModelMappings.TryGetValue(viewModelType, out var mapping))
        {
            throw new KeyNotFoundException($"No map for ${viewModelType} was found on navigation mappings. Please register your ViewModel in {nameof(AppShell)}.{nameof(_viewModelMappings)}");
        }

        var uri = new UriBuilder("", GetPageRoute(mapping.GalleryPageType, mapping.ContentPageType));
        return uri.Uri.OriginalString[..^1];
    }

    private static KeyValuePair<Type, (Type GalleryPageType, Type ContentPageType)> CreateViewModelMapping<TPage, TViewModel, TGalleryPage, TGalleryViewModel>()
        where TPage : BasePage<TViewModel>
        where TViewModel : BaseViewModel
        where TGalleryPage : BaseGalleryPage<TGalleryViewModel>
        where TGalleryViewModel : BaseGalleryViewModel
        => new(typeof(TViewModel), (typeof(TGalleryPage), typeof(TPage)));

    private static string GetPageRoute(Type galleryPageType, Type contentPageType)
        => $"//{galleryPageType.Name}/{contentPageType.Name}";
}
