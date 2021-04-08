using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.API.Models
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public Address Address { get; set; }
        public List<LineItem> LineItems { get; set; }
    }
}
