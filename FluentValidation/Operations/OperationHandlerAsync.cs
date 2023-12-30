namespace FluentValidationTest.Operations
{
    public abstract class OperationHandlerAsync<TRequest, TResponse> : IOperationHandlerAsync<TRequest, TResponse>
    {
        public abstract Task<TResponse> OnResponse(TRequest request, CancellationToken cancellationToken = default);
    }
}
