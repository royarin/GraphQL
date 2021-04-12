using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorGQL
{
    public class GetOrdersOperation
        : IOperation<IGetOrders>
    {
        public string Name => "getOrders";

        public IDocument Document => Queries.Default;

        public OperationKind Kind => OperationKind.Query;

        public Type ResultType => typeof(IGetOrders);

        public IReadOnlyList<VariableValue> GetVariableValues()
        {
            return Array.Empty<VariableValue>();
        }
    }
}
