using CancelaIFSP.Domain.Base;
using CancelaIFSP.Domain.Entities;
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
    public partial class RelatorioUsuario : Form
    {
        private readonly IBaseService<Usuario> _usuarioService;
        private readonly IBaseService<Carro> _carroService;
        private readonly IBaseService<UsuarioCarro> _usuariocarroService;

        private List<Usuario> usuarios;
        private List<UsuarioCarro> cadveiculos;
        public RelatorioUsuario(IBaseService<Usuario> usuarioService, IBaseService<Carro> carroService, IBaseService<UsuarioCarro> usuariocarroService)
        {
            _usuarioService = usuarioService;
            _carroService = carroService;
            _usuariocarroService = usuariocarroService;
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            usuarios = _usuarioService.Get<Usuario>().ToList();
            dataGridViewConsulta.DataSource = usuarios;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void RelatorioUsuario_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
