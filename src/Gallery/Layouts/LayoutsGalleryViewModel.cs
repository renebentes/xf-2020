using Gallery.Primitives;

namespace Gallery.Layouts;

public sealed partial class LayoutsGalleryViewModel() : BaseGalleryViewModel(
[
    Section.Create<AbsoluteLayoutViewModel>(nameof(AbsoluteLayoutPage), string.Empty),
    Section.Create<FlexLayoutViewModel>(nameof(FlexLayoutPage), string.Empty),
    Section.Create<GridViewModel>(nameof(GridPage), string.Empty),
    Section.Create<HorizontalStackLayoutViewModel>(nameof(HorizontalStackLayoutPage), string.Empty),
    Section.Create<StackLayoutViewModel>(nameof(StackLayoutPage), string.Empty),
    Section.Create<VerticalStackLayoutViewModel>(nameof(VerticalStackLayoutPage), string.Empty)
]);
