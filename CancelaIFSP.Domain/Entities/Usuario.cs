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
            Carros = new List<UsuarioCarro>();
        }

        public Usuario(int id, string? nome, string? cpf, string? matricula, string? categoria,string? embedding, List<UsuarioCarro> carros) : base(id)
        {
            Nome = nome;
            CPF = cpf;
            Matricula = matricula;
            Categoria = categoria;
            Embedding = embedding;
            Carros = carros;
        }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Matricula { get; set; }
        public string? Categoria { get; set; }
        public string? Embedding { get; set; }
        public List<UsuarioCarro> Carros { get; set; }

    }
    public class UsuarioCarro : BaseEntity<int>
    {
        public UsuarioCarro()
        {

        }

        public UsuarioCarro(int id, DateTime dataCadastro, Carro? carro, Usuario? usuario) : base(id)
        {
            DataCadastro = dataCadastro;
            Carro = carro;
            Usuario = usuario;
        }

        public DateTime DataCadastro { get; set; }
        public Carro? Carro { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
