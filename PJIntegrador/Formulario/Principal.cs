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
            Close();
          
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            if(txtCpf.Text == string.Empty) 
            {
                MessageBox.Show("Campo vazio");
                txtCpf.Focus();
                return;
            }
            else if (txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Campo vazio");
                txtSenha.Focus();
                return;
            }
            
            {

                Funcionario fm = new Funcionario();
                fm.BuscarFun(txtCpf.Text,txtSenha.Text);
                MessageBox.Show(fm.msg);

              //Acesso cs = new Acesso(txtCpf.Text, txtSenha.Text);
              // cs.Logar();
              // MessageBox.Show("Logado com sucesso");
              // PJIntegrador.Formulario.Servicos fm = new Formulario.Servicos();
              // fm.Show();
            }
        
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
