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
    public partial class CadastroCarro : CadastroBase
    {
        private readonly IBaseService<Carro> _carroService;
        private readonly IBaseService<UsuarioCarro> _usuariocarroService;

        private List<Carro> carros;
        private List<UsuarioCarro> cadveiculos;

        public CadastroCarro(IBaseService<Carro> carroService, IBaseService<UsuarioCarro> usuariocarroService)
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

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void Deletar(int id)
        {
            try
            {
                var cadcarros = _usuariocarroService.Get<UsuarioCarro>(new List<string>() { "Usuario", "Carro" });
                foreach (var cadcarro in cadcarros)
                {
                    if (cadcarro.Carro.Id == id)
                    {
                        _usuariocarroService.Delete(cadcarro.Id);
                    }
                }
                _carroService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            carros = _carroService.Get<Carro>().ToList();
            dataGridViewConsulta.DataSource = carros;
            dataGridViewConsulta.Columns["Modelo"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtModelo.Text = linha?.Cells["Modelo"].Value.ToString();
            txtPlaca.Text = linha?.Cells["Placa"].Value.ToString();
            txtCor.Text = linha?.Cells["Cor"].Value.ToString();
            txtAno.Text = linha?.Cells["Ano"].Value.ToString();
        }

        private void materialTextBoxEdit4_Click(object sender, EventArgs e)
        {

        }
    }
}
