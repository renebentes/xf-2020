namespace Gallery.Controls;

public sealed partial class ControlsGalleryViewModel()
    : BaseGalleryViewModel(
    [
        Section.Create<BorderViewModel>(nameof(Border), "Desenha uma borda, plano de fundo ou ambos."),
        Section.Create<BoxViewModel>(nameof(BoxView), "Desenha um retângulo ou quadrado."),
        Section.Create<ButtonViewModel>(nameof(Button), "Exibe um texto que responde a um comando."),
        Section.Create<ContentViewModel>(nameof(ContentView), "Permite criar controles personalizados."),
        Section.Create<EditorViewModel>(nameof(Editor), "Exibe um campo multilinha de texto editável."),
        Section.Create<EntryViewModel>(nameof(Entry), "Exibe um campo de texto editável."),
        #pragma warning disable CS0618 // Type or member is obsolete
        Section.Create<FrameViewModel>(nameof(Frame), "Desenha uma borda em torno de um controle."),
        #pragma warning restore CS0618 // Type or member is obsolete
        Section.Create<ImageButtonViewModel>(nameof(ImageButton), "Exibe uma imagem que responde a um comando."),
        Section.Create<ImageViewModel>(nameof(Image), "Exibe uma imagem."),
        Section.Create<LabelViewModel>(nameof(Label), "Exibe um texto."),
        Section.Create<ScrollViewViewModel>(nameof(ScrollView), "Permite rolar o conteúdo."),
        Section.Create<CheckBoxViewModel>(nameof(CheckBox), "Exibe uma caixa de seleção."),
        Section.Create<RadioButtonViewModel>(nameof(RadioButton), "Exibe um botão de opção."),
        Section.Create<SwitchViewModel>(nameof(Microsoft.Maui.Controls.Switch), "Permite alternar entre dois estados, como ligado/desligado."),
    ]);