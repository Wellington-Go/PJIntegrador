using System;
using System.Windows.Forms;
using PJIntegrador.classes;

namespace PJIntegrador
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Funcionario form = new Funcionario(
                txtNome.Text,
                txtEmail.Text,
                txttelefone.Text,
                txtSenha.Text,
                mskCpf.Text
            );
            form.Inserir();
            MessageBox.Show("Funcionario " + form.Id + " inserir!");
            LimparCampos();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txttelefone.Clear();
            mskCpf.Clear();
        }
    }
}
