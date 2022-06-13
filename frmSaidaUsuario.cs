﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio_atos
{
    public partial class frmSaidaUsuario : Form
    {
        public frmSaidaUsuario()
        {
            InitializeComponent();
        }

        private void btLimparSaida_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btSalvarSaida_Click(object sender, EventArgs e)
        {
            var listaEntrada = new List<Veiculo>();
            Persistencia.lerArquivoEntrada(listaEntrada);
            var veiculoEncontrado = listaEntrada.FirstOrDefault(v => v.Placa == textBox1.Text);
            if(veiculoEncontrado != null)
            {
                var dataCorrente = DateTime.Now;
                veiculoEncontrado.DataSaida = dataCorrente.ToString("dd/MM/yyyy");
                veiculoEncontrado.HoraSaida = dataCorrente.ToString("HH: mm");
                veiculoEncontrado.realizarCobranca(5);
                var listaSaida = new List<Veiculo>();
                Persistencia.lerArquivoSaida(listaSaida);
                listaSaida.Add(veiculoEncontrado);
                Persistencia.gravarNoArquivoSaida(listaSaida);
                listaEntrada.Remove(veiculoEncontrado);
                Persistencia.gravarNoArquivoEntrada(listaEntrada);
            }
        }
    }
}