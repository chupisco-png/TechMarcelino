namespace TechMarcelino.Views
{
    partial class frmCadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalvar = new Button();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtCPF = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(213, 177);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtNome
            // 
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Location = new Point(183, 54);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(138, 23);
            txtNome.TabIndex = 1;
            txtNome.Text = "Digite Aqui";
            // 
            // txtTelefone
            // 
            txtTelefone.Cursor = Cursors.IBeam;
            txtTelefone.Location = new Point(183, 96);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(138, 23);
            txtTelefone.TabIndex = 2;
            txtTelefone.Text = "Digite Aqui";
            // 
            // txtCPF
            // 
            txtCPF.Cursor = Cursors.IBeam;
            txtCPF.Location = new Point(183, 134);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(138, 23);
            txtCPF.TabIndex = 3;
            txtCPF.Text = "Digite Aqui";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 62);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 99);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 142);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "CPF:";
            // 
            // frmCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCPF);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(btnSalvar);
            Name = "frmCadastroCliente";
            Text = "frmCadastroCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtCPF;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}