using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.RenderTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildRenderTree.Pages
{
    public class BaseIndex : ComponentBase
    {
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            Console.WriteLine($"Before BuildRenderTree");

            base.BuildRenderTree(builder);
            Console.WriteLine($"After BuildRenderTree");
        }

    }
}
