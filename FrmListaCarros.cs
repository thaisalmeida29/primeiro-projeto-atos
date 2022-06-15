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
    public partial class FrmListaCarros : Form
    {
        public FrmListaCarros()
        {
            InitializeComponent();
            IniciarListaEntrada();
            IniciarListaSaida();
        }

        public void IniciarListaSaida()
        {
            var listaVeiculoSaida = new List<Veiculo>();
            Persistencia.lerArquivoSaida(listaVeiculoSaida);
            foreach (Veiculo veiculo in listaVeiculoSaida)
            {
                listBoxListaSaida.Items.Add($"{veiculo.Placa} - {veiculo.TempoPermanencia} Minuto(s) - R$ {veiculo.ValorCobrado}  {Environment.NewLine}");
            }
        }

        public void IniciarListaEntrada()
        {
            var listaVeiculoEntrada = new List<Veiculo>();
            Persistencia.lerArquivoEntrada(listaVeiculoEntrada);
            int contador = 0;
            foreach (Veiculo veiculo in listaVeiculoEntrada)
            {
                contador++;
                listBoxListaEntrada.Items.Add(contador + " - " + veiculo.Placa + " - " + veiculo.DataEntrada + " - " + veiculo.HoraEntrada + Environment.NewLine);
            }
        }

        private void tbListaSaida_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbListaEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFecharLista_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btApagarListaEntrada_Click(object sender, EventArgs e)
        {
            List<Veiculo> listaEntradaVazia = new List<Veiculo>();
            Persistencia.gravarNoArquivoEntrada(listaEntradaVazia);
            listBoxListaEntrada.Items.Clear();
        }

        private void btApagarListaSaida_Click(object sender, EventArgs e)
        {
            List<Veiculo> listaVaziaSaida = new List<Veiculo>();
            Persistencia.gravarNoArquivoSaida(listaVaziaSaida);
            listBoxListaSaida.Items.Clear();
        }
    }
}
