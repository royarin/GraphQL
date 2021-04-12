using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorGQL
{
    public class AddOrder
        : IAddOrder
    {
        public AddOrder(
            IOrder createOrder)
        {
            CreateOrder = createOrder;
        }

        public IOrder CreateOrder { get; }
    }
}
