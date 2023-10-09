using Microsoft.AspNetCore.Components;

namespace Manu.Blazor.Components;

public partial class SpinnerCircle : ManuComponentBase
{
    [Parameter]
    public string LoadingText { get; set; } = string.Empty;

    [Parameter]
    public Theme SpinnerStyle { get; set; } = Theme.None;

    private string classSpinnerStyle = string.Empty;

    protected override void OnInitialized()
    {
        switch (SpinnerStyle)
        {
            case Theme.Primary:
                classSpinnerStyle = "text-primary";
                break;
            case Theme.Secondary:
                classSpinnerStyle = "text-secondary";
                break;
            case Theme.Success:
                classSpinnerStyle = "text-success";
                break;
            case Theme.Danger:
                classSpinnerStyle = "text-danger";
                break;
            case Theme.Warning:
                classSpinnerStyle = "text-warning";
                break;
            case Theme.Info:
                classSpinnerStyle = "text-info";
                break;
            case Theme.Light:
                classSpinnerStyle = "text-light";
                break;
            case Theme.Dark:
                classSpinnerStyle = "text-dark";
                break;
            default:
                classSpinnerStyle = string.Empty;
                break;
        }

        base.OnInitialized();
    }
}