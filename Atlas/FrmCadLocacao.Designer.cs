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
            cmbParcelas = new ComboBox();
            lblParcelas = new Label();
            label1 = new Label();
            txtPreco = new TextBox();
            ((System.ComponentModel.ISupportInitialize)locacaoDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pessoaDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblCondutor
            // 
            lblCondutor.AutoSize = true;
            lblCondutor.Location = new Point(109, 72);
            lblCondutor.Name = "lblCondutor";
            lblCondutor.Size = new Size(103, 15);
            lblCondutor.TabIndex = 35;
            lblCondutor.Text = "Insira o condutor: ";
            // 
            // lblAutomovel
            // 
            lblAutomovel.AutoSize = true;
            lblAutomovel.Location = new Point(109, 126);
            lblAutomovel.Name = "lblAutomovel";
            lblAutomovel.Size = new Size(108, 15);
            lblAutomovel.TabIndex = 34;
            lblAutomovel.Text = "Insira o automovel:";
            // 
            // lblLocatario
            // 
            lblLocatario.AutoSize = true;
            lblLocatario.Location = new Point(362, 73);
            lblLocatario.Name = "lblLocatario";
            lblLocatario.Size = new Size(97, 15);
            lblLocatario.TabIndex = 33;
            lblLocatario.Text = "Insira o locatário:";
            lblLocatario.Click += lblLocatario_Click;
            // 
            // lblTipoLocacao
            // 
            lblTipoLocacao.AutoSize = true;
            lblTipoLocacao.Location = new Point(362, 176);
            lblTipoLocacao.Name = "lblTipoLocacao";
            lblTipoLocacao.Size = new Size(144, 15);
            lblTipoLocacao.TabIndex = 32;
            lblTipoLocacao.Text = "Escolha o tipo da locação:";
            // 
            // lblDataRetorno
            // 
            lblDataRetorno.AutoSize = true;
            lblDataRetorno.Location = new Point(362, 23);
            lblDataRetorno.Name = "lblDataRetorno";
            lblDataRetorno.Size = new Size(131, 15);
            lblDataRetorno.TabIndex = 31;
            lblDataRetorno.Text = "Insira a data de retorno:";
            lblDataRetorno.Click += lblDataRetorno_Click;
            // 
            // lblDataSaida
            // 
            lblDataSaida.AutoSize = true;
            lblDataSaida.Location = new Point(109, 23);
            lblDataSaida.Name = "lblDataSaida";
            lblDataSaida.Size = new Size(119, 15);
            lblDataSaida.TabIndex = 30;
            lblDataSaida.Text = "Insira a data de saída:";
            lblDataSaida.Click += lblDataSaida_Click;
            // 
            // txtRetorno
            // 
            txtRetorno.Location = new Point(362, 41);
            txtRetorno.Margin = new Padding(3, 2, 3, 2);
            txtRetorno.Name = "txtRetorno";
            txtRetorno.Size = new Size(235, 23);
            txtRetorno.TabIndex = 25;
            txtRetorno.TextChanged += txtRetorno_TextChanged;
            // 
            // txtSaida
            // 
            txtSaida.Location = new Point(109, 41);
            txtSaida.Margin = new Padding(3, 2, 3, 2);
            txtSaida.Name = "txtSaida";
            txtSaida.Size = new Size(235, 23);
            txtSaida.TabIndex = 24;
            txtSaida.TextChanged += txtSaida_TextChanged;
            // 
            // cmbTipoLocacao
            // 
            cmbTipoLocacao.FormattingEnabled = true;
            cmbTipoLocacao.Items.AddRange(new object[] { "Diária", "Contrato" });
            cmbTipoLocacao.Location = new Point(362, 193);
            cmbTipoLocacao.Margin = new Padding(3, 2, 3, 2);
            cmbTipoLocacao.Name = "cmbTipoLocacao";
            cmbTipoLocacao.Size = new Size(235, 23);
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
            cmbLocatario.Location = new Point(362, 89);
            cmbLocatario.Margin = new Padding(3, 2, 3, 2);
            cmbLocatario.Name = "cmbLocatario";
            cmbLocatario.Size = new Size(235, 23);
            cmbLocatario.TabIndex = 37;
            cmbLocatario.SelectedIndexChanged += cmbLocatario_SelectedIndexChanged;
            // 
            // cmbCondutor
            // 
            cmbCondutor.FormattingEnabled = true;
            cmbCondutor.Items.AddRange(new object[] { "Diária", "Contrato" });
            cmbCondutor.Location = new Point(109, 89);
            cmbCondutor.Margin = new Padding(3, 2, 3, 2);
            cmbCondutor.Name = "cmbCondutor";
            cmbCondutor.Size = new Size(235, 23);
            cmbCondutor.TabIndex = 38;
            cmbCondutor.SelectedIndexChanged += cmbCondutor_SelectedIndexChanged;
            // 
            // btnCadastrarLocacao
            // 
            btnCadastrarLocacao.Location = new Point(249, 258);
            btnCadastrarLocacao.Margin = new Padding(3, 2, 3, 2);
            btnCadastrarLocacao.Name = "btnCadastrarLocacao";
            btnCadastrarLocacao.Size = new Size(204, 46);
            btnCadastrarLocacao.TabIndex = 39;
            btnCadastrarLocacao.Text = "Cadastrar Locação";
            btnCadastrarLocacao.UseVisualStyleBackColor = true;
            btnCadastrarLocacao.Click += btnCadastrarLocacao_Click;
            // 
            // cmbAutomovel
            // 
            cmbAutomovel.FormattingEnabled = true;
            cmbAutomovel.Items.AddRange(new object[] { "Diária", "Contrato" });
            cmbAutomovel.Location = new Point(109, 143);
            cmbAutomovel.Margin = new Padding(3, 2, 3, 2);
            cmbAutomovel.Name = "cmbAutomovel";
            cmbAutomovel.Size = new Size(235, 23);
            cmbAutomovel.TabIndex = 40;
            cmbAutomovel.SelectedIndexChanged += cmbAutomovel_SelectedIndexChanged;
            // 
            // cmbParcelas
            // 
            cmbParcelas.FormattingEnabled = true;
            cmbParcelas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbParcelas.Location = new Point(109, 193);
            cmbParcelas.Margin = new Padding(3, 2, 3, 2);
            cmbParcelas.Name = "cmbParcelas";
            cmbParcelas.Size = new Size(235, 23);
            cmbParcelas.TabIndex = 42;
            cmbParcelas.SelectedIndexChanged += cmbParcelas_SelectedIndexChanged;
            // 
            // lblParcelas
            // 
            lblParcelas.AutoSize = true;
            lblParcelas.Location = new Point(109, 176);
            lblParcelas.Name = "lblParcelas";
            lblParcelas.Size = new Size(184, 15);
            lblParcelas.TabIndex = 41;
            lblParcelas.Text = "Escolha a quantidade de parcelas:";
            lblParcelas.Click += lblParcelas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 126);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 43;
            label1.Text = "Preço da diária";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(362, 143);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(235, 23);
            txtPreco.TabIndex = 44;
            txtPreco.TextChanged += txtPreco_TextChanged;
            // 
            // FrmCadLocacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(961, 485);
            Controls.Add(txtPreco);
            Controls.Add(label1);
            Controls.Add(cmbParcelas);
            Controls.Add(lblParcelas);
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
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private ComboBox cmbParcelas;
        private Label lblParcelas;
        private Label label1;
        private TextBox txtPreco;
    }
}