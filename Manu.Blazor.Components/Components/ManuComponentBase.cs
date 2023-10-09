﻿using Microsoft.AspNetCore.Components;

namespace Manu.Blazor.Components;

public class ManuComponentBase : ComponentBase
{
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string,object> UserAttributes { get;set; } = new Dictionary<string,object>();

    [Parameter]
    public string Class { get; set; } = "";

    [Parameter]
    public string Style { get; set; } = "";
}
