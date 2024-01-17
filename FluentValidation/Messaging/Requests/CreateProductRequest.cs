using FluentValidationTest.Messaging.Response;
using MediatR;

namespace FluentValidationTest.Messaging.Requests
{
    public class CreateProductRequest : BaseHttpRequest<CreateProductResponse>
    {
        public int CategoryId { get; set; } 
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

    }
}
