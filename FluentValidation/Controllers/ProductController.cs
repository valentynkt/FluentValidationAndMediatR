using Microsoft.AspNetCore.Mvc;
using FluentValidationTest.Messaging.Requests;
using FluentValidationTest.Operations;
using MediatR;
namespace FluentValidation.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ISender  _mediator;
    private readonly ILogger<ProductController> _logger;

    public ProductController(ISender mediator,ILogger<ProductController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    // post create product 
    [HttpPost]
    public async Task<IActionResult> CreateProduct(int categoryId, string name)
    {
        //// validate product
        //var validator = new ProductValidator();
        //var result = validator.Validate(product);
        //if (!result.IsValid)
        //{
        //    return BadRequest(result.Errors);
        //}

        // save product
    
        //  
        var productRequest = new CreateProductRequest
        {
            CategoryId = categoryId,
            Name = name,
            Price = 100,
            IsActive = true
        };
     
        var result = await  _mediator.Send(productRequest);

        return Ok(result);
    }
}
