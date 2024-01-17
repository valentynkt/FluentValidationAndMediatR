using FluentValidationTest.Messaging.Requests;
using FluentValidationTest.Messaging.Response;
using MediatR;

namespace FluentValidationTest.Operations
{
    public class HandleCreateProduct : OperationHandlerAsync<CreateProductRequest,CreateProductResponse>, IRequest
    {
        public HandleCreateProduct()
        {
            
        }


        public async override Task<CreateProductResponse> OnResponse(CreateProductRequest request, CancellationToken cancellationToken = default)
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

            // add async product to db
            await DbContext.AddAsync(product, cancellationToken);
            return new CreateProductResponse();
        }
    }
}
