using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorGQL
{
    public class GetOrderOperation
        : IOperation<IGetOrder>
    {
        public string Name => "getOrder";

        public IDocument Document => Queries.Default;

        public OperationKind Kind => OperationKind.Query;

        public Type ResultType => typeof(IGetOrder);

        public Optional<int> OrderNumber { get; set; }

        public IReadOnlyList<VariableValue> GetVariableValues()
        {
            var variables = new List<VariableValue>();

            if (OrderNumber.HasValue)
            {
                variables.Add(new VariableValue("orderNumber", "Int", OrderNumber.Value));
            }

            return variables;
        }
    }
}
