using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PJIntegrador.classes;

namespace PJIntegrador.Formulario
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Focus();
            button1.Text = "...";
            Cliente cliente = new Cliente();
            cliente.BuscarPorId(int.Parse(txtId.Text));
            if (cliente.Id > 0)
            {
                txtNome.Text = cliente.Nome;
                txtEmail.Text = cliente.Email;
                txtTelefone.Text = cliente.Telefone;
            }
            else
            {
                MessageBox.Show("Cliente não encontrado!");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            var lista = Cliente.ListarTodos();
            foreach (var item in lista)
            {
                dgvClientes.Rows.Add();
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[0].Value = item.Id;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[1].Value = item.Nome;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[2].Value = item.Cpf;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[3].Value = item.Email;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[4].Value = item.Telefone;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[5].Value = item.Senha;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[6].Value = item.Ativo;
            }
        }

        private void dgvEndereco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEndereco.Rows.Clear(); // Limpar os campos do dataGread
            int idCli = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[0].Value);
            var listaEnd = Endereco.ListaEnderecos(idCli);
            if (listaEnd.Count > 0) // Clientes_id for maior que 0 mostrar o foreach
            {
                foreach (var item in listaEnd)
                {
                    dgvEndereco.Rows.Add();
                    dgvEndereco.Rows[dgvEndereco.Rows.Count - 1].Cells[0].Value = item.Tipo; // mostrar tipo de endereço
                    dgvEndereco.Rows[dgvEndereco.Rows.Count - 1].Cells[1].Value = item.Cep; // mostrar cep do endereço
                    StringBuilder endereco = new StringBuilder();
                    endereco.Append(item.Logradouro); // mostrar logradouro e
                    endereco.Append(" _ Nº: " + item.Numero); // numero com ", " antes e
                    endereco.Append(" _ bairro: " + item.Bairro); // bairro com " - " antes
                    endereco.Append(" _ cidade: " + item.Cidade); // Cidade com " - " antes
                    dgvEndereco.Rows[dgvEndereco.Rows.Count - 1].Cells[2].Value = endereco;
                }
            }
            else
            {
                dgvEndereco.Rows.Add();
                string mensagem = "Não há endereço cadastrado neste cliente!"; // mensagem mostrada quando não houver endereço
                dgvEndereco.Rows[dgvEndereco.Rows.Count - 1].Cells[2].Value = mensagem; // Mostrar mensagem acima
            }
        }

        private void dgvClientes_KeyDown(object sender, KeyEventArgs e)
        {
            int linha = 0;
            if (e.KeyCode == Keys.Down && dgvClientes.CurrentRow.Index + 1 < dgvClientes.Rows.Count - 1)
            {
                linha = dgvClientes.CurrentRow.Index + 1;
            }
            if (e.KeyCode == Keys.Up && dgvClientes.CurrentRow.Index > 0)
            {
                linha = dgvClientes.CurrentRow.Index - 1;
            }

            dgvEndereco.Rows.Clear(); // Limpar os campos do dataGread
            int idCli = Convert.ToInt32(dgvClientes.Rows[linha].Cells[0].Value);
            var listaEnd = Endereco.ListaEnderecos(idCli);

            if (listaEnd.Count > 0) // Clientes_id for maior que 0 mostrar o foreach
            {
                foreach (var item in listaEnd)
                {
                    dgvEndereco.Rows.Add();
                    dgvEndereco.Rows[dgvEndereco.Rows.Count - 1].Cells[0].Value = item.Tipo; // mostrar tipo de endereço
                    dgvEndereco.Rows[dgvEndereco.Rows.Count - 1].Cells[1].Value = item.Cep; // mostrar cep do endereço
                    StringBuilder endereco = new StringBuilder();
                    endereco.Append(item.Logradouro); // mostrar logradouro e
                    endereco.Append(" _ Nº: " + item.Numero); // numero com ", " antes e
                    endereco.Append(" _ bairro: " + item.Bairro); // bairro com " - " antes
                    dgvEndereco.Rows[dgvEndereco.Rows.Count - 1].Cells[2].Value = endereco;
                }
            }
            else
            {
                dgvEndereco.Rows.Add();
                string mensagem = "Não há endereço cadastrado neste cliente!"; // mensagem mostrada quando não houver endereço
                dgvEndereco.Rows[dgvEndereco.Rows.Count - 1].Cells[2].Value = mensagem; // Mostrar mensagem acima
            }
        }
    }
}
