using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace Inventory.API.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public int Stock { get; set; }
    }
}
