using FluentValidationTest.Messaging.Requests;
using MediatR;

namespace FluentValidationTest.Operations
{
    public interface IOperationHandlerAsync<TRequest, TResponse>
    {
         Task<TResponse> OnResponse(TRequest request, CancellationToken cancellationToken = default);
    }
}
