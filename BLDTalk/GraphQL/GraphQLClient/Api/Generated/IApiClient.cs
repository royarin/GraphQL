using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace BlazorGQL
{
    public interface IApiClient
    {
        Task<IOperationResult<IGetOrders>> GetOrdersAsync(
            CancellationToken cancellationToken = default);

        Task<IOperationResult<IGetOrders>> GetOrdersAsync(
            GetOrdersOperation operation,
            CancellationToken cancellationToken = default);

        Task<IOperationResult<IGetOrder>> GetOrderAsync(
            Optional<int> orderNumber = default,
            CancellationToken cancellationToken = default);

        Task<IOperationResult<IGetOrder>> GetOrderAsync(
            GetOrderOperation operation,
            CancellationToken cancellationToken = default);

        Task<IOperationResult<IAddOrder>> AddOrderAsync(
            Optional<CreateOrderInput> input = default,
            CancellationToken cancellationToken = default);

        Task<IOperationResult<IAddOrder>> AddOrderAsync(
            AddOrderOperation operation,
            CancellationToken cancellationToken = default);
    }
}
