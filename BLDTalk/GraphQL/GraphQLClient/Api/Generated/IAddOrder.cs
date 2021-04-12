using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorGQL
{
    public interface IAddOrder
    {
        IOrder CreateOrder { get; }
    }
}
