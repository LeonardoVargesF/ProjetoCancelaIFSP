using CancelaIFSP.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancelaIFSP.Domain.Entities
{
    public class Usuario : BaseEntity<int>
    {
        public Usuario()
        {

        }

        public Usuario(int id, string? nome, string? cpf, string? matricula, string? categoria) : base(id)
        {
            Nome = nome;
            CPF = cpf;
            Matricula = matricula;
            Categoria = categoria;
        }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Matricula { get; set; }
        public string? Categoria { get; set; }

    }
}
