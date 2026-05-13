using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechMarcelino.Models;
using TechMarcelino.Views;

namespace TechMarcelino.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void btnNovoCliente_Click_1(object sender, EventArgs e)
        {
            frmCadastroCliente tela = new frmCadastroCliente();
            tela.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListarClientes tela = new frmListarClientes();
            tela.ShowDialog();
        }
    }

}

