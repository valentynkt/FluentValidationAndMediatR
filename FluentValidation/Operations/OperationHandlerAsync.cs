using FluentValidationTest.Messaging.Requests;
using MediatR;

namespace FluentValidationTest.Operations
{
    public abstract class OperationHandlerAsync<TRequest, TResponse> : IOperationHandlerAsync<TRequest, TResponse>, IRequestHandler<TRequest, TResponse>
        where TRequest : BaseHttpRequest<TResponse>
        where TResponse : class
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
        {
            var response = await OnResponse(request, cancellationToken);
            return response;
        }

        public abstract Task<TResponse> OnResponse(TRequest request, CancellationToken cancellationToken = default);
    }
}
