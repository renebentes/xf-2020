using MauiControls = Microsoft.Maui.Controls;

namespace Gallery.Pages;

public sealed partial class WelcomePage : MauiControls.ContentPage
{
    public WelcomePage()
    {
        Title = "Bem-vindo";
        Content = new VerticalStackLayout
        {
            Padding = new Thickness(30, 0),
            Spacing = 25,
            Children =
            {
                new Label { Text = "Bem-vindo ao Gallery!" }
                    .Font(size: 32)
                    .TextCenter()
                    .SemanticHeadingLevel(SemanticHeadingLevel.Level1),
                new Label
                {
                    Text = """
                        Esta é uma aplicação de exemplo para o .NET MAUI, que visa demonstrar
                        o uso de diversos layouts, tipos de páginas e controles disponíveis
                        na plataforma.
                        """,
                }
                    .Font(size: 18)
                    .TextCenter()
                    .SemanticHeadingLevel(SemanticHeadingLevel.Level2),
            },
        }.CenterVertical();
    }
}