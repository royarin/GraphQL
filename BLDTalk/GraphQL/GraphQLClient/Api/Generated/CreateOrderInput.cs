using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorGQL
{
    public class CreateOrderInput
    {
        public Optional<string> DeliveryAddress1 { get; set; }

        public Optional<string> DeliveryAddress2 { get; set; }

        public Optional<string> DeliveryCity { get; set; }

        public Optional<string> DeliveryCountry { get; set; }

        public Optional<string> DeliveryName { get; set; }

        public Optional<string> DeliveryPostCode { get; set; }

        public Optional<List<LineItemInput>> LineItems { get; set; }
    }
}
