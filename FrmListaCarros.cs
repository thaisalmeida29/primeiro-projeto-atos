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
        /// <summary>
        /// inicializa as listas
        /// </summary>
        public FrmListaCarros()
        {
            InitializeComponent();
            IniciarListaEntrada();
            IniciarListaSaida();
        }
        /// <summary>
        /// ler a lista de saida, o arquivo de saida e escreve no listbox
        /// </summary>
        public void IniciarListaSaida()
        {
            var listaVeiculoSaida = new List<Veiculo>();
            Persistencia.lerArquivoSaida(listaVeiculoSaida);
            foreach (Veiculo veiculo in listaVeiculoSaida)
            {
                listBoxListaSaida.Items.Add($"{veiculo.Placa} - {veiculo.TempoPermanencia} Minuto(s) - R$ {veiculo.ValorCobrado}  {Environment.NewLine}");
            }
        }
        /// <summary>
        /// ler a lista de entrada, o arquivo de entrada e escreve no listbox
        /// </summary>
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
        /// <summary>
        /// método que apaga o listbox da lista de entrada e do arquivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void btApagarListaEntrada_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Deseja mesmo excluir a lista de entrada?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                List<Veiculo> listaEntradaVazia = new List<Veiculo>();
                Persistencia.gravarNoArquivoEntrada(listaEntradaVazia);
                listBoxListaEntrada.Items.Clear();
            }
            else
            {
                MessageBox.Show("Lista não excluída");
            }
        }

        /// <summary>
        /// método que apaga o listbox da lista de saida e do arquivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btApagarListaSaida_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Deseja mesmo excluir a lista de saída?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                List<Veiculo> listaVaziaSaida = new List<Veiculo>();
                Persistencia.gravarNoArquivoSaida(listaVaziaSaida);
                listBoxListaSaida.Items.Clear();
            }
            else
            {
                MessageBox.Show("Lista não excluída");
            }
        }

        private void FrmListaCarros_Load(object sender, EventArgs e)
        {

        }
    }
}
