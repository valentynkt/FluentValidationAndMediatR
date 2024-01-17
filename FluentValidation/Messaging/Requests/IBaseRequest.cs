using MediatR;

public interface IBaseRequest<TResponse> : IRequest<TResponse>
{
    bool IsValid { get; }
    string? GetErrorMessage();
}