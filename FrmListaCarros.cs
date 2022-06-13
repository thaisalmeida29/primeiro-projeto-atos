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
                tbListaSaida.AppendText($"{veiculo.Placa} - {veiculo.TempoPermanencia} Minuto(s) - R$ {veiculo.ValorCobrado}  {Environment.NewLine}");
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
                tbListaEntrada.AppendText(contador + " - " + veiculo.Placa + " - " + veiculo.DataEntrada + " - " + veiculo.HoraEntrada + Environment.NewLine);
            }
        }

        private void tbListaSaida_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
