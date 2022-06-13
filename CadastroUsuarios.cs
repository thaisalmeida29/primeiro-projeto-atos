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

        }

        private void buttonVoltarHome_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadatrarEntrada_Click(object sender, EventArgs e)
        {
            var dataCorrente = DateTime.Now;
            var veiculo = new Veiculo(tbPlacaEntrada.Text, dataCorrente.ToString("dd/MM/yyyy"), dataCorrente.ToString("HH:mm"));
            Persistencia.lerArquivoEntrada(listaEntrada);
            listaEntrada.Add(veiculo);
            Persistencia.gravarNoArquivoEntrada(listaEntrada);
        }

        private void buttonLimparEntrada_Click(object sender, EventArgs e)
        {
            tbPlacaEntrada.Clear();
        }
    }
}