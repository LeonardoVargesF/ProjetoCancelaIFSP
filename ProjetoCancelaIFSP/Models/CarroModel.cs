using CancelaIFSP.Domain.Entities;
using System.Collections.Generic;

namespace CancelaIFSP.App.Models
{
    public class CarroModel
    {

        public int Id { get; set; }
        public string? Placa { get; set; }
        public string? Modelo { get; set; }
        public string? Cor { get; set; }
        public int Ano { get; set; }
        public string? ModCorAno { get; set; }
        public string PlacaNome => $"{Modelo} - {Placa}";
    }

}
