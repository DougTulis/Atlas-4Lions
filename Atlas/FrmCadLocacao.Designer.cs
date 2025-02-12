namespace Projeto_ATLAS___4LIONS.Forms
{
    partial class FrmCadLocacao
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
            components = new System.ComponentModel.Container();
            lblCondutor = new Label();
            lblAutomovel = new Label();
            lblLocatario = new Label();
            lblTipoLocacao = new Label();
            lblDataRetorno = new Label();
            lblDataSaida = new Label();
            txtCnpj = new TextBox();
            txtCpf = new TextBox();
            txtEmail = new TextBox();
            textNome = new TextBox();
            cmbTipoLocacao = new ComboBox();
            pessoaDTOBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pessoaDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblCondutor
            // 
            lblCondutor.AutoSize = true;
            lblCondutor.Location = new Point(107, 201);
            lblCondutor.Name = "lblCondutor";
            lblCondutor.Size = new Size(103, 15);
            lblCondutor.TabIndex = 35;
            lblCondutor.Text = "Insira o condutor: ";
            // 
            // lblAutomovel
            // 
            lblAutomovel.AutoSize = true;
            lblAutomovel.Location = new Point(360, 201);
            lblAutomovel.Name = "lblAutomovel";
            lblAutomovel.Size = new Size(108, 15);
            lblAutomovel.TabIndex = 34;
            lblAutomovel.Text = "Insira o automovel:";
            // 
            // lblLocatario
            // 
            lblLocatario.AutoSize = true;
            lblLocatario.Location = new Point(360, 149);
            lblLocatario.Name = "lblLocatario";
            lblLocatario.Size = new Size(97, 15);
            lblLocatario.TabIndex = 33;
            lblLocatario.Text = "Insira o locatário:";
            lblLocatario.Click += lblLocatario_Click;
            // 
            // lblTipoLocacao
            // 
            lblTipoLocacao.AutoSize = true;
            lblTipoLocacao.Location = new Point(107, 149);
            lblTipoLocacao.Name = "lblTipoLocacao";
            lblTipoLocacao.Size = new Size(144, 15);
            lblTipoLocacao.TabIndex = 32;
            lblTipoLocacao.Text = "Escolha o tipo da locação:";
            // 
            // lblDataRetorno
            // 
            lblDataRetorno.AutoSize = true;
            lblDataRetorno.Location = new Point(360, 100);
            lblDataRetorno.Name = "lblDataRetorno";
            lblDataRetorno.Size = new Size(131, 15);
            lblDataRetorno.TabIndex = 31;
            lblDataRetorno.Text = "Insira a data de retorno:";
            lblDataRetorno.Click += lblDataRetorno_Click;
            // 
            // lblDataSaida
            // 
            lblDataSaida.AutoSize = true;
            lblDataSaida.Location = new Point(107, 100);
            lblDataSaida.Name = "lblDataSaida";
            lblDataSaida.Size = new Size(119, 15);
            lblDataSaida.TabIndex = 30;
            lblDataSaida.Text = "Insira a data de saída:";
            lblDataSaida.Click += lblDataSaida_Click;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(360, 218);
            txtCnpj.Margin = new Padding(3, 2, 3, 2);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(235, 23);
            txtCnpj.TabIndex = 29;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(107, 218);
            txtCpf.Margin = new Padding(3, 2, 3, 2);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(235, 23);
            txtCpf.TabIndex = 28;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(360, 117);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(235, 23);
            txtEmail.TabIndex = 25;
            // 
            // textNome
            // 
            textNome.Location = new Point(107, 117);
            textNome.Margin = new Padding(3, 2, 3, 2);
            textNome.Name = "textNome";
            textNome.Size = new Size(235, 23);
            textNome.TabIndex = 24;
            // 
            // cmbTipoLocacao
            // 
            cmbTipoLocacao.FormattingEnabled = true;
            cmbTipoLocacao.Location = new Point(107, 166);
            cmbTipoLocacao.Margin = new Padding(3, 2, 3, 2);
            cmbTipoLocacao.Name = "cmbTipoLocacao";
            cmbTipoLocacao.Size = new Size(235, 23);
            cmbTipoLocacao.TabIndex = 36;
            cmbTipoLocacao.SelectedIndexChanged += cmbTipoLocacao_SelectedIndexChanged;
            // 
            // pessoaDTOBindingSource
            // 
            pessoaDTOBindingSource.DataSource = typeof(Aplicacao.DTO.PessoaDTO);
            // 
            // FrmCadLocacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(700, 338);
            Controls.Add(cmbTipoLocacao);
            Controls.Add(lblCondutor);
            Controls.Add(lblAutomovel);
            Controls.Add(lblLocatario);
            Controls.Add(lblTipoLocacao);
            Controls.Add(lblDataRetorno);
            Controls.Add(lblDataSaida);
            Controls.Add(txtCnpj);
            Controls.Add(txtCpf);
            Controls.Add(txtEmail);
            Controls.Add(textNome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCadLocacao";
            Text = "FrmCadLocacao";
            Load += FrmCadLocacao_Load;
            ((System.ComponentModel.ISupportInitialize)pessoaDTOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCondutor;
        private Label lblAutomovel;
        private Label lblLocatario;
        private Label lblTipoLocacao;
        private Label lblDataRetorno;
        private Label lblDataSaida;
        private TextBox txtCnpj;
        private TextBox txtCpf;
        private TextBox txtEmail;
        private TextBox textNome;
        private ComboBox cmbTipoLocacao;
        private BindingSource pessoaDTOBindingSource;
    }
}