namespace Gallery.Primitives;

public abstract class BasePage : ContentPage
{
    protected BasePage(object? viewModel = null)
    {
        BindingContext = viewModel;

        if (string.IsNullOrWhiteSpace(Title))
        {
            Title = GetType().Name;
        }
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        Debug.WriteLine($"OnAppearing: {Title}");
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        Debug.WriteLine($"OnDisappearing: {Title}");
    }
}

public abstract class BasePage<TViewModel>(TViewModel viewModel)
    : BasePage(viewModel) where TViewModel : BaseViewModel
{
    public new TViewModel BindingContext
        => (TViewModel)base.BindingContext;
}