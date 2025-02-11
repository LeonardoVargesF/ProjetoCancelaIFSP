﻿using CancelaIFSP.App.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCancelaIFSP
{
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureDI.ConfiguraServices();

            Application.Run(new FormPrincipal());
        }
    }
}
