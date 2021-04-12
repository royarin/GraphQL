using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace BlazorGQL.Shared
{
    public partial class TableComponent<TItem>
    {
        [Parameter]
        public RenderFragment TableHeader { get; set; }

        [Parameter]
        public RenderFragment<TItem> RowTemplate { get; set; }

        [Parameter]
        public IEnumerable<TItem> Items { get; set; }
    }
}
