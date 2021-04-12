using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace BlazorGQL
{
    public class ApiClient
        : IApiClient
    {
        private const string _clientName = "ApiClient";

        private readonly IOperationExecutor _executor;

        public ApiClient(IOperationExecutorPool executorPool)
        {
            _executor = executorPool.CreateExecutor(_clientName);
        }

        public Task<IOperationResult<IGetOrders>> GetOrdersAsync(
            CancellationToken cancellationToken = default)
        {

            return _executor.ExecuteAsync(
                new GetOrdersOperation(),
                cancellationToken);
        }

        public Task<IOperationResult<IGetOrders>> GetOrdersAsync(
            GetOrdersOperation operation,
            CancellationToken cancellationToken = default)
        {
            if (operation is null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            return _executor.ExecuteAsync(operation, cancellationToken);
        }

        public Task<IOperationResult<IGetOrder>> GetOrderAsync(
            Optional<int> orderNumber = default,
            CancellationToken cancellationToken = default)
        {

            return _executor.ExecuteAsync(
                new GetOrderOperation { OrderNumber = orderNumber },
                cancellationToken);
        }

        public Task<IOperationResult<IGetOrder>> GetOrderAsync(
            GetOrderOperation operation,
            CancellationToken cancellationToken = default)
        {
            if (operation is null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            return _executor.ExecuteAsync(operation, cancellationToken);
        }

        public Task<IOperationResult<IAddOrder>> AddOrderAsync(
            Optional<CreateOrderInput> input = default,
            CancellationToken cancellationToken = default)
        {
            if (input.HasValue && input.Value is null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            return _executor.ExecuteAsync(
                new AddOrderOperation { Input = input },
                cancellationToken);
        }

        public Task<IOperationResult<IAddOrder>> AddOrderAsync(
            AddOrderOperation operation,
            CancellationToken cancellationToken = default)
        {
            if (operation is null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            return _executor.ExecuteAsync(operation, cancellationToken);
        }
    }
}
