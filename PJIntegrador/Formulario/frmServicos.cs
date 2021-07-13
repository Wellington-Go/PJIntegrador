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
    public partial class frmServicos : Form
    {
        public frmServicos()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtValor.Clear();
            txtData.Clear();
        }

        private void frmServicos_Load(object sender, EventArgs e)
        {
            string query = "select * from cliente order by nome";
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbIdCliente.Items.Add(dr.GetInt32(1));

            }
            string sql = "select * from funcionario order by nome";
            var cd = Banco.Abrir();
            cd.CommandText = sql;
            var ds = cmd.ExecuteReader();
            while (ds.Read())
            {
                cmbIdCliente.Items.Add(ds.GetInt32(1));

            } 
        }

        private void DesbloquearControles()
        {
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            txtData.Enabled = true;
            cmbIdCliente.Enabled = true;
            cmbIdFuncionario.Enabled = true;
        }

        private void BloquearControles()
        {
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            txtData.Enabled = false;
            cmbIdCliente.Enabled = false;
            cmbIdFuncionario.Enabled = false;
        }

        private void cmbIdCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from servicos where id = '"+cmbIdCliente+"'";
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                label6.Text=(dr.GetString(0));
            }
        }

        
        private void btnEditarAlterar_Click(object sender, EventArgs e)
        {
            Servicos servicos = new Servicos();
            servicos.ID = int.Parse(txtId.Text);
            servicos.Descricao = txtDescricao.Text;
            servicos.Valor = Convert.ToDouble(txtValor.Text);
            servicos.Data = Convert.ToDateTime(txtData.Text);
            servicos.IdCliente = Convert.ToInt32(cmbIdCliente.Text);
            servicos.IdFuncionario = Convert.ToInt32(cmbIdFuncionario.Text);
            if (servicos.Alterar())
            {
                MessageBox.Show("Serviço alterado com sucesso!");
                LimparCampos();
                btnListar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao alterar o serviço!");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvServicos.Rows.Clear();
            var lista = Servicos.ListarTodos();
            foreach (var item in lista)
            {
                dgvServicos.Rows.Add();
                dgvServicos.Rows[dgvServicos.Rows.Count - 1].Cells[0].Value = item.ID;
                dgvServicos.Rows[dgvServicos.Rows.Count - 1].Cells[1].Value = item.Descricao;
                dgvServicos.Rows[dgvServicos.Rows.Count - 1].Cells[2].Value = item.Valor;
                dgvServicos.Rows[dgvServicos.Rows.Count - 1].Cells[3].Value = item.Data;
                dgvServicos.Rows[dgvServicos.Rows.Count - 1].Cells[4].Value = item.IdCliente;
                dgvServicos.Rows[dgvServicos.Rows.Count - 1].Cells[5].Value = item.IdFuncionario;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnListar.Text == "...")
            {
                txtId.ReadOnly = false;
                txtId.Focus();
                BloquearControles();
                btnListar.Text = "Buscar";
            }
            else
            {
                txtId.ReadOnly = true;
                txtDescricao.Focus();
                DesbloquearControles();
                btnListar.Text = "...";
                Servicos servicos = new Servicos();
                servicos.BuscarPorId(int.Parse(txtId.Text));
                if (servicos.ID > 0)
                {
                    txtDescricao.Text = servicos.Descricao;
                    txtValor.Text = Convert.ToString(servicos.Valor);
                    txtData.Text = Convert.ToString(servicos.Data);
                    cmbIdCliente.Text = Convert.ToString(servicos.IdCliente);
                    cmbIdFuncionario.Text = Convert.ToString(servicos.IdFuncionario);
                }
                else
                {
                    MessageBox.Show("Serviço não encontrado!");
                }
            }
        }

        private void dgvServicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}