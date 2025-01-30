using CancelaIFSP.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancelaIFSP.Service.Validators
{
    public class UsuarioCarroValidator : AbstractValidator<UsuarioCarro>
    {
        public UsuarioCarroValidator()
        {
            RuleFor(c => c.Carro)
                .NotEmpty().WithMessage("Por favor informe o carro.")
                .NotNull().WithMessage("Por favor informe o carro.");
            RuleFor(c => c.Usuario)
                .NotEmpty().WithMessage("Por favor informe o usuario.")
                .NotNull().WithMessage("Por favor informe o usuario.");
        }
    }
}
