namespace Gallery.Layouts;

public sealed partial class LayoutsGalleryViewModel()
    : BaseGalleryViewModel(
    [
        Section.Create<AbsoluteLayoutViewModel>("AbsoluteLayout", "Posiciona e dimensiona elementos com valores explícitos."),
        Section.Create<FlexLayoutViewModel>("FlexLayout", "Organiza elementos em uma pilha adaptável ao tamanho de tela."),
        Section.Create<GridViewModel>("Grid", "Organiza elementos em linhas e colunas."),
        Section.Create<HorizontalStackLayoutViewModel>("HorizontalStackLayout", "Organiza elementos em uma pilha horizontal."),
        Section.Create<StackLayoutViewModel>("StackLayout", "Organiza elementos em uma pilha unidimensional."),
        Section.Create<VerticalStackLayoutViewModel>("VerticalStackLayout", "Organiza elementos em uma pilha vertical.")
    ]);