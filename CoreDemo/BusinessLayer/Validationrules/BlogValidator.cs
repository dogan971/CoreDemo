using EntityLayer.Concreate;
using FluentValidation;

namespace BusinessLayer.Validationrules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {

            RuleFor(x => x.blogTitle).NotEmpty().WithMessage("Blog Başlığı Boş Geçilemez");
            RuleFor(x => x.blogContent).NotEmpty().WithMessage("Blog İçeriği Boş Geçilmez");
            RuleFor(x => x.blogImage).NotEmpty().WithMessage("Blog Görseli Boş Geçilmez");
            RuleFor(x => x.blogTitle).MaximumLength(150).WithMessage("Lütfen 150 karakterden daha az veri girişi yapın");
            RuleFor(x => x.blogTitle).MinimumLength(5).WithMessage("Lütfen 5 karakterden daha fazla veri girişi yapın");


        }

    }
}
