using CancelaIFSP.Domain.Entities;
using FluentValidation;

namespace CancelaIFSP.Service.Validators
{
    public class CarroValidator : AbstractValidator<Carro>
    {
        public CarroValidator()
        {
            RuleFor(c => c.Placa)
                .NotEmpty().WithMessage("Por favor informe a placa.")
                .NotNull().WithMessage("Por favor informe a placa.");
            RuleFor(c => c.Modelo)
                .NotEmpty().WithMessage("Por favor informe o modelo.")
                .NotNull().WithMessage("Por favor informe o modelo.");
            RuleFor(c => c.Cor)
                .NotEmpty().WithMessage("Por favor informe a cor.")
                .NotNull().WithMessage("Por favor informe a cor.");
            RuleFor(c => c.Ano)
                .NotEmpty().WithMessage("Por favor informe o ano.")
                .NotNull().WithMessage("Por favor informe o ano.");
        }
    }
}
