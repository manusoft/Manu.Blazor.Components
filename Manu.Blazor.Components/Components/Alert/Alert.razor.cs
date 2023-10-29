using global::Microsoft.AspNetCore.Components;

namespace Manu.Blazor.Components;

public partial class Alert
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    [Parameter]
    public RenderFragment? AlertTitle { get; set; }

    [Parameter]
    public RenderFragment? AlertMessage { get; set; }

    [Parameter]
    public Theme AlertStyle { get; set; } = Theme.None;

    [Parameter]
    public bool CloseButton { get; set; } = false;

    private bool isVisible = true;
    private string classAlertStyle = string.Empty;

    protected override void OnInitialized()
    {
        switch (AlertStyle)
        {
            case Theme.Primary:
                classAlertStyle = "alert-primary";
                break;
            case Theme.Secondary:
                classAlertStyle = "alert-secondary";
                break;
            case Theme.Success:
                classAlertStyle = "alert-success";
                break;
            case Theme.Danger:
                classAlertStyle = "alert-danger";
                break;
            case Theme.Warning:
                classAlertStyle = "alert-warning";
                break;
            case Theme.Info:
                classAlertStyle = "alert-info";
                break;
            case Theme.Light:
                classAlertStyle = "alert-light";
                break;
            case Theme.Dark:
                classAlertStyle = "alert-dark";
                break;
            default:
                classAlertStyle = string.Empty;
                break;
        }

        base.OnInitialized();
    }

    private void OnClose()
    {
        isVisible = false;
        StateHasChanged();
    }
}