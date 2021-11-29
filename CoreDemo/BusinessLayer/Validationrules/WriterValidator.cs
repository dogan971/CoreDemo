using EntityLayer.Concreate;
using FluentValidation;

namespace BusinessLayer.Validationrules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.writerName).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.writerPassword).NotEmpty().WithMessage("Boş geçme");
            RuleFor(x => x.writerMail).NotEmpty().WithMessage("Boş geçme");
            RuleFor(x => x.writerName).MinimumLength(4).WithMessage("en az 4 karakter");
            RuleFor(x => x.writerName).MaximumLength(100).WithMessage("en fazla 100 karakter");
        }
    }
}
