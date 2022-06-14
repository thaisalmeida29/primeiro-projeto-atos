using System;
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
    public partial class FrCadastroUsuarios : Form
    {
        List<Veiculo> listaEntrada = new List<Veiculo>();
        public FrCadastroUsuarios()
        {
            InitializeComponent();
        }

        private void FrCadastroUsuarios_Load(object sender, EventArgs e)
        {
            lbDataEntrada.Text = DateTime.Now.ToString("dd / MM / yyyy");
        }

        private void buttonVoltarHome_Click(object sender, EventArgs e)
        {
            FrmListaCarros verifica = new FrmListaCarros();
            verifica.ShowDialog();
        }

        private void buttonCadatrarEntrada_Click(object sender, EventArgs e)
        {
            Persistencia.lerArquivoEntrada(listaEntrada);
            if (tbPlacaEntrada.Text.Length != 7)
            {
                MessageBox.Show("Por favor, informar a placa com 7 caracteres." +
                    "\nSomente letras e números");
                return;
            }
            if (Veiculo.localizado(tbPlacaEntrada.Text, listaEntrada) != -27)
            {
                MessageBox.Show("Veiculo já está na Garagem.\nPlaca repetida.", "Erro de digitação");
                return;
            }
            var dataCorrente = DateTime.Now;
            var veiculo = new Veiculo(tbPlacaEntrada.Text, dataCorrente.ToString("dd/MM/yyyy"), dataCorrente.ToString("HH:mm"));
            listaEntrada.Add(veiculo);
            Persistencia.gravarNoArquivoEntrada(listaEntrada);
        }

        private void buttonLimparEntrada_Click(object sender, EventArgs e)
        {
            tbPlacaEntrada.Clear();
        }

        private void timerHoraEntrada_Tick(object sender, EventArgs e)
        {
            lbHoraEntrada.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void lbDataEntrada_Click(object sender, EventArgs e)
        {
            
        }
    }
}