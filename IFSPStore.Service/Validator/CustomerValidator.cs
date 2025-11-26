using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validator
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Nome)
               .NotEmpty().NotNull()
               .WithMessage("Por favor informe o nome.");

            RuleFor(c => c.Address)
                .NotEmpty().NotNull()
                .WithMessage("Por favor informe o endereço.");

            RuleFor(c => c.District)
                .NotEmpty().NotNull()
                .WithMessage("Por favor informe o bairro.");
            RuleFor(c => c.City)
                .NotEmpty().NotNull()
                .WithMessage("Por favor informe a cidade.");

        }
    }
}

