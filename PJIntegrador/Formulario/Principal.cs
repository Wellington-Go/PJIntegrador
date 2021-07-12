using System;
using System.Windows.Forms;
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
           /* PJIntegrador.Formulario.Funcionario tt = new Funcionario();

            tt.Show();*/
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text == string.Empty ) 
            {
                MessageBox.Show("CPF e Senha precisa ser informado !");
                txtCpf.Focus();
                return;
            }
            else if (txtSenha.Text == string.Empty)
            {
                MessageBox.Show("CPF e Senha precisa ser informado !");
                txtSenha.Focus();
                return;
            }
            else
            {
                 Acesso cs = new Acesso(txtCpf.Text, txtSenha.Text);
                cs.Logar();
                MessageBox.Show("Logado com sucesso");
                Formulario.Servicos fm = new Formulario.Servicos();
                fm.Show(); 
            }

           
            
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            // The password character is an asterisk.
            txtSenha.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txtSenha.MaxLength = 14;
        }
    }
}
