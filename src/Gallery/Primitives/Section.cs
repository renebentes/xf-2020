namespace Gallery.Primitives;

public sealed class Section
{
    private Section(in string title, in string description, in Type viewModelType)
    {
        Title = title;
        Description = description;
        ViewModelType = viewModelType;
    }

    public string Description { get; }

    public string Title { get; }

    public Type ViewModelType { get; }

    public static Section Create<TViewModel>(in string title, in string description)
        where TViewModel : BaseViewModel
        => new(title, description, typeof(TViewModel));
}
