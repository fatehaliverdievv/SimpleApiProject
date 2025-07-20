using FluentValidation;
using taskcrud.DTOs.Categories;

namespace taskcrud.Validators.Categories
{
    public class CategoryUpdateDtoValidator : AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Category adi bos ola bilmez")
                .MaximumLength(25).WithMessage("Category adi cox uzundur");
        }
    }

}
