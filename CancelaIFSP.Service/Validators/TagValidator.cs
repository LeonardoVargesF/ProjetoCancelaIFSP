using CancelaIFSP.Domain.Entities;
using FluentValidation;


namespace CancelaIFSP.Service.Validators
{
    public class 
        TagValidator : AbstractValidator<Tag>
    {
        public TagValidator()
        {
            RuleFor(c => c.Codigo)
                .NotEmpty().WithMessage("Por favor informe o codigo.")
                .NotNull().WithMessage("Por favor informe o codigo.");
            RuleFor(c => c.Usuario)
                .NotEmpty().WithMessage("Por favor informe o usuario.")
                .NotNull().WithMessage("Por favor informe o usuario.");
        }
    }
}
