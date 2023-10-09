using global::Microsoft.AspNetCore.Components;

namespace Manu.Blazor.Components
{
    public partial class Column<Model>
    {
        [Parameter]
        public string Name { get; set; } = string.Empty;// Property name

        [Parameter]
        public string Label { get; set; } = string.Empty;// Property label

        [CascadingParameter]
        public Model Item { get; set; }

        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}