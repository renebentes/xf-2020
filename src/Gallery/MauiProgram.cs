global using CommunityToolkit.Maui;
global using CommunityToolkit.Maui.Markup;
global using Gallery.Primitives;
global using System.Diagnostics;
using Gallery.Controls;
using Gallery.Layouts;
using Gallery.Pages;
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

        AddDebugLogging(builder);

        builder.Services.AddPagesAndViewModels();

        return builder.Build();
    }

    private static IServiceCollection AddControlsGallery(this IServiceCollection services)
    {
        services.AddTransient<ControlsGalleryPage, ControlsGalleryViewModel>();

        services.AddTransientWithShellRoute<BorderPage, BorderViewModel>();
        services.AddTransientWithShellRoute<BoxViewPage, BoxViewModel>();
        services.AddTransientWithShellRoute<ButtonPage, ButtonViewModel>();
        services.AddTransientWithShellRoute<ContentViewPage, Controls.ContentViewModel>();
        services.AddTransientWithShellRoute<EditorPage, EditorViewModel>();
        services.AddTransientWithShellRoute<EntryPage, EntryViewModel>();
        services.AddTransientWithShellRoute<FramePage, FrameViewModel>();
        services.AddTransientWithShellRoute<ImageButtonPage, ImageButtonViewModel>();
        services.AddTransientWithShellRoute<ImagePage, ImageViewModel>();
        services.AddTransientWithShellRoute<LabelPage, LabelViewModel>();
        services.AddTransientWithShellRoute<ScrollViewPage, ScrollViewViewModel>();

        return services;
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

        services.AddPagesGallery();

        services.AddLayoutsGallery();

        services.AddControlsGallery();

        return services;
    }

    private static IServiceCollection AddPagesGallery(this IServiceCollection services)
    {
        services.AddTransient<PagesGalleryPage, PagesGalleryViewModel>();

        services.AddTransientWithShellRoute<Pages.NavigationPage, NavigationViewModel>();
        services.AddTransientWithShellRoute<Pages.TabbedPage, TabbedViewModel>();
        services.AddTransientWithShellRoute<Pages.ContentPage, Pages.ContentViewModel>();
        services.AddTransientWithShellRoute<Pages.FlyoutPage, FlyoutViewModel>();

        return services;
    }

    private static IServiceCollection AddTransientWithShellRoute<TPage, TViewModel>(this IServiceCollection services)
        where TPage : BasePage<TViewModel>
        where TViewModel : BaseViewModel
        => services.AddTransientWithShellRoute<TPage, TViewModel>(AppShell.GetPageRoute<TViewModel>());
}