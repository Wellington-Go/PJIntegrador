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

        private void btninserir_Click(object sender, EventArgs e)
        {
            Servicos servicos = new Servicos(
                
                txtDescricao.Text,
                Convert.ToDouble(txtValor),
                Convert.ToDateTime(txtData.Text),
                Convert.ToInt32(txtIdAcesso)
            );
            servicos.Inserir();
            MessageBox.Show("Serviço " + servicos.ID + " inserir!");
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtValor.Clear();
            txtData.Clear();
            txtIdAcesso.Clear();
        }
    }
}
