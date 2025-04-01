using Gallery.Primitives;

namespace Gallery.Controls;

public sealed partial class ControlsGalleryViewModel : BaseGalleryViewModel
{
    public ControlsGalleryViewModel()
        : base([
            Section.Create<BorderViewModel>(nameof(BorderPage), string.Empty),
            Section.Create<BoxViewModel>(nameof(BoxViewPage), string.Empty),
            Section.Create<ButtonViewModel>(nameof(ButtonPage), string.Empty),
            Section.Create<ContentViewModel>(nameof(ContentViewPage),string.Empty),
            Section.Create<EditorViewModel>(nameof(EditorPage), string.Empty),
            Section.Create<EntryViewModel>(nameof(EntryPage), string.Empty),
            Section.Create<FrameViewModel>(nameof(FramePage), string.Empty),
            Section.Create<ImageButtonViewModel>(nameof(ImageButtonPage), string.Empty),
            Section.Create<ImageViewModel>(nameof(ImagePage), string.Empty),
            Section.Create<LabelViewModel>(nameof(LabelPage), string.Empty),
            Section.Create<ScrollViewViewModel>(nameof(ScrollViewPage), string.Empty)])
    {
    }
}