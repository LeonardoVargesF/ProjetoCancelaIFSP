using CancelaIFSP.Domain.Entities;
using FluentValidation;

namespace CancelaIFSP.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
            RuleFor(c => c.CPF)
                .NotEmpty().WithMessage("Por favor informe o CPF.")
                .NotNull().WithMessage("Por favor informe o CPF.");
            RuleFor(c => c.Matricula)
                .NotEmpty().WithMessage("Por favor informe a matrícula.")
                .NotNull().WithMessage("Por favor informe a matrícula.");
            RuleFor(c => c.Categoria)
                .NotEmpty().WithMessage("Por favor informe a categoria.")
                .NotNull().WithMessage("Por favor informe a categoria.");
        }
    }
}
