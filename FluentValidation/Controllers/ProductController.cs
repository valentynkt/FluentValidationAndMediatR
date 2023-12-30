using Microsoft.AspNetCore.Mvc;
using FluentValidationTest.Messaging.Requests;
using FluentValidationTest.Operations;
namespace FluentValidation.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    // post create product 
    [HttpPost]
    public IActionResult CreateProduct(CreateProductRequest product)
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
        var handler = new HandleCreateProduct();
        handler.OnResponse(product);

        return Ok(product);
    }
}
