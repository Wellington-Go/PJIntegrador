using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PJIntegrador.Classes;

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
            frmFuncionario us = new frmFuncionario(
                txtNome.Text,
                txtEmail.Text,
                txttelefone.Text,
                txtSenha.Text,
                mskCpf.Text
            );

        }
    }
}
