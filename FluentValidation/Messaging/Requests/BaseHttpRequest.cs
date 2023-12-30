namespace FluentValidationTest.Messaging.Requests
{
    public abstract class BaseHttpRequest : IBaseRequest
    {
        public bool IsValid => true;

        public string? GetErrorMessage()
        {
            return null;
        }
    }
}
