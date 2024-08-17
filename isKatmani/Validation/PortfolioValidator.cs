using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using varlikKatmani.Concrete;

namespace isKatmani.Validation
{
    public class PortfolioValidator:AbstractValidator<portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.name).NotEmpty().WithMessage("Proje adı boş geçilemez");
            RuleFor(x => x.imageURL).NotEmpty().WithMessage("Görsel alanı boş geçilemez");
            RuleFor(x => x.imageURL2).NotEmpty().WithMessage("Görsel2 alanı boş geçilemez");
            RuleFor(x => x.price).NotEmpty().WithMessage("Price alanı boş geçilemez");
            RuleFor(x => x.value).NotEmpty().WithMessage("Value alanı boş geçilemez");
            RuleFor(x => x.name).MinimumLength(5).WithMessage("Proje adı en az 5 karakter olmalı");
            RuleFor(x => x.name).MaximumLength(100).WithMessage("Proje adı en fazla 10 karakter olmalı");


        }
    }
}
