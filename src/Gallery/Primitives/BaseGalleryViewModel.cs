namespace Gallery.Primitives;

public abstract class BaseGalleryViewModel : BaseViewModel
{
    protected BaseGalleryViewModel(Section[] sections)
        => Sections = sections.OrderBy(s => s.Title).ToList();

    public IReadOnlyList<Section> Sections { get; }
}