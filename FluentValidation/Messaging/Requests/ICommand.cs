using FluentValidationTest.Operations;
using MediatR;

namespace FluentValidationTest.Messaging.Requests
{
    public interface ICommand<TRequest, TResponse> : IOperationHandlerAsync<TRequest,TResponse> ,IRequest
    {
    }
    public class ICommand<TResponse> : IRequest<TResponse>
    {
    }
}
