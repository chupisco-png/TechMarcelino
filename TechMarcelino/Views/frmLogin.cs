using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechMarcelino.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (usuario == "admin" && senha == "1234")
            {
                this.Hide();

                frmPrincipal telaPrincipal = new frmPrincipal();
                telaPrincipal.FormClosed += (s, args) => this.Close();

                telaPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha Incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Clear();
                txtSenha.Focus();
            }
        }
    }
}

