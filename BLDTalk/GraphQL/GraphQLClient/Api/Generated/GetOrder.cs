using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorGQL
{
    public class GetOrder
        : IGetOrder
    {
        public GetOrder(
            IOrderFields order)
        {
            Order = order;
        }

        public IOrderFields Order { get; }
    }
}
