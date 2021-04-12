using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorGQL
{
    public interface IOrder
    {
        int OrderNumber { get; }

        string DeliveryName { get; }
    }
}
