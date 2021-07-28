using System;
using System.Windows.Forms;
using PJIntegrador.Formulario;
using PJIntegrador.classes;

namespace PJIntegrador
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void bntCadastro_Click(object sender, EventArgs e)
        {
            PJIntegrador.frmFuncionario fn = new frmFuncionario();
            fn.Show();
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            if(txtCpf.Text == string.Empty) 
            {
                MessageBox.Show("Cpf vazio, obrigatório ser preenchido!", "Projeto integrador!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCpf.Focus();
                return;
            }
            else if (txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Senha vazia, obrigatório ser preenchido!", "Projeto integrador!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Focus();
                return;
            }
            else
            {
                Funcionario fm = new Funcionario();
                fm.BuscarFun(txtCpf.Text, txtSenha.Text);
                MessageBox.Show(fm.msg, "Projeto integrador!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*'; // The password character is an asterisk.
            txtSenha.MaxLength = 14; // The control will allow no more than 14 characters.
        }
    }
}
