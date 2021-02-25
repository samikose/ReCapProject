using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation.CarValidator
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("Aracın günlük fiyatı 0'dan büyük olmalıdır");
            RuleFor(c => c.Description).MinimumLength(5).WithMessage("Araç açıklaması en az5 karakter uzunluğunda olmalıdır");
            RuleFor(c => c.ModelYear).MinimumLength(4).WithMessage("Araç yılı 4 haneden fazla olmalıdır");
            RuleFor(c => c.DailyPrice).NotEmpty();
        }
    }
}
