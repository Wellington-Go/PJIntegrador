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
            txtIdAcesso.Clear();
        }

        private void frmServicos_Load(object sender, EventArgs e)
        {
            /*----------------------------------------------
             Rotina:
             data:
             Autor:
             objetivo:
             
             */
            
            string query = "select * from cliente order by nome ";
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbCliente.Items.Add(dr.GetString(1));
            }

            /*----------------------------------------------
            Rotina:
            data:
            Autor:
            objetivo:

            */

            
            string sql = "select * from funcionario order by nome ";
            var cd = Banco.Abrir();
            cd.CommandText = sql;
            var ds = cd.ExecuteReader();
            while (ds.Read())
            {
                cmbFun.Items.Add(ds.GetString(1));
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from cliente where nome = '"+cmbCliente.Text+"' ";
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //cmbCliente.Items.Add(dr.GetString(1));
                label6.Text= Convert.ToString(dr.GetInt32(0));
            }
        }

        private void cmbCliente_Click(object sender, EventArgs e)
        { }

        private void cmbFun_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from funcionario where nome = '" + cmbFun.Text + "' ";
            var cmd = Banco.Abrir();
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //cmbCliente.Items.Add(dr.GetString(1));
                label7.Text = Convert.ToString(dr.GetInt32(0));
            }
        }
    }
}
