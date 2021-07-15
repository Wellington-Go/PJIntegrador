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
                mskCpf.Text,
                Convert.ToInt32(IdServico.Text)
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
            IdServico.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.Rows.Clear();
            var lista = Funcionario.ListarTodos();
            foreach (var item in lista)
            {
                dgvFuncionarios.Rows.Add();
                dgvFuncionarios.Rows[dgvFuncionarios.Rows.Count - 1].Cells[0].Value = item.Id;
                dgvFuncionarios.Rows[dgvFuncionarios.Rows.Count - 1].Cells[1].Value = item.Nome;
                dgvFuncionarios.Rows[dgvFuncionarios.Rows.Count - 1].Cells[2].Value = item.Email;
                dgvFuncionarios.Rows[dgvFuncionarios.Rows.Count - 1].Cells[3].Value = item.Senha;
                dgvFuncionarios.Rows[dgvFuncionarios.Rows.Count - 1].Cells[4].Value = item.Telefone;
                dgvFuncionarios.Rows[dgvFuncionarios.Rows.Count - 1].Cells[5].Value = item.CPF;
                dgvFuncionarios.Rows[dgvFuncionarios.Rows.Count - 1].Cells[6].Value = item.Ativo;
                dgvFuncionarios.Rows[dgvFuncionarios.Rows.Count - 1].Cells[7].Value = item.IdServico;
            }
        }
    }
}
