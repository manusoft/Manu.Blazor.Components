using global::Microsoft.AspNetCore.Components;

namespace Manu.Blazor.Components;

public partial class DataGrid<Model> : ManuComponentBase
{
    [Parameter]
    public IList<Model>? Items { get; set; }

    [Parameter]
    public RenderFragment<Model>? Columns { get; set; }

    [Parameter]
    public Theme HeaderStyle { get; set; } = Theme.None;

    [Parameter]
    public bool Border { get; set; } = false;

    [Parameter]
    public bool Hover { get; set; } = false;

    [Parameter]
    public bool Striped { get; set; } = false;

    [Parameter]
    public bool IsSmall { get; set; } = false;    

    private string classBorder = "table-bordered";
    private string classHover = "table-hover";
    private string classStriped = "table-striped";
    private string classSmall = "table-sm";
    private string classHeader = string.Empty;
    protected override void OnInitialized()
    {
        if (Border)
            classBorder = "table-bordered";
        else
            classBorder = string.Empty;
        if (Hover)
            classHover = "table-hover";
        else
            classHover = string.Empty;
        if (Striped)
            classStriped = "table-striped";
        else
            classStriped = string.Empty;
        if (IsSmall)
            classSmall = "table-sm";
        else
            classSmall = string.Empty;

        switch (HeaderStyle)
        {
            case Theme.Primary:
                classHeader = "table-primary";
                break;
            case Theme.Secondary:
                classHeader = "table-secondary";
                break;
            case Theme.Success:
                classHeader = "table-success";
                break;
            case Theme.Danger:
                classHeader = "table-danger";
                break;
            case Theme.Warning:
                classHeader = "table-warning";
                break;
            case Theme.Info:
                classHeader = "table-info";
                break;
            case Theme.Light:
                classHeader = "table-light";
                break;
            case Theme.Dark:
                classHeader = "table-dark";
                break;
            default:
                classHeader = string.Empty;
                break;
        }

        base.OnInitialized();
    }
}