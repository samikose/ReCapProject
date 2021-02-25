using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.BrandValidator
{
    public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.BrandName).MinimumLength(2).WithMessage("Marka adı en az 3 karakter uzunluğunda olmalıdır");
        }
    }
}
