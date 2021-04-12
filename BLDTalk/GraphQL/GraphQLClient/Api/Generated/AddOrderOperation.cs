using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BlazorGQL
{
    public class AddOrderOperation
        : IOperation<IAddOrder>
    {
        public string Name => "addOrder";

        public IDocument Document => Queries.Default;

        public OperationKind Kind => OperationKind.Mutation;

        public Type ResultType => typeof(IAddOrder);

        public Optional<CreateOrderInput> Input { get; set; }

        public IReadOnlyList<VariableValue> GetVariableValues()
        {
            var variables = new List<VariableValue>();

            if (Input.HasValue)
            {
                variables.Add(new VariableValue("input", "CreateOrderInput", Input.Value));
            }

            return variables;
        }
    }
}
