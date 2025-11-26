using FluentValidation;
using IFSPStore.Domain.Entities;
namespace IFSPStore.Service.Validator
{
    public class SaleValidator : AbstractValidator<Sale>
    {
        public SaleValidator() 
        {
            RuleFor(s => s.Customer)
                .NotEmpty().NotNull()
                .WithMessage("Cliente é obrigatório");
            RuleFor(s => s.Salesman)
                .NotEmpty().NotNull()
                .WithMessage("Vendedor é obrigatório");
            RuleFor(s => s.SaleItens)
                .NotEmpty().NotNull()
                .WithMessage("Por favor informe os produtos");
        }
    }
}
