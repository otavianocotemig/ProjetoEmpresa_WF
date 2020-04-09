using System;
using System.Windows.Forms;

namespace ProjetoEmpresa_WF
{
    public partial class FrmHorista : Form
    {
        public FrmHorista()
        {
            InitializeComponent();

        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            Horista objHorista= new Horista();

            objHorista.nome = txtNome.Text;
            objHorista.sobrenome = txtSobreNome.Text;
            objHorista.cpf = txtCPF.Text;
            objHorista.horasTrabalhadas = int.Parse(txtNumHoras.Text);
            objHorista.precoHora = double.Parse(txtValorHora.Text);

            txtSalario.Text = objHorista.CalcularSalario().ToString("C");
        }
    }
}
