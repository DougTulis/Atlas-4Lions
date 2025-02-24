namespace Projeto_ATLAS___4LIONS.Forms
{
    partial class FrmCadPessoas
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
            textNome = new TextBox();
            txtEmail = new TextBox();
            txtContato = new TextBox();
            txtDataNascimento = new TextBox();
            lblNome = new Label();
            lblEmail = new Label();
            lblContato = new Label();
            lblDataNascimento = new Label();
            btnCadastrarPessoa = new Button();
            cbmTipoPessoa = new ComboBox();
            lblTipoPessoa = new Label();
            txtNumeroDocumento = new TextBox();
            lblNumeroDocumento = new Label();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Location = new Point(138, 120);
            textNome.Name = "textNome";
            textNome.Size = new Size(268, 27);
            textNome.TabIndex = 0;
            textNome.TextChanged += textNome_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(427, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 27);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(138, 187);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(268, 27);
            txtContato.TabIndex = 2;
            txtContato.TextChanged += txtContato_TextChanged;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(427, 187);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(268, 27);
            txtDataNascimento.TabIndex = 3;
            txtDataNascimento.TextChanged += txtDataNascimento_TextChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(138, 98);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(170, 20);
            lblNome.TabIndex = 6;
            lblNome.Text = "Insira o nome completo:";
            lblNome.Click += lblNome_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(427, 98);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(101, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Insira o email:";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(138, 164);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(191, 20);
            lblContato.TabIndex = 8;
            lblContato.Text = "Insira o numero de contato:";
            lblContato.Click += lblContato_Click;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(427, 164);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(228, 20);
            lblDataNascimento.TabIndex = 9;
            lblDataNascimento.Text = "Data nascimento/Data fundação:";
            lblDataNascimento.Click += lblDataNascimento_Click;
            // 
            // btnCadastrarPessoa
            // 
            btnCadastrarPessoa.Location = new Point(295, 332);
            btnCadastrarPessoa.Name = "btnCadastrarPessoa";
            btnCadastrarPessoa.Size = new Size(233, 61);
            btnCadastrarPessoa.TabIndex = 12;
            btnCadastrarPessoa.Text = "Cadastrar Pessoa";
            btnCadastrarPessoa.UseVisualStyleBackColor = true;
            btnCadastrarPessoa.Click += btnCadastrarPessoa_Click;
            // 
            // cbmTipoPessoa
            // 
            cbmTipoPessoa.FormattingEnabled = true;
            cbmTipoPessoa.Location = new Point(138, 256);
            cbmTipoPessoa.Name = "cbmTipoPessoa";
            cbmTipoPessoa.Size = new Size(268, 28);
            cbmTipoPessoa.TabIndex = 13;
            cbmTipoPessoa.SelectedIndexChanged += cbmTipoPessoa_SelectedIndexChanged;
            // 
            // lblTipoPessoa
            // 
            lblTipoPessoa.AutoSize = true;
            lblTipoPessoa.Location = new Point(138, 233);
            lblTipoPessoa.Name = "lblTipoPessoa";
            lblTipoPessoa.Size = new Size(177, 20);
            lblTipoPessoa.TabIndex = 14;
            lblTipoPessoa.Text = "Escolha o tipo de pessoa:";
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(427, 257);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(268, 27);
            txtNumeroDocumento.TabIndex = 15;
            txtNumeroDocumento.TextChanged += txtNumeroDocumento_TextChanged;
            // 
            // lblNumeroDocumento
            // 
            lblNumeroDocumento.AutoSize = true;
            lblNumeroDocumento.Location = new Point(427, 233);
            lblNumeroDocumento.Name = "lblNumeroDocumento";
            lblNumeroDocumento.Size = new Size(220, 20);
            lblNumeroDocumento.TabIndex = 16;
            lblNumeroDocumento.Text = "Informe o numero do CNPJ/CPF:";
            lblNumeroDocumento.Click += lblNumeroDocumento_Click;
            // 
            // FrmCadPessoas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1098, 647);
            Controls.Add(lblNumeroDocumento);
            Controls.Add(txtNumeroDocumento);
            Controls.Add(lblTipoPessoa);
            Controls.Add(cbmTipoPessoa);
            Controls.Add(btnCadastrarPessoa);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblContato);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(txtDataNascimento);
            Controls.Add(txtContato);
            Controls.Add(txtEmail);
            Controls.Add(textNome);
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.NoControl;
            Name = "FrmCadPessoas";
            Text = "FrmCadPessoas";
            Load += FrmCadPessoas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNome;
        private TextBox txtEmail;
        private TextBox txtContato;
        private TextBox txtDataNascimento;
        private Label lblNome;
        private Label lblEmail;
        private Label lblContato;
        private Label lblDataNascimento;
        private Button btnCadastrarPessoa;
        private ComboBox cbmTipoPessoa;
        private Label lblTipoPessoa;
        private TextBox txtNumeroDocumento;
        private Label lblNumeroDocumento;
    }
}