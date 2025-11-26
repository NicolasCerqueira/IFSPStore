using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validator
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().NotNull()
                .WithMessage("Nome do ususario obrigatório");
            RuleFor (c => c.Email)
                .EmailAddress().WithMessage("E-mail inválido")
                .NotEmpty().NotNull().WithMessage("E-mail obrigatório");
        }
    }
}
