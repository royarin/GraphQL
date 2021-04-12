using BlazorGQL.Model;
using Microsoft.AspNetCore.Components;

namespace BlazorGQL.Pages.Order
{
    public partial class OrderDetail
    {
        [Parameter]
        public OrderModel Instance { get; set; }

    }
}
