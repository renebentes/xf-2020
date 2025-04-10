namespace Gallery.Controls;

public sealed partial class ControlsGalleryViewModel : BaseGalleryViewModel
{
    public ControlsGalleryViewModel()
        : base([
            Section.Create<BorderViewModel>("Border", "Desenha uma borda, plano de fundo ou ambos."),
            Section.Create<BoxViewModel>("BoxView", "Desenha um retângulo ou quadrado."),
            Section.Create<ButtonViewModel>("Button", "Exibe um texto que responde a um comando."),
            Section.Create<ContentViewModel>("ContentView","Permite criar controles personalizados."),
            Section.Create<EditorViewModel>("Editor", "Exibe um campo multilinha de texto editável."),
            Section.Create<EntryViewModel>("Entry", "Exibe um campo de texto editável."),
            Section.Create<FrameViewModel>("Frame", "Desenha uma borda em torno de um controle."),
            Section.Create<ImageButtonViewModel>("ImageButton", "Exibe uma imagem que responde a um comando."),
            Section.Create<ImageViewModel>("Image", "Exibe uma imagem."),
            Section.Create<LabelViewModel>("Label", "Exibe um texto."),
            Section.Create<ScrollViewViewModel>("ScrollView", "Permite rolar o conteúdo."),])
    {
    }
}