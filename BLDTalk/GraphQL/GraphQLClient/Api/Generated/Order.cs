using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorGQL
{
    public class Order
        : IOrder
    {
        public Order(
            int orderNumber, 
            string deliveryName)
        {
            OrderNumber = orderNumber;
            DeliveryName = deliveryName;
        }

        public int OrderNumber { get; }

        public string DeliveryName { get; }
    }
}
