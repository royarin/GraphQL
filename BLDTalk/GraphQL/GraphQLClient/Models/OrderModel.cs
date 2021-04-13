using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorGQL.Model
{
    /// <summary>
    /// Viewmodel representing an order
    /// </summary>
    public class OrderModel
    {
        public string OrderNumber { get; set; }
        [Required]
        public string DeliveryName { get; set; }
        [Required]
        public string DeliveryAddress1 { get; set; }
        public string DeliveryAddress2 { get; set; }
        [Required]
        public string DeliveryCity { get; set; }
        [Required]
        public string DeliveryPostCode { get; set; }
        [Required]
        public string DeliveryCountry { get; set; }
        public IList<OrderLineItemModel> LineItems { get; set; }
    }

    public class OrderLineItemModel
    {
        public string Sku { get; set; }
        public int Quantity { get; set; }
    }
}
