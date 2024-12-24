using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using Gallery.Primitives;
using Microsoft.Extensions.Logging;

namespace Gallery;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        MauiAppBuilder builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitMarkup()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }

    private static IServiceCollection AddTransientWithShellRoute<TPage, TViewModel>(this IServiceCollection services)
        where TPage : BasePage<TViewModel>
        where TViewModel : BaseViewModel
        => services.AddTransientWithShellRoute<TPage, TViewModel>(AppShell.GetPageRoute<TViewModel>());
}
