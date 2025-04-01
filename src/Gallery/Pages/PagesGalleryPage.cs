using Gallery.Primitives;

namespace Gallery.Pages;

public sealed partial class PagesGalleryPage(PagesGalleryViewModel viewModel)
    : BaseGalleryPage<PagesGalleryViewModel>("Páginas", viewModel)
{
}
