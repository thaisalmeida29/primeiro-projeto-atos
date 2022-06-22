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
    public partial class frmPrincipal : Form
    {
        private Form frmAtivo;
        public frmPrincipal()
        {
            InitializeComponent();

        }
        /// <summary>
        /// método que faz passar de um formulário para o outro
        /// </summary>
        /// <param name="frm"></param>
        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        /// <summary>
        /// método para quando clicar em uma formulário fechar o outro
        /// </summary>
        private void ActiveFormClose()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }
        /// <summary>
        /// método para mudar de cor a parte do menu selecionada
        /// </summary>
        /// <param name="frmAtivo"></param>
        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelPrincipal.Controls)
            {
                ctrl.ForeColor = Color.Black;
            }

        }
        /// <summary>
        /// lista de entrada e saida de veiculos
        /// </summary>
        List<Veiculo> listaEntrada = new List<Veiculo>();
        List<Veiculo> listaSaida = new List<Veiculo>();
        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// data do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            lbData.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void lbData_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// passando de um formulário para o outro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            ActiveButton(buttonCadastrar);
            FormShow(new FrCadastroUsuarios());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormShow(new frmSaidaUsuario());
        }

        private void buttonLista_Click(object sender, EventArgs e)
        {
            FormShow(new FrmListaCarros());
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {

            ActiveFormClose();
        }
        /// <summary>
        /// fechando toda a aplicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GARAGEPLACE AGRADECE SUA CONFIANÇA!! \n VOLTE SEMPRE!");
            Application.Exit();
        }
        /// <summary>
        /// hora do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
