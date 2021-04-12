using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using StrawberryShake;
using StrawberryShake.Http;
using StrawberryShake.Http.Subscriptions;
using StrawberryShake.Transport;

namespace BlazorGQL
{
    public class GetOrdersResultParser
        : JsonResultParserBase<IGetOrders>
    {
        private readonly IValueSerializer _intSerializer;
        private readonly IValueSerializer _stringSerializer;

        public GetOrdersResultParser(IValueSerializerResolver serializerResolver)
        {
            if (serializerResolver is null)
            {
                throw new ArgumentNullException(nameof(serializerResolver));
            }
            _intSerializer = serializerResolver.GetValueSerializer("Int");
            _stringSerializer = serializerResolver.GetValueSerializer("String");
        }

        protected override IGetOrders ParserData(JsonElement data)
        {
            return new GetOrders
            (
                ParseGetOrdersOrders(data, "orders")
            );

        }

        private IReadOnlyList<IOrderFields> ParseGetOrdersOrders(
            JsonElement parent,
            string field)
        {
            if (!parent.TryGetProperty(field, out JsonElement obj))
            {
                return null;
            }

            if (obj.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            int objLength = obj.GetArrayLength();
            var list = new IOrderFields[objLength];
            for (int objIndex = 0; objIndex < objLength; objIndex++)
            {
                JsonElement element = obj[objIndex];
                list[objIndex] = new OrderFields
                (
                    DeserializeInt(element, "orderNumber"),
                    DeserializeString(element, "deliveryName"),
                    DeserializeString(element, "deliveryAddress1")
                );

            }

            return list;
        }

        private int DeserializeInt(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (int)_intSerializer.Deserialize(value.GetInt32());
        }

        private string DeserializeString(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (string)_stringSerializer.Deserialize(value.GetString());
        }
    }
}
