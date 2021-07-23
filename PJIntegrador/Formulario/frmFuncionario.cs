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
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // remove pontos e traços do cpf
            Funcionario form = new Funcionario(
                txtNome.Text,
                txtEmail.Text,
                txttelefone.Text,
                mskCpf.Text,
                txtSenha.Text
            );
            form.Inserir();

            
            MessageBox.Show("Funcionario com id: "+form.Id+" inserido!","Projeto integrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        { }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txttelefone.Clear();
            mskCpf.Clear();
        }

        private void mskCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
