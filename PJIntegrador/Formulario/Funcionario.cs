using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PJIntegrador.classes;

namespace PJIntegrador.Formulario
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void Servicos_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // remove pontos e traços do cpf
            
            Funcionario funcionario = new Funcionario(
                txtNome.Text,
                txtEmail.Text,
                txttelefone.Text,
                mskCpf.Text,
                txtSenha.Text,
                chkAtivo.Checked
            );
            
            funcionario.Inserir();
            MessageBox.Show("Funcionario " + funcionario.Id + " inserir");
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txttelefone.Clear();
            mskCpf.Clear();
            txtSenha.Clear();
        }
        private void DesbloquearControles()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txttelefone.Enabled = true;
            mskCpf.Enabled = true;
            txtSenha.Enabled = true;
        }

        private void BloquearControles()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txttelefone.Enabled = false;
            mskCpf.Enabled = false;
            txtSenha.Enabled = false;
        }

        private void btnEditarAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
