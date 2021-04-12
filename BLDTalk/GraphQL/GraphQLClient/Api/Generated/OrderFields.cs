using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorGQL
{
    public class OrderFields
        : IOrderFields
    {
        public OrderFields(
            int orderNumber, 
            string deliveryName, 
            string deliveryAddress1)
        {
            OrderNumber = orderNumber;
            DeliveryName = deliveryName;
            DeliveryAddress1 = deliveryAddress1;
        }

        public int OrderNumber { get; }

        public string DeliveryName { get; }

        public string DeliveryAddress1 { get; }
    }
}
