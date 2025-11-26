using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validator
{
    public class CityValidator : AbstractValidator<City>
    {
        public CityValidator() 
        {
            RuleFor(c => c.Name)
                .NotEmpty().NotNull()
                .WithMessage("Nome da cidade obrigatório");
            RuleFor(c => c.State)
                .NotEmpty().NotNull()
                .WithMessage("Nome do estado obrigatótio")
                .Length(2)
                .WithMessage("Estado deve conter 2 caracteres");
        }
    }
}
