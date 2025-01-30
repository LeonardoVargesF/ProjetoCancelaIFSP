using CancelaIFSP.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancelaIFSP.Domain.Entities
{
    public class Tag : BaseEntity<int>
    {
        public Tag()
        {

        }

        public Tag(int id, string? codigo, Usuario? usuario) : base(id)
        {
            Codigo = codigo;
            Usuario = usuario;

        }
        public string? Codigo { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
