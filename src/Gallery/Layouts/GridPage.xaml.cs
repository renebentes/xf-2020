namespace Gallery.Layouts;

public partial class GridPage : BasePage<GridViewModel>
{
    public GridPage(GridViewModel gridViewModel)
        : base(gridViewModel)
        => InitializeComponent();
}