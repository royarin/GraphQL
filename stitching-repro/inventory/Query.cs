using System.Collections.Generic;
using HotChocolate;

namespace Demo.Inventory
{
    public class Query
    {
        public InventoryInfo GetInventoryInfo(
            int upc, 
            [Service] InventoryInfoRepository repository) =>
            repository.GetInventoryInfo(upc);
    }
}