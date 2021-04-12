using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorGQL
{
    public class LineItemInputSerializer
        : IInputSerializer
    {
        private bool _needsInitialization = true;
        private IValueSerializer _intSerializer;
        private IValueSerializer _stringSerializer;

        public string Name { get; } = "LineItemInput";

        public ValueKind Kind { get; } = ValueKind.InputObject;

        public Type ClrType => typeof(LineItemInput);

        public Type SerializationType => typeof(IReadOnlyDictionary<string, object>);

        public void Initialize(IValueSerializerResolver serializerResolver)
        {
            if (serializerResolver is null)
            {
                throw new ArgumentNullException(nameof(serializerResolver));
            }
            _intSerializer = serializerResolver.GetValueSerializer("Int");
            _stringSerializer = serializerResolver.GetValueSerializer("String");
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

            var input = (LineItemInput)value;
            var map = new Dictionary<string, object>();

            if (input.Quantity.HasValue)
            {
                map.Add("quantity", SerializeNullableInt(input.Quantity.Value));
            }

            if (input.Sku.HasValue)
            {
                map.Add("sku", SerializeNullableString(input.Sku.Value));
            }

            return map;
        }

        private object SerializeNullableInt(object value)
        {
            return _intSerializer.Serialize(value);
        }
        private object SerializeNullableString(object value)
        {
            return _stringSerializer.Serialize(value);
        }

        public object Deserialize(object value)
        {
            throw new NotSupportedException(
                "Deserializing input values is not supported.");
        }
    }
}
