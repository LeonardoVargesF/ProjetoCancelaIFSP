using CancelaIFSP.App.Base;
using CancelaIFSP.Domain.Base;
using CancelaIFSP.Domain.Entities;
using CancelaIFSP.Service.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CancelaIFSP.App.Cadastros
{
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public partial class CadastroVeiculo : CadastroBase
    {
        private readonly IBaseService<Carro> _carroService;
        private readonly IBaseService<UsuarioCarro> _usuariocarroService;

        private List<Carro> carros;
        private List<UsuarioCarro> cadveiculos;

        public CadastroVeiculo(IBaseService<Carro> carroService, IBaseService<UsuarioCarro> usuariocarroService)
        {
            _carroService = carroService;
            _usuariocarroService = usuariocarroService;
            InitializeComponent();
        }


        private void PreencheObjeto(Carro carro)
        {
            carro.Modelo = txtModelo.Text;
            carro.Placa = txtPlaca.Text;
            carro.Cor = txtCor.Text;

            if (int.TryParse(txtAno.Text, out var ano))
            {
                carro.Ano = ano;
            }
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {

                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var carro = _carroService.GetById<Carro>(id);
                        PreencheObjeto(carro);
                        carro = _carroService.Update<Carro, Carro, CarroValidator>(carro);
                    }

                }
                else
                {
                    var carro = new Carro();
                    PreencheObjeto(carro);
                    _carroService.Add<Carro, Carro, CarroValidator>(carro);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
