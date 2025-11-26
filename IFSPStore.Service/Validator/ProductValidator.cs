using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validator
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator() 
        {
            RuleFor(p => p.Name)
                .NotEmpty().NotNull()
                .WithMessage("Nome do produto obrigatório");
            RuleFor(p => p.SalesUnit)
                .NotEmpty().NotNull()
                .WithMessage("Unidade de venda obrigatória");
        }
    }
}
