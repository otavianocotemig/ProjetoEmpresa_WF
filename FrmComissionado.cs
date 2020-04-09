using System;
using System.Windows.Forms;

namespace ProjetoEmpresa_WF
{
    public partial class FrmComissionado : Form
    {
        public FrmComissionado()
        {
            InitializeComponent();
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            Comissionado objComissionado = new Comissionado();

            objComissionado.nome = txtNome.Text;
            objComissionado.sobrenome = txtSobreNome.Text;
            objComissionado.cpf = txtCPF.Text;
            objComissionado.totalVenda = Convert.ToDouble(txtTotal.Text);

            txtSalario.Text = objComissionado.CalcularSalario().ToString("C");
        }
    }
}
