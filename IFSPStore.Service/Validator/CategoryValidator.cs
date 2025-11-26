using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validator
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().NotNull()
                .WithMessage("Nome da categoria é obrigatório")
                .MaximumLength(50).WithMessage("Nome da categoria deve conter no máximo 50 caracteres");
        }
    }
}
