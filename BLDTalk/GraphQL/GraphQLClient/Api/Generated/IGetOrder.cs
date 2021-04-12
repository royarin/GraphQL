using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorGQL
{
    public interface IGetOrder
    {
        IOrderFields Order { get; }
    }
}
