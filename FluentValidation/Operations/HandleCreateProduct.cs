using FluentValidationTest.Messaging.Requests;
using FluentValidationTest.Messaging.Response;

namespace FluentValidationTest.Operations
{
    public class HandleCreateProduct : ICommand<CreateProductRequest,CreateProductResponse>
    {
        public HandleCreateProduct()
        {
            
        }


        public Task<CreateProductResponse> OnResponse(CreateProductRequest request, CancellationToken cancellationToken = default)
        {
            var product = new Product
            {
                Id = 1,
                CategoryId = request.CategoryId,
                Name = request.Name,
                Price = request.Price,
                CreatedAt = DateTime.UtcNow,
                IsActive = request.IsActive
            };

            DbContext.Products.Add(product);
            return Task.FromResult(new CreateProductResponse());
        }
    }
}
