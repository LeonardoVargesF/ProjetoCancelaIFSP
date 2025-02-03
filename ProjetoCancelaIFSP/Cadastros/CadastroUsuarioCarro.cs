using CancelaIFSP.App.Models;
using CancelaIFSP.App.Outros;
using CancelaIFSP.Domain.Base;
using CancelaIFSP.Domain.Entities;
using CancelaIFSP.Service.Validators;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
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
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public partial class CadastroUsuarioCarro : MaterialForm
    {
        private readonly IBaseService<Usuario> _usuarioService;
        private readonly IBaseService<Carro> _carroService;
        private readonly IBaseService<UsuarioCarro> _usuariocarroService;

        private List<UsuarioCarro> cadveiculos;

        protected bool IsAlteracao = false;
        public CadastroUsuarioCarro(IBaseService<Usuario> usuarioService, IBaseService<Carro> carroService, IBaseService<UsuarioCarro> usuariocarroService)
        {
            _usuarioService = usuarioService;
            _carroService = carroService;
            _usuariocarroService = usuariocarroService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboUsuarios.ValueMember = "Id";
            cboUsuarios.DisplayMember = "CPF";
            cboUsuarios.DataSource = _usuarioService.Get<UsuarioModel>().ToList();

            cboCarros.ValueMember = "Id";
            cboCarros.DisplayMember = "Placa";
            cboCarros.DataSource = _carroService.Get<CarroModel>().ToList();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int.TryParse(cboUsuarios.SelectedValue.ToString(), out var idUsuario);
            var usuario = _usuarioService.GetById<Usuario>(idUsuario);
            int.TryParse(cboUsuarios.SelectedValue.ToString(), out var idCarro);
            var carro = _carroService.GetById<Carro>(idCarro);

            bool taCadastrado = false;

            var cadcarros = _usuariocarroService.Get<UsuarioCarro>(new List<string>() { "Usuario", "Carro" });
            foreach (var cadcarro in cadcarros)
            {
                if (cadcarro.Carro.Id == idCarro && cadcarro.Usuario.Id == idUsuario)
                {
                    taCadastrado = true;
                }
            }

            if (!taCadastrado)
            {
                try
                {
                    var cadastro = new UsuarioCarro()
                    {
                        Carro = carro,
                        Usuario = usuario,


                    };
                    _usuariocarroService.Add<UsuarioCarro, UsuarioCarro, UsuarioCarroValidator>(cadastro);
                    MessageBox.Show(@"Cadastro Realizado!", @"IFSP", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(@"Usuário já cadastrado com esse carro!", @"IFSP", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            int.TryParse(cboUsuarios.SelectedValue.ToString(), out var idUsuario);
            var usuario = _usuarioService.GetById<Usuario>(idUsuario);
            int.TryParse(cboUsuarios.SelectedValue.ToString(), out var idCarro);
            var carro = _carroService.GetById<Carro>(idCarro);

            bool taCadastrado = false;

            var cadcarros = _usuariocarroService.Get<UsuarioCarro>(new List<string>() { "Usuario", "Carro" });
            foreach (var cadcarro in cadcarros)
            {
                if (cadcarro.Usuario.Id == idUsuario && cadcarro.Carro.Id == idCarro)
                {
                    taCadastrado = true;
                    _usuariocarroService.Delete(cadcarro.Id);
                    MessageBox.Show(@"Você cancelou o cadastro do usuário com este carro!", @"IFSP", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }

            if (!taCadastrado)
            {
                MessageBox.Show(@"Usuário não esta cadastrado com esse carro!", @"IFSP", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        protected void CarregaEventos()
        {
            var cadveiculos = _usuariocarroService.Get<UsuarioCarro>(new List<string>() { "Usuario", "Carro" }).OrderBy(x => x.Usuario.Id);
            foreach (var cadveiculo in cadveiculos)
            {
                CaixadeCadastros even = new CaixadeCadastros();
                even.lblNomeUsuario.Text = "Nome: " + cadveiculo.Usuario.Nome;
                even.lblCPFUsuario.Text = "CPF: " + cadveiculo.Usuario.CPF;
                even.lblCategoriaUsuario.Text = "Categoria: " + cadveiculo.Usuario.Categoria;

                even.lblModeloCarro.Text = "Modelo: " + cadveiculo.Carro.Modelo;
                even.lblPlacaCarro.Text = "Placa: " + cadveiculo.Carro.Placa;
                even.lblCorCarro.Text = "Cor: " + cadveiculo.Carro.Cor;

                flowLayoutCadastros.Controls.Add(even);
            }
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaEventos();
        }

        private void tabPageConsulta_Leave(object sender, EventArgs e)
        {
            flowLayoutCadastros.Controls.Clear();
        }
    }
}
