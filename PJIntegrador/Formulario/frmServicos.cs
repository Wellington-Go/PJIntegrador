﻿using System;
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
            txtValor.Clear();
        }

        private void frmServicos_Load(object sender, EventArgs e)
        {
            string query = "select * from cliente order by nome";
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbIdCliente.Items.Add(dr.GetString(1));
                
            }
            //string sql = "select * from funcionario order by nome";
            //var cd = Banco.Abrir();
            //cd.CommandText = sql;
            //var ds = cmd.ExecuteReader();
            //while (ds.Read())
            //{
            //    cmbIdCliente.Items.Add(ds.GetInt32(1));

            //}
        }

        private void DesbloquearControles()
        {
            cmbIdCliente.Enabled = true;
        }

        private void BloquearControles()
        {
            cmbIdCliente.Enabled = false;
        }

        private void cmbIdCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from servico where id = '"+cmbIdCliente+"'";
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
            servicos.IdCliente = Convert.ToInt32(cmbIdCliente.Text);
            servicos.Valor = txtValor.Text;
            if (servicos.Alterar())
            {
                MessageBox.Show("Serviço alterado com sucesso!");
                LimparCampos();
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
                dgvServicos.Rows[dgvServicos.Rows.Count - 1].Cells[2].Value = item.Data;
                dgvServicos.Rows[dgvServicos.Rows.Count - 1].Cells[3].Value = item.IdCliente;
                dgvServicos.Rows[dgvServicos.Rows.Count - 1].Cells[4].Value = item.Valor;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnListar.Text == "...")
            {
                
                txtId.Focus();
                BloquearControles();
                button1.Text = "Buscar";
            }
            else
            {
                txtId.ReadOnly = true;
                DesbloquearControles();
                button1.Text = "...";
                Servicos servicos = new Servicos();
                servicos.BuscarPorId(int.Parse(txtId.Text));
                if (servicos.ID > 0)
                {
                    cmbIdCliente.Text = Convert.ToString(servicos.IdCliente);
                    txtValor.Text = Convert.ToString(servicos.Valor);
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