using System;
using System.Collections.Generic;
using FluentValidation;
using FluentValidationTest.Messaging.Requests;

namespace FluentValidation.Validators
{
    public class ProductValidator : AbstractValidator<CreateProductRequest>
    {
        public ProductValidator()
        {
            // rules for product properties
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.CategoryId).GreaterThan(0).WithMessage("Incorrect CategoryIds");
        }
    }
}
