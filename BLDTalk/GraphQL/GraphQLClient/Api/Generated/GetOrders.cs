using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorGQL
{
    public class GetOrders
        : IGetOrders
    {
        public GetOrders(
            IReadOnlyList<IOrderFields> orders)
        {
            Orders = orders;
        }

        public IReadOnlyList<IOrderFields> Orders { get; }
    }
}
