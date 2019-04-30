using Microsoft.AspNetCore.Components;

namespace BuildRenderTree.Shared
{
    public class TestComponentExample2Base : ComponentBase
    {
        [Parameter] protected RenderFragment ChildContent { get; set; }
    }
}
