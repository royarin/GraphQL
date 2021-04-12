using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorGQL
{
    public class LineItemInput
    {
        public Optional<int> Quantity { get; set; }

        public Optional<string> Sku { get; set; }
    }
}
