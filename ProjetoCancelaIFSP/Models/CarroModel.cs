using CancelaIFSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancelaIFSP.App.Models
{
    internal class CarroModel
    {
        public CarroModel()
        {
            Usuarios = new List<UsuarioCarro>();
        }
        public int Id { get; set; }
        public string? Placa { get; set; }
        public string? Modelo { get; set; }
        public string? Cor { get; set; }
        public int Ano { get; set; }
        public string? ModCorAno { get; set; }
        public List<UsuarioCarro> Usuarios { get; set; }
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
