namespace Gallery.Pages;

public sealed partial class PagesGalleryViewModel()
    : BaseGalleryViewModel([
            Section.Create<ContentViewModel>(nameof(ContentPage), "Página simples com conteúdo."),
            Section.Create<NavigationViewModel>(nameof(NavigationPage), "Permite uma navegação hierárquica."),
            Section.Create<FlyoutViewModel>(nameof(FlyoutPage), "Permite uma navegação mestre-detalhe."),
            Section.Create<TabbedViewModel>(nameof(TabbedPage), "Permite uma navegação entre abas.")]);