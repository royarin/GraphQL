using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorGQL
{
    public interface IGetOrders
    {
        IReadOnlyList<IOrderFields> Orders { get; }
    }
}
