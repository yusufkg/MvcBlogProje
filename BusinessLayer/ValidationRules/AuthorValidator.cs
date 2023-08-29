using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class AuthorValidator:AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Yazar adı boş geçilemez");
            RuleFor(x => x.AuthorTitle).NotEmpty().WithMessage("Yazar başlık değeri boş geçilemez");
            RuleFor(x => x.AuthorImage).NotEmpty().WithMessage("Yazar görseli boş geçilemez");
            RuleFor(x => x.AuthorAbout).NotEmpty().WithMessage("Yazar hakkında kısmı boş geçilemez");
        }
    }
}
