using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using PJIntegrador.Formulario;

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
            PJIntegrador.Formulario.Servicos tt = new Servicos();

            tt.Show();
        }
    }
}
