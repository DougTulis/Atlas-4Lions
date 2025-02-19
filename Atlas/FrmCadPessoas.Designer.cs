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
            txtCpf = new TextBox();
            txtCnpj = new TextBox();
            lblNome = new Label();
            lblEmail = new Label();
            lblContato = new Label();
            lblDataNascimento = new Label();
            lblCnpj = new Label();
            lblCpf = new Label();
            btnCadastrarPessoa = new Button();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Location = new Point(103, 125);
            textNome.Name = "textNome";
            textNome.Size = new Size(268, 27);
            textNome.TabIndex = 0;
            textNome.TextChanged += textNome_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(392, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 27);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(103, 192);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(268, 27);
            txtContato.TabIndex = 2;
            txtContato.TextChanged += txtContato_TextChanged;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(392, 192);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(268, 27);
            txtDataNascimento.TabIndex = 3;
            txtDataNascimento.TextChanged += txtDataNascimento_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(103, 261);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(268, 27);
            txtCpf.TabIndex = 4;
            txtCpf.TextChanged += txtCpf_TextChanged;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(392, 261);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(268, 27);
            txtCnpj.TabIndex = 5;
            txtCnpj.TextChanged += txtCnpj_TextChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(103, 103);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(170, 20);
            lblNome.TabIndex = 6;
            lblNome.Text = "Insira o nome completo:";
            lblNome.Click += lblNome_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(392, 103);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(101, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Insira o email:";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(103, 169);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(191, 20);
            lblContato.TabIndex = 8;
            lblContato.Text = "Insira o numero de contato:";
            lblContato.Click += lblContato_Click;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(392, 169);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(194, 20);
            lblDataNascimento.TabIndex = 9;
            lblDataNascimento.Text = "Insira a data de nascimento:";
            lblDataNascimento.Click += lblDataNascimento_Click;
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Location = new Point(392, 237);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(263, 20);
            lblCnpj.TabIndex = 10;
            lblCnpj.Text = "Insira o CNPJ (caso for pessoa jurídica)";
            lblCnpj.Click += lblCnpj_Click;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(103, 237);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(240, 20);
            lblCpf.TabIndex = 11;
            lblCpf.Text = "Insira o CPF (caso for pessoa física)";
            // 
            // btnCadastrarPessoa
            // 
            btnCadastrarPessoa.Location = new Point(267, 325);
            btnCadastrarPessoa.Name = "btnCadastrarPessoa";
            btnCadastrarPessoa.Size = new Size(233, 61);
            btnCadastrarPessoa.TabIndex = 12;
            btnCadastrarPessoa.Text = "Cadastrar Pessoa";
            btnCadastrarPessoa.UseVisualStyleBackColor = true;
            btnCadastrarPessoa.Click += btnCadastrarPessoa_Click;
            // 
            // FrmCadPessoas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1098, 647);
            Controls.Add(btnCadastrarPessoa);
            Controls.Add(lblCpf);
            Controls.Add(lblCnpj);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblContato);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(txtCnpj);
            Controls.Add(txtCpf);
            Controls.Add(txtDataNascimento);
            Controls.Add(txtContato);
            Controls.Add(txtEmail);
            Controls.Add(textNome);
            FormBorderStyle = FormBorderStyle.None;
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
        private TextBox txtCpf;
        private TextBox txtCnpj;
        private Label lblNome;
        private Label lblEmail;
        private Label lblContato;
        private Label lblDataNascimento;
        private Label lblCnpj;
        private Label lblCpf;
        private Button btnCadastrarPessoa;
    }
}