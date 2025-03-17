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
            textNome.Location = new Point(121, 90);
            textNome.Margin = new Padding(3, 2, 3, 2);
            textNome.Name = "textNome";
            textNome.Size = new Size(235, 23);
            textNome.TabIndex = 0;
            textNome.TextChanged += textNome_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(374, 90);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(235, 23);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(121, 140);
            txtContato.Margin = new Padding(3, 2, 3, 2);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(235, 23);
            txtContato.TabIndex = 2;
            txtContato.TextChanged += txtContato_TextChanged;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(374, 140);
            txtDataNascimento.Margin = new Padding(3, 2, 3, 2);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(235, 23);
            txtDataNascimento.TabIndex = 3;
            txtDataNascimento.TextChanged += txtDataNascimento_TextChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(121, 74);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(136, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Insira o nome completo:";
            lblNome.Click += lblNome_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(374, 74);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(80, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Insira o email:";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(121, 123);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(153, 15);
            lblContato.TabIndex = 8;
            lblContato.Text = "Insira o numero de contato:";
            lblContato.Click += lblContato_Click;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(374, 123);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(181, 15);
            lblDataNascimento.TabIndex = 9;
            lblDataNascimento.Text = "Data nascimento/Data fundação:";
            lblDataNascimento.Click += lblDataNascimento_Click;
            // 
            // btnCadastrarPessoa
            // 
            btnCadastrarPessoa.Location = new Point(258, 249);
            btnCadastrarPessoa.Margin = new Padding(3, 2, 3, 2);
            btnCadastrarPessoa.Name = "btnCadastrarPessoa";
            btnCadastrarPessoa.Size = new Size(204, 46);
            btnCadastrarPessoa.TabIndex = 12;
            btnCadastrarPessoa.Text = "Cadastrar Pessoa";
            btnCadastrarPessoa.UseVisualStyleBackColor = true;
            btnCadastrarPessoa.Click += btnCadastrarPessoa_Click;
            // 
            // cbmTipoPessoa
            // 
            cbmTipoPessoa.FormattingEnabled = true;
            cbmTipoPessoa.Location = new Point(121, 192);
            cbmTipoPessoa.Margin = new Padding(3, 2, 3, 2);
            cbmTipoPessoa.Name = "cbmTipoPessoa";
            cbmTipoPessoa.Size = new Size(235, 23);
            cbmTipoPessoa.TabIndex = 13;
            cbmTipoPessoa.SelectedIndexChanged += cbmTipoPessoa_SelectedIndexChanged;
            // 
            // lblTipoPessoa
            // 
            lblTipoPessoa.AutoSize = true;
            lblTipoPessoa.Location = new Point(121, 175);
            lblTipoPessoa.Name = "lblTipoPessoa";
            lblTipoPessoa.Size = new Size(139, 15);
            lblTipoPessoa.TabIndex = 14;
            lblTipoPessoa.Text = "Escolha o tipo de pessoa:";
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(374, 193);
            txtNumeroDocumento.Margin = new Padding(3, 2, 3, 2);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(235, 23);
            txtNumeroDocumento.TabIndex = 15;
            txtNumeroDocumento.TextChanged += txtNumeroDocumento_TextChanged;
            // 
            // lblNumeroDocumento
            // 
            lblNumeroDocumento.AutoSize = true;
            lblNumeroDocumento.Location = new Point(374, 175);
            lblNumeroDocumento.Name = "lblNumeroDocumento";
            lblNumeroDocumento.Size = new Size(180, 15);
            lblNumeroDocumento.TabIndex = 16;
            lblNumeroDocumento.Text = "Informe o numero do CNPJ/CPF:";
            lblNumeroDocumento.Click += lblNumeroDocumento_Click;
            // 
            // FrmCadPessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(961, 485);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCadPessoas";
            Text = "FrmCadPessoas";
            FormClosing += FrmCadPessoas_FormClosing;
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