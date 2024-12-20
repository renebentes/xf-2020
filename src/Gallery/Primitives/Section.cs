namespace Gallery.Primitives;

public sealed class Section
{
    private  Section( in string title)
    {
        Title = title;
    }
    // private Section(in string title, in string description, in Type viewModelType)
    // {
    //     Title = title;
    //     Description = description;
    //     ViewModelType = viewModelType;
    // }

    public string Title { get; }

    // public string Description { get; }

    // public Type ViewModelType { get; }

//     public static Section Create<TViewModel>(in string title, in string description)
//         where TViewModel : BaseViewModel
//         => new (title, description, typeof(TViewModel));

    public static Section Create(in string title)
        => new(title);
}
