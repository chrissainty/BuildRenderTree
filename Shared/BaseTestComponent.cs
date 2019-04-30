using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.RenderTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildRenderTree.Shared
{
    public class BaseTestComponent : ComponentBase
    {
        [Parameter]
        protected RenderFragment ChildContent
        {
            get;
            set;
        }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "id", Guid.NewGuid().ToString());

            builder.AddContent(2, ChildContent);

            builder.CloseElement();
        }
    }
}
