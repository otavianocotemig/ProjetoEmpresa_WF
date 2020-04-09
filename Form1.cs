using System;
using System.Windows.Forms;

namespace ProjetoEmpresa_WF
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAssalariado_Click(object sender, EventArgs e)
        {
            FrmAssalariado tela = new FrmAssalariado();
            tela.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComissionado_Click(object sender, EventArgs e)
        {
            FrmComissionado tela = new FrmComissionado();
            tela.ShowDialog();
        }

        private void btnHorista_Click(object sender, EventArgs e)
        {
            FrmHorista tela = new FrmHorista();
            tela.ShowDialog();
        }
    }
}
