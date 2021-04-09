using System.Collections.Generic;
using Order.API.Models;

namespace Order.API.GraphQL
{
    public class CreateOrderInput
    {
        public string DeliveryName { get; set; }
        public string DeliveryAddress1 { get; set; }
        public string DeliveryAddress2 { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryPostCode { get; set; }
        public string DeliveryCountry { get; set; }
        public List<LineItemInput> LineItems { get; set; }

    }
}