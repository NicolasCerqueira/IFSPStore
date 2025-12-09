using FluentValidation;
using IFSPStore.Domain.Entities;
namespace IFSPStore.Service.Validator
{
    public class SaleValidator : AbstractValidator<Sale>
    {
        public SaleValidator() 
        {
            RuleFor(s => s.CustomerId)
                .GreaterThan(0) 
                .WithMessage("Cliente é obrigatório");

            RuleFor(s => s.SalesmanId)
                .GreaterThan(0) 
                .WithMessage("Vendedor é obrigatório");

            RuleFor(s => s.SaleItens)
                .NotEmpty().NotNull()
                .WithMessage("Por favor informe os produtos");
        }
    }
}
