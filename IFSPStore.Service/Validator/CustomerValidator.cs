using FluentValidation;
using IFSPStore.Domain.Entities;
using System.Reflection.Metadata;

namespace IFSPStore.Service.Validator
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Nome)
               .NotEmpty().WithMessage("Por favor informe o nome.")
               .NotNull().WithMessage("Por favor informe o nome.");

            RuleFor(c => c.Address)
                .NotEmpty().WithMessage("Por favor informe o endereço.")
                .NotNull().WithMessage("Por favor informe o endereço.");

            RuleFor(c => c.District)
                .NotEmpty().WithMessage("Por favor informe o bairro.")
                .NotNull().WithMessage("Por favor informe o bairro.");
            RuleFor(c => c.City)
                .NotEmpty().WithMessage("Por favor informe a cidade.")
                .NotNull().WithMessage("Por favor informe a cidade.");

        }
    }
}

