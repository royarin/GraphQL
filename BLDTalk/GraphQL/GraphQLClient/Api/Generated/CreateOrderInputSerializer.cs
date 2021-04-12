using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorGQL
{
    public class CreateOrderInputSerializer
        : IInputSerializer
    {
        private bool _needsInitialization = true;
        private IValueSerializer _stringSerializer;
        private IValueSerializer _lineItemInputSerializer;

        public string Name { get; } = "CreateOrderInput";

        public ValueKind Kind { get; } = ValueKind.InputObject;

        public Type ClrType => typeof(CreateOrderInput);

        public Type SerializationType => typeof(IReadOnlyDictionary<string, object>);

        public void Initialize(IValueSerializerResolver serializerResolver)
        {
            if (serializerResolver is null)
            {
                throw new ArgumentNullException(nameof(serializerResolver));
            }
            _stringSerializer = serializerResolver.GetValueSerializer("String");
            _lineItemInputSerializer = serializerResolver.GetValueSerializer("LineItemInput");
            _needsInitialization = false;
        }

        public object Serialize(object value)
        {
            if (_needsInitialization)
            {
                throw new InvalidOperationException(
                    $"The serializer for type `{Name}` has not been initialized.");
            }

            if (value is null)
            {
                return null;
            }

            var input = (CreateOrderInput)value;
            var map = new Dictionary<string, object>();

            if (input.DeliveryAddress1.HasValue)
            {
                map.Add("deliveryAddress1", SerializeNullableString(input.DeliveryAddress1.Value));
            }

            if (input.DeliveryAddress2.HasValue)
            {
                map.Add("deliveryAddress2", SerializeNullableString(input.DeliveryAddress2.Value));
            }

            if (input.DeliveryCity.HasValue)
            {
                map.Add("deliveryCity", SerializeNullableString(input.DeliveryCity.Value));
            }

            if (input.DeliveryCountry.HasValue)
            {
                map.Add("deliveryCountry", SerializeNullableString(input.DeliveryCountry.Value));
            }

            if (input.DeliveryName.HasValue)
            {
                map.Add("deliveryName", SerializeNullableString(input.DeliveryName.Value));
            }

            if (input.DeliveryPostCode.HasValue)
            {
                map.Add("deliveryPostCode", SerializeNullableString(input.DeliveryPostCode.Value));
            }

            if (input.LineItems.HasValue)
            {
                map.Add("lineItems", SerializeNullableListOfLineItemInput(input.LineItems.Value));
            }

            return map;
        }

        private object SerializeNullableString(object value)
        {
            return _stringSerializer.Serialize(value);
        }
        private object SerializeNullableLineItemInput(object value)
        {
            return _lineItemInputSerializer.Serialize(value);
        }

        private object SerializeNullableListOfLineItemInput(object value)
        {
            IList source = (IList)value;
            object[] result = new object[source.Count];
            for(int i = 0; i < source.Count; i++)
            {
                result[i] = SerializeNullableLineItemInput(source[i]);
            }
            return result;
        }

        public object Deserialize(object value)
        {
            throw new NotSupportedException(
                "Deserializing input values is not supported.");
        }
    }
}
