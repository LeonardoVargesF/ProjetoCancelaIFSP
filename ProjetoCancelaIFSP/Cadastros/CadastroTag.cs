using CancelaIFSP.App.Base;
using CancelaIFSP.App.Models;
using CancelaIFSP.Domain.Base;
using CancelaIFSP.Domain.Entities;
using CancelaIFSP.Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CancelaIFSP.App.Cadastros
{
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public partial class CadastroTag : CadastroBase
    {
        private readonly IBaseService<Tag> _tagService;
        private readonly IBaseService<Usuario> _usuarioService;

        private List<TagModel>? tags;

        public CadastroTag(IBaseService<Tag> tagService, IBaseService<Usuario> usuarioService)
        {
            _tagService = tagService;
            _usuarioService = usuarioService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboUsuario.ValueMember = "Id";
            cboUsuario.DisplayMember = "CPF";
            cboUsuario.DataSource = _usuarioService.Get<UsuarioModel>().ToList();
        }

        private void PreencheObjeto(Tag tag)
        {
            tag.Codigo = txtCodigo.Text;

            if (int.TryParse(cboUsuario.SelectedValue.ToString(), out var idGrupo))
            {
                var usuario = _usuarioService.GetById<Usuario>(idGrupo);
                tag.Usuario = usuario;
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
                        var tag = _tagService.GetById<Tag>(id);
                        PreencheObjeto(tag);
                        _tagService.Update<Tag, Tag, TagValidator>(tag);
                    }
                }
                else
                {
                    var tag = new Tag();
                    PreencheObjeto(tag);
                    _tagService.Add<Tag, Tag, TagValidator>(tag);

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
                _tagService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            tags = _tagService.Get<TagModel>(new[] { "Cidade" }).ToList();
            dataGridViewConsulta.DataSource = tags;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["IdCidade"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtCodigo.Text = linha?.Cells["Codigo"].Value.ToString();
            cboUsuario.Text = linha?.Cells["Usuario"].Value.ToString();
        }

    }
}
