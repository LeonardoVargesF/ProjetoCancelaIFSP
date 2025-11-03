using CancelaIFSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancelaIFSP.App.Models
{
    internal class UsuarioModel
    {
        public UsuarioModel()
        {
            Carros = new List<UsuarioCarro>();
        }
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Matricula { get; set; }
        public string? Categoria { get; set; }
        public string? Embedding {  get; set; }
        public List<UsuarioCarro> Carros { get; set; }

    }
    public class UsuarioCarroModel
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string? Usuario { get; set; }
        public int IdCarro { get; set; }
        public string? Carro { get; set; }
    }
}
