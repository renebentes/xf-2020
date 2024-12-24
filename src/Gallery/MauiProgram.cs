using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using Gallery.Layouts;
using Gallery.Primitives;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

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

        AddDebugLogging(builder);

        builder.Services.AddPagesAndViewModels();

        return builder.Build();
    }

    [Conditional("DEBUG")]
    private static void AddDebugLogging(in MauiAppBuilder builder)
        => builder.Logging.AddDebug();

    private static IServiceCollection AddLayoutsGallery(this IServiceCollection services)
    {
        services.AddTransient<LayoutsGalleryPage, LayoutsGalleryViewModel>();

        services.AddTransientWithShellRoute<AbsoluteLayoutPage, AbsoluteLayoutViewModel>();
        services.AddTransientWithShellRoute<FlexLayoutPage, FlexLayoutViewModel>();
        services.AddTransientWithShellRoute<GridPage, GridViewModel>();
        services.AddTransientWithShellRoute<HorizontalStackLayoutPage, HorizontalStackLayoutViewModel>();
        services.AddTransientWithShellRoute<StackLayoutPage, StackLayoutViewModel>();
        services.AddTransientWithShellRoute<VerticalStackLayoutPage, VerticalStackLayoutViewModel>();

        return services;
    }

    private static IServiceCollection AddPagesAndViewModels(this IServiceCollection services)
    {
        services.AddSingleton<AppShell>();

        services.AddLayoutsGallery();

        return services;
    }

    private static IServiceCollection AddTransientWithShellRoute<TPage, TViewModel>(this IServiceCollection services)
        where TPage : BasePage<TViewModel>
        where TViewModel : BaseViewModel
        => services.AddTransientWithShellRoute<TPage, TViewModel>(AppShell.GetPageRoute<TViewModel>());
}
