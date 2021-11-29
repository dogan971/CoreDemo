using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validationrules
{
   public  class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.categoryName).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.categoryDescription).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.categoryDescription).MinimumLength(10).WithMessage("Minimum 10 Karakter");
            RuleFor(x => x.categoryDescription).MaximumLength(50).WithMessage("Maximum 50 Karakter");

        }
    }
}
