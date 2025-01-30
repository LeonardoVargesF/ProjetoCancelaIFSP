using CancelaIFSP.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancelaIFSP.Domain.Entities
{
    public class Carro : BaseEntity<int>
    {
        public Carro()
        {
            Usuarios = new List<UsuarioCarro>();

        }

        public Carro(int id, string? placa, string? modelo, string? cor, int ano, List<UsuarioCarro> usuarios) : base(id)
        {
            Placa = placa;
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
            Usuarios = usuarios;
        }
        public string? Placa { get; set; }
        public string? Modelo { get; set; }
        public string? Cor { get; set; }
        public int Ano { get; set; }
        public List<UsuarioCarro> Usuarios { get; set; }

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
