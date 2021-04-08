using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace Order.API.Models
{
    public class LineItem
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public int Quantity { get; set; }
    }
}
