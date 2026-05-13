using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechMarcelino.Data;

namespace TechMarcelino.Views
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // 1. Coleta dos dados digitados
            string nomeDigitado = txtNome.Text;
            string telDigitado = txtTelefone.Text;
            string cpfDigitado = txtCPF.Text;

            // 2. Validação básica
            if (nomeDigitado == "" || cpfDigitado == "")
            {
                MessageBox.Show("Preencha o Nome e o CPF!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Criando o objeto em memória usando o Construtor
            Cliente novoCliente = new Cliente(nomeDigitado, telDigitado, cpfDigitado);

            // 4. SALVANDO NA LISTA GLOBAL (Nossa memória estática)
            MemoriaTemporaria.Clientes.Add(novoCliente);

            MessageBox.Show($"Cliente {novoCliente.Nome} salvo na memória com sucesso!", "TechFix");

            // 5. Limpa a tela para o próximo cadastro
            txtNome.Clear();
            txtTelefone.Clear();
            txtCPF.Clear();
            txtNome.Focus();
        }
    }
}
