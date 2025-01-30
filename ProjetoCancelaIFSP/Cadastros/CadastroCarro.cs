﻿using CancelaIFSP.App.Base;
using CancelaIFSP.Domain.Base;
using CancelaIFSP.Domain.Entities;
using CancelaIFSP.Service.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CancelaIFSP.App.Cadastros
{
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public partial class CadastroCarro : CadastroBase
    {
        private readonly IBaseService<Carro> _carroService;

        private List<Carro> carros;

        public CadastroCarro(IBaseService<Carro> carroService)
        {
            _carroService = carroService;
            InitializeComponent();
        }

        private void PreencheObjeto(Carro carro)
        {
            
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
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void Deletar(int id)
        {
            try
            {
                _carroService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            carros = _carroService.Get<Carro>().ToList();
            dataGridViewConsulta.DataSource = carros;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow linha)
        {
            
        }
    }
}
