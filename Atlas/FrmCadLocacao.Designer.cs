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
            txtRetorno = new TextBox();
            txtSaida = new TextBox();
            cmbTipoLocacao = new ComboBox();
            locacaoDTOBindingSource = new BindingSource(components);
            pessoaDTOBindingSource = new BindingSource(components);
            cmbLocatario = new ComboBox();
            cmbCondutor = new ComboBox();
            btnCadastrarLocacao = new Button();
            cmbAutomovel = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)locacaoDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pessoaDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblCondutor
            // 
            lblCondutor.AutoSize = true;
            lblCondutor.Location = new Point(118, 205);
            lblCondutor.Name = "lblCondutor";
            lblCondutor.Size = new Size(128, 20);
            lblCondutor.TabIndex = 35;
            lblCondutor.Text = "Insira o condutor: ";
            // 
            // lblAutomovel
            // 
            lblAutomovel.AutoSize = true;
            lblAutomovel.Location = new Point(407, 205);
            lblAutomovel.Name = "lblAutomovel";
            lblAutomovel.Size = new Size(135, 20);
            lblAutomovel.TabIndex = 34;
            lblAutomovel.Text = "Insira o automovel:";
            // 
            // lblLocatario
            // 
            lblLocatario.AutoSize = true;
            lblLocatario.Location = new Point(407, 136);
            lblLocatario.Name = "lblLocatario";
            lblLocatario.Size = new Size(123, 20);
            lblLocatario.TabIndex = 33;
            lblLocatario.Text = "Insira o locatário:";
            lblLocatario.Click += lblLocatario_Click;
            // 
            // lblTipoLocacao
            // 
            lblTipoLocacao.AutoSize = true;
            lblTipoLocacao.Location = new Point(118, 136);
            lblTipoLocacao.Name = "lblTipoLocacao";
            lblTipoLocacao.Size = new Size(183, 20);
            lblTipoLocacao.TabIndex = 32;
            lblTipoLocacao.Text = "Escolha o tipo da locação:";
            // 
            // lblDataRetorno
            // 
            lblDataRetorno.AutoSize = true;
            lblDataRetorno.Location = new Point(407, 70);
            lblDataRetorno.Name = "lblDataRetorno";
            lblDataRetorno.Size = new Size(167, 20);
            lblDataRetorno.TabIndex = 31;
            lblDataRetorno.Text = "Insira a data de retorno:";
            lblDataRetorno.Click += lblDataRetorno_Click;
            // 
            // lblDataSaida
            // 
            lblDataSaida.AutoSize = true;
            lblDataSaida.Location = new Point(118, 70);
            lblDataSaida.Name = "lblDataSaida";
            lblDataSaida.Size = new Size(153, 20);
            lblDataSaida.TabIndex = 30;
            lblDataSaida.Text = "Insira a data de saída:";
            lblDataSaida.Click += lblDataSaida_Click;
            // 
            // txtRetorno
            // 
            txtRetorno.Location = new Point(407, 93);
            txtRetorno.Name = "txtRetorno";
            txtRetorno.Size = new Size(268, 27);
            txtRetorno.TabIndex = 25;
            txtRetorno.TextChanged += txtRetorno_TextChanged;
            // 
            // txtSaida
            // 
            txtSaida.Location = new Point(118, 93);
            txtSaida.Name = "txtSaida";
            txtSaida.Size = new Size(268, 27);
            txtSaida.TabIndex = 24;
            txtSaida.TextChanged += txtSaida_TextChanged;
            // 
            // cmbTipoLocacao
            // 
            cmbTipoLocacao.FormattingEnabled = true;
            cmbTipoLocacao.Items.AddRange(new object[] { "Diária", "Contrato" });
            cmbTipoLocacao.Location = new Point(118, 158);
            cmbTipoLocacao.Name = "cmbTipoLocacao";
            cmbTipoLocacao.Size = new Size(268, 28);
            cmbTipoLocacao.TabIndex = 36;
            cmbTipoLocacao.SelectedIndexChanged += cmbTipoLocacao_SelectedIndexChanged;
            // 
            // locacaoDTOBindingSource
            // 
            locacaoDTOBindingSource.DataSource = typeof(Aplicacao.DTO.LocacaoDTO);
            // 
            // pessoaDTOBindingSource
            // 
            pessoaDTOBindingSource.DataSource = typeof(Aplicacao.DTO.PessoaDTO);
            // 
            // cmbLocatario
            // 
            cmbLocatario.FormattingEnabled = true;
            cmbLocatario.Items.AddRange(new object[] { "Diária", "Contrato" });
            cmbLocatario.Location = new Point(407, 158);
            cmbLocatario.Name = "cmbLocatario";
            cmbLocatario.Size = new Size(268, 28);
            cmbLocatario.TabIndex = 37;
            cmbLocatario.SelectedIndexChanged += cmbLocatario_SelectedIndexChanged;
            // 
            // cmbCondutor
            // 
            cmbCondutor.FormattingEnabled = true;
            cmbCondutor.Items.AddRange(new object[] { "Diária", "Contrato" });
            cmbCondutor.Location = new Point(118, 228);
            cmbCondutor.Name = "cmbCondutor";
            cmbCondutor.Size = new Size(268, 28);
            cmbCondutor.TabIndex = 38;
            cmbCondutor.SelectedIndexChanged += cmbCondutor_SelectedIndexChanged;
            // 
            // btnCadastrarLocacao
            // 
            btnCadastrarLocacao.Location = new Point(282, 285);
            btnCadastrarLocacao.Name = "btnCadastrarLocacao";
            btnCadastrarLocacao.Size = new Size(233, 61);
            btnCadastrarLocacao.TabIndex = 39;
            btnCadastrarLocacao.Text = "Cadastrar Locação";
            btnCadastrarLocacao.UseVisualStyleBackColor = true;
            btnCadastrarLocacao.Click += btnCadastrarLocacao_Click;
            // 
            // cmbAutomovel
            // 
            cmbAutomovel.FormattingEnabled = true;
            cmbAutomovel.Items.AddRange(new object[] { "Diária", "Contrato" });
            cmbAutomovel.Location = new Point(407, 228);
            cmbAutomovel.Name = "cmbAutomovel";
            cmbAutomovel.Size = new Size(268, 28);
            cmbAutomovel.TabIndex = 40;
            cmbAutomovel.SelectedIndexChanged += cmbAutomovel_SelectedIndexChanged;
            // 
            // FrmCadLocacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 451);
            Controls.Add(cmbAutomovel);
            Controls.Add(btnCadastrarLocacao);
            Controls.Add(cmbCondutor);
            Controls.Add(cmbLocatario);
            Controls.Add(cmbTipoLocacao);
            Controls.Add(lblCondutor);
            Controls.Add(lblAutomovel);
            Controls.Add(lblLocatario);
            Controls.Add(lblTipoLocacao);
            Controls.Add(lblDataRetorno);
            Controls.Add(lblDataSaida);
            Controls.Add(txtRetorno);
            Controls.Add(txtSaida);
            Name = "FrmCadLocacao";
            Text = "FrmCadLocacao";
            Load += FrmCadLocacao_Load;
            ((System.ComponentModel.ISupportInitialize)locacaoDTOBindingSource).EndInit();
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
        private TextBox txtRetorno;
        private TextBox txtSaida;
        private ComboBox cmbTipoLocacao;
        private BindingSource pessoaDTOBindingSource;
        private BindingSource locacaoDTOBindingSource;
        private ComboBox cmbLocatario;
        private ComboBox cmbCondutor;
        private Button btnCadastrarLocacao;
        private ComboBox cmbAutomovel;
    }
}