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

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }
        
        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelPrincipal.Controls)
            {
                ctrl.ForeColor = Color.White;
            }
               
        }

        List<Veiculo> listaEntrada = new List<Veiculo>();
        List<Veiculo> listaSaida = new List<Veiculo>();
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void lbData_Click(object sender, EventArgs e)
        {
        }

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
            ActiveButton(buttonHome);
            ActiveFormClose();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
