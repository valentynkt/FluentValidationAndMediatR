public interface IBaseRequest 
{
    bool IsValid { get; }
    string? GetErrorMessage();
}