namespace Gallery.Pages;

public sealed partial class PagesGalleryViewModel : BaseGalleryViewModel
{
    public PagesGalleryViewModel()
        : base([
            Section.Create<NavigationViewModel>(nameof(NavigationPage), string.Empty),
            Section.Create<FlyoutViewModel>(nameof(FlyoutPage), string.Empty),
            Section.Create<TabbedViewModel>(nameof(TabbedPage), string.Empty)]
        )
    {
    }
}