using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEmpresa_WF
{
    public partial class FrmAssalariado : Form
    {
        public FrmAssalariado()
        {
            InitializeComponent();
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            Assalariado objAssalariado = new Assalariado();

            objAssalariado.nome = txtNome.Text;
            objAssalariado.sobrenome = txtSobreNome.Text;
            objAssalariado.cpf = txtCPF.Text;

            txtSalario.Text = objAssalariado.CalcularSalario().ToString("C");
        }
    }
}
