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
            

        }

        public Carro(int id, string? placa, string? modelo, string? cor, int ano) : base(id)
        {
            Placa = placa;
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
        }
        public string? Placa { get; set; }
        public string? Modelo { get; set; }
        public string? Cor { get; set; }
        public int Ano { get; set; }
       

    }
}
