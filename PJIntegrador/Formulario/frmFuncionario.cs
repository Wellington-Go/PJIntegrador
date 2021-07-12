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
            txtId.Text = form.Id.ToString();
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
        private void DesbloquearControles()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
            txttelefone.Enabled = true;
            mskCpf.Enabled = true;
        }

        private void BloquearControles()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
            txttelefone.Enabled = false;
            mskCpf.Enabled = false;
        }
    }
}
