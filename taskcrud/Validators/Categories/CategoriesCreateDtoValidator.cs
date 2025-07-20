using FluentValidation;
using taskcrud.DTOs.Categories;

namespace taskcrud.Validators.Categories
{
    public class CategoriesCreateDtoValidator:AbstractValidator<CategoryCreateDto>
    {
        public CategoriesCreateDtoValidator()
        {
            RuleFor(x=>x.Name).
                NotEmpty().
                    WithMessage("Category adi bos ola bilmez ! ").
                NotNull().
                    WithMessage("Category adi null ola bilmez ! ").
            MaximumLength(25).
                    WithMessage("Category adi cox uzundur");
        }
    }
}
