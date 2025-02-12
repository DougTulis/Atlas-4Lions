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
            textNome.Location = new Point(90, 94);
            textNome.Margin = new Padding(3, 2, 3, 2);
            textNome.Name = "textNome";
            textNome.Size = new Size(235, 23);
            textNome.TabIndex = 0;
            textNome.TextChanged += textNome_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(343, 94);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(235, 23);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(90, 144);
            txtContato.Margin = new Padding(3, 2, 3, 2);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(235, 23);
            txtContato.TabIndex = 2;
            txtContato.TextChanged += txtContato_TextChanged;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(343, 144);
            txtDataNascimento.Margin = new Padding(3, 2, 3, 2);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(235, 23);
            txtDataNascimento.TabIndex = 3;
            txtDataNascimento.TextChanged += txtDataNascimento_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(90, 196);
            txtCpf.Margin = new Padding(3, 2, 3, 2);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(235, 23);
            txtCpf.TabIndex = 4;
            txtCpf.TextChanged += txtCpf_TextChanged;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(343, 196);
            txtCnpj.Margin = new Padding(3, 2, 3, 2);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(235, 23);
            txtCnpj.TabIndex = 5;
            txtCnpj.TextChanged += txtCnpj_TextChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(90, 77);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(136, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Insira o nome completo:";
            lblNome.Click += lblNome_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(343, 77);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(80, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Insira o email:";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(90, 127);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(153, 15);
            lblContato.TabIndex = 8;
            lblContato.Text = "Insira o numero de contato:";
            lblContato.Click += lblContato_Click;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(343, 127);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(154, 15);
            lblDataNascimento.TabIndex = 9;
            lblDataNascimento.Text = "Insira a data de nascimento:";
            lblDataNascimento.Click += lblDataNascimento_Click;
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Location = new Point(343, 178);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(209, 15);
            lblCnpj.TabIndex = 10;
            lblCnpj.Text = "Insira o CNPJ (caso for pessoa jurídica)";
            lblCnpj.Click += lblCnpj_Click;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(90, 178);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(191, 15);
            lblCpf.TabIndex = 11;
            lblCpf.Text = "Insira o CPF (caso for pessoa física)";
            // 
            // btnCadastrarPessoa
            // 
            btnCadastrarPessoa.Location = new Point(234, 244);
            btnCadastrarPessoa.Margin = new Padding(3, 2, 3, 2);
            btnCadastrarPessoa.Name = "btnCadastrarPessoa";
            btnCadastrarPessoa.Size = new Size(204, 46);
            btnCadastrarPessoa.TabIndex = 12;
            btnCadastrarPessoa.Text = "Cadastrar Pessoa";
            btnCadastrarPessoa.UseVisualStyleBackColor = true;
            btnCadastrarPessoa.Click += btnCadastrarPessoa_Click;
            // 
            // FrmCadPessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(700, 338);
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
            Margin = new Padding(3, 2, 3, 2);
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