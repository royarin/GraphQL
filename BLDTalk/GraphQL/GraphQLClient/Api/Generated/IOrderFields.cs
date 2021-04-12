using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorGQL
{
    public interface IOrderFields
    {
        int OrderNumber { get; }

        string DeliveryName { get; }

        string DeliveryAddress1 { get; }
    }
}
