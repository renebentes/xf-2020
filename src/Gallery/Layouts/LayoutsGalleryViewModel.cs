using Gallery.Pages;
using Gallery.Primitives;

namespace Gallery.Layouts;

public sealed partial class LayoutsGalleryViewModel() : BaseGalleryViewModel(
[
    Section.Create(nameof(AbsoluteLayoutPage))
]);