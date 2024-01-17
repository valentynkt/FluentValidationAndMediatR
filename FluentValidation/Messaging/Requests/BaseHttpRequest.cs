using MediatR;

namespace FluentValidationTest.Messaging.Requests
{
    public abstract class BaseHttpRequest<TResponse> : IBaseRequest<TResponse>
    {
        public bool IsValid => true;

        public string? GetErrorMessage()
        {
            return null;
        }
    }
}
