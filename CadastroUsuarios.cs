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
        public FrCadastroUsuarios()
        {
            InitializeComponent();
        }

        /// <summary>
        /// data do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrCadastroUsuarios_Load(object sender, EventArgs e)
        {
            lbDataEntrada.Text = DateTime.Now.ToString("dd / MM / yyyy");
        }

        private void buttonVoltarHome_Click(object sender, EventArgs e)
        {
            FrmListaCarros verifica = new FrmListaCarros();
            verifica.ShowDialog();
        }
        /// <summary>
        ///  ler o arquivo e verifica se tem espaço na garagem,
        /// se a placa é igual a 7 digitos e se o veiculo já está na garagem,
        /// se estiver manda um aviso senão cadastra a nova placa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCadatrarEntrada_Click(object sender, EventArgs e)
        {
            string placaEntrada = tbPlacaEntrada.Text;
            tbPlacaEntrada.Clear();
            var listaEntrada = new List<Veiculo>();
            Persistencia.lerArquivoEntrada(listaEntrada);

            if (placaEntrada.Length != 7)
            {
                MessageBox.Show("Por favor, informar a placa com 7 caracteres." +
                    "\nSomente letras e números");
                return;
            }

            if (listaEntrada.Count >= 50)
            {
                MessageBox.Show("Garagem lotada.");
                return;
            }
            
            if (Veiculo.localizado(placaEntrada, listaEntrada) != -27)
            {
                MessageBox.Show("Veiculo já está na Garagem.\nPlaca repetida.", "Erro de digitação");
                return;
            }
            var dataCorrente = DateTime.Now;
            var veiculo = new Veiculo(placaEntrada, dataCorrente.ToString("dd/MM/yyyy"), dataCorrente.ToString("HH:mm"));
            listaEntrada.Add(veiculo);
            Persistencia.gravarNoArquivoEntrada(listaEntrada);
            MessageBox.Show("Veiculo cadastrado com sucesso!");
        }
    
        /// <summary>
        /// hora do formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerHoraEntrada_Tick(object sender, EventArgs e)
        {
            lbHoraEntrada.Text = DateTime.Now.ToString("HH:mm:ss");
        }   
    }
}