namespace Projeto_ATLAS___4LIONS.Forms
{
    partial class FrmCadAutomovel
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
            lblRenavam = new Label();
            lblCnpj = new Label();
            lblChassi = new Label();
            lblCor = new Label();
            lblPlaca = new Label();
            lblModelo = new Label();
            txtCnpj = new TextBox();
            txtCpf = new TextBox();
            txtDataNascimento = new TextBox();
            txtContato = new TextBox();
            txtEmail = new TextBox();
            textNome = new TextBox();
            SuspendLayout();
            // 
            // lblRenavam
            // 
            lblRenavam.AutoSize = true;
            lblRenavam.Location = new Point(122, 268);
            lblRenavam.Name = "lblRenavam";
            lblRenavam.Size = new Size(193, 20);
            lblRenavam.TabIndex = 23;
            lblRenavam.Text = "Insira o renavam (opcional):";
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Location = new Point(411, 268);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(264, 20);
            lblCnpj.TabIndex = 22;
            lblCnpj.Text = "Insira o CPNJ (caso for pessoa jurídica)";
            // 
            // lblChassi
            // 
            lblChassi.AutoSize = true;
            lblChassi.Location = new Point(411, 199);
            lblChassi.Name = "lblChassi";
            lblChassi.Size = new Size(103, 20);
            lblChassi.TabIndex = 21;
            lblChassi.Text = "Insira o chassi:";
            lblChassi.Click += lblChassi_Click;
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Location = new Point(122, 199);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(84, 20);
            lblCor.TabIndex = 20;
            lblCor.Text = "Insira a cor:";
            lblCor.Click += lblCor_Click;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(411, 133);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(99, 20);
            lblPlaca.TabIndex = 19;
            lblPlaca.Text = "Insira a placa:";
            lblPlaca.Click += lblPlaca_Click;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(122, 133);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(213, 20);
            lblModelo.TabIndex = 18;
            lblModelo.Text = "Insira o modelo do automóvel:";
            lblModelo.Click += lblModelo_Click;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(411, 291);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(268, 27);
            txtCnpj.TabIndex = 17;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(122, 291);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(268, 27);
            txtCpf.TabIndex = 16;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(411, 222);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(268, 27);
            txtDataNascimento.TabIndex = 15;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(122, 222);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(268, 27);
            txtContato.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(411, 156);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 27);
            txtEmail.TabIndex = 13;
            // 
            // textNome
            // 
            textNome.Location = new Point(122, 156);
            textNome.Name = "textNome";
            textNome.Size = new Size(268, 27);
            textNome.TabIndex = 12;
            // 
            // FrmCadAutomovel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRenavam);
            Controls.Add(lblCnpj);
            Controls.Add(lblChassi);
            Controls.Add(lblCor);
            Controls.Add(lblPlaca);
            Controls.Add(lblModelo);
            Controls.Add(txtCnpj);
            Controls.Add(txtCpf);
            Controls.Add(txtDataNascimento);
            Controls.Add(txtContato);
            Controls.Add(txtEmail);
            Controls.Add(textNome);
            Name = "FrmCadAutomovel";
            Text = "FrmCadAutomovel";
            Load += FrmCadAutomovel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRenavam;
        private Label lblCnpj;
        private Label lblChassi;
        private Label lblCor;
        private Label lblPlaca;
        private Label lblModelo;
        private TextBox txtCnpj;
        private TextBox txtCpf;
        private TextBox txtDataNascimento;
        private TextBox txtContato;
        private TextBox txtEmail;
        private TextBox textNome;
    }
}