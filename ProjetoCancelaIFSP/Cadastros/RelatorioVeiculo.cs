using CancelaIFSP.App.Infra;
using CancelaIFSP.Domain.Base;
using CancelaIFSP.Domain.Entities;
using CancelaIFSP.Service.Validators;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CancelaIFSP.App.Cadastros
{
    public partial class RelatorioVeiculo : Form
    {
        private readonly IBaseService<Carro> _carroService;
        private readonly IBaseService<UsuarioCarro> _usuariocarroService;
        protected bool IsAlteracao = false;

        private List<Carro> carros;
        private List<UsuarioCarro> cadveiculos;
        public RelatorioVeiculo(IBaseService<Carro> carroService, IBaseService<UsuarioCarro> usuariocarroService)
        {
            _carroService = carroService;
            _usuariocarroService = usuariocarroService;
            InitializeComponent();
            CarregaGrid();
        }


        private void CarregaGrid()
        {
            carros = _carroService.Get<Carro>().ToList();
            dataGridViewConsulta.DataSource = carros;
            dataGridViewConsulta.Columns["Modelo"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridViewConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
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

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(@"Deseja realmente deletar?", @"IFSP", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    int id = (int)dataGridViewConsulta.SelectedRows[0].Cells["Id"].Value;
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
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"IFSP", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void CarregaRegistro(DataGridViewRow linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtModelo.Text = linha?.Cells["Modelo"].Value.ToString();
            txtPlaca.Text = linha?.Cells["Placa"].Value.ToString();
            txtCor.Text = linha?.Cells["Cor"].Value.ToString();
            txtAno.Text = linha?.Cells["Ano"].Value.ToString();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                IsAlteracao = true;
                var linha = dataGridViewConsulta.SelectedRows[0];
                CarregaRegistro(linha);
                tabControl.SelectedIndex = 1;
                tabPageCadastro.Focus();
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"GEREVENTOS", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar2_Click_1(object sender, EventArgs e)
        {
            try
            {


                if (int.TryParse(txtId.Text, out var id))
                {
                    var carro = _carroService.GetById<Carro>(id);
                    PreencheObjeto(carro);
                    carro = _carroService.Update<Carro, Carro, CarroValidator>(carro);
                }

                tabControl.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CarregaGrid();
        }

        private void btnCancelar2_Click_1(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }
    }
}

