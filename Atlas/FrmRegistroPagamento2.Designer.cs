namespace Projeto_ATLAS___4LIONS.Forms
{
    partial class FrmRegistroPagamento2
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
            dgvParcelasPendFinEscolhida = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            sequencia = new DataGridViewTextBoxColumn();
            vencimento = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            lblSequenciaParcela = new Label();
            txtParcelaSelecionada = new TextBox();
            txtValorPago = new TextBox();
            lblValorPago = new Label();
            txtDataPagamento = new TextBox();
            lblDataPagamento = new Label();
            lblEspeciePagamento = new Label();
            cmbEspeciePagamento = new ComboBox();
            btnRegistrarPagamento = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvParcelasPendFinEscolhida).BeginInit();
            SuspendLayout();
            // 
            // dgvParcelasPendFinEscolhida
            // 
            dgvParcelasPendFinEscolhida.AllowUserToAddRows = false;
            dgvParcelasPendFinEscolhida.AllowUserToDeleteRows = false;
            dgvParcelasPendFinEscolhida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParcelasPendFinEscolhida.Columns.AddRange(new DataGridViewColumn[] { Id, sequencia, vencimento, valor });
            dgvParcelasPendFinEscolhida.Location = new Point(3, 1);
            dgvParcelasPendFinEscolhida.Name = "dgvParcelasPendFinEscolhida";
            dgvParcelasPendFinEscolhida.ReadOnly = true;
            dgvParcelasPendFinEscolhida.RowHeadersWidth = 51;
            dgvParcelasPendFinEscolhida.Size = new Size(421, 409);
            dgvParcelasPendFinEscolhida.TabIndex = 0;
            dgvParcelasPendFinEscolhida.CellContentClick += dgvParcelasPendFinEscolhida_CellContentClick;
            dgvParcelasPendFinEscolhida.CellMouseClick += dgvParcelasPendFinEscolhida_CellMouseClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // sequencia
            // 
            sequencia.DataPropertyName = "Sequencia";
            sequencia.HeaderText = "Sequencia";
            sequencia.MinimumWidth = 6;
            sequencia.Name = "sequencia";
            sequencia.ReadOnly = true;
            sequencia.Width = 125;
            // 
            // vencimento
            // 
            vencimento.DataPropertyName = "DataVencimento";
            vencimento.HeaderText = "Vencimento";
            vencimento.MinimumWidth = 6;
            vencimento.Name = "vencimento";
            vencimento.ReadOnly = true;
            vencimento.Width = 125;
            // 
            // valor
            // 
            valor.DataPropertyName = "Valor";
            valor.HeaderText = "Valor";
            valor.MinimumWidth = 6;
            valor.Name = "valor";
            valor.ReadOnly = true;
            valor.Width = 125;
            // 
            // lblSequenciaParcela
            // 
            lblSequenciaParcela.AutoSize = true;
            lblSequenciaParcela.Location = new Point(442, 24);
            lblSequenciaParcela.Name = "lblSequenciaParcela";
            lblSequenciaParcela.Size = new Size(114, 15);
            lblSequenciaParcela.TabIndex = 1;
            lblSequenciaParcela.Text = "Parcela Selecionada:";
            lblSequenciaParcela.Click += lblSequenciaParcela_Click;
            // 
            // txtParcelaSelecionada
            // 
            txtParcelaSelecionada.Location = new Point(442, 42);
            txtParcelaSelecionada.Name = "txtParcelaSelecionada";
            txtParcelaSelecionada.ReadOnly = true;
            txtParcelaSelecionada.Size = new Size(126, 23);
            txtParcelaSelecionada.TabIndex = 2;
            txtParcelaSelecionada.TextChanged += txtParcelaSelecionada_TextChanged;
            // 
            // txtValorPago
            // 
            txtValorPago.Location = new Point(442, 93);
            txtValorPago.Name = "txtValorPago";
            txtValorPago.Size = new Size(126, 23);
            txtValorPago.TabIndex = 4;
            txtValorPago.TextChanged += txtValorPago_TextChanged;
            // 
            // lblValorPago
            // 
            lblValorPago.AutoSize = true;
            lblValorPago.Location = new Point(442, 75);
            lblValorPago.Name = "lblValorPago";
            lblValorPago.Size = new Size(121, 15);
            lblValorPago.TabIndex = 3;
            lblValorPago.Text = "Informe o valor pago:";
            lblValorPago.Click += lblValorPago_Click;
            // 
            // txtDataPagamento
            // 
            txtDataPagamento.Location = new Point(442, 145);
            txtDataPagamento.Name = "txtDataPagamento";
            txtDataPagamento.Size = new Size(126, 23);
            txtDataPagamento.TabIndex = 6;
            txtDataPagamento.TextChanged += txtDataPagamento_TextChanged;
            // 
            // lblDataPagamento
            // 
            lblDataPagamento.AutoSize = true;
            lblDataPagamento.Location = new Point(442, 127);
            lblDataPagamento.Name = "lblDataPagamento";
            lblDataPagamento.Size = new Size(167, 15);
            lblDataPagamento.TabIndex = 5;
            lblDataPagamento.Text = "Informe a data de pagamento:";
            lblDataPagamento.Click += lblDataPagamento_Click;
            // 
            // lblEspeciePagamento
            // 
            lblEspeciePagamento.AutoSize = true;
            lblEspeciePagamento.Location = new Point(442, 179);
            lblEspeciePagamento.Name = "lblEspeciePagamento";
            lblEspeciePagamento.Size = new Size(111, 15);
            lblEspeciePagamento.TabIndex = 7;
            lblEspeciePagamento.Text = "Selecione a espécie:";
            lblEspeciePagamento.Click += lblEspeciePagamento_Click;
            // 
            // cmbEspeciePagamento
            // 
            cmbEspeciePagamento.FormattingEnabled = true;
            cmbEspeciePagamento.Location = new Point(442, 197);
            cmbEspeciePagamento.Margin = new Padding(3, 2, 3, 2);
            cmbEspeciePagamento.Name = "cmbEspeciePagamento";
            cmbEspeciePagamento.Size = new Size(126, 23);
            cmbEspeciePagamento.TabIndex = 8;
            cmbEspeciePagamento.SelectedIndexChanged += cmbEspeciePagamento_SelectedIndexChanged;
            // 
            // btnRegistrarPagamento
            // 
            btnRegistrarPagamento.Location = new Point(442, 237);
            btnRegistrarPagamento.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarPagamento.Name = "btnRegistrarPagamento";
            btnRegistrarPagamento.Size = new Size(149, 33);
            btnRegistrarPagamento.TabIndex = 9;
            btnRegistrarPagamento.Text = "Registrar Pagamento";
            btnRegistrarPagamento.UseVisualStyleBackColor = true;
            btnRegistrarPagamento.Click += btnRegistrarPagamento_Click;
            // 
            // FrmRegistroPagamento2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(961, 485);
            Controls.Add(btnRegistrarPagamento);
            Controls.Add(cmbEspeciePagamento);
            Controls.Add(lblEspeciePagamento);
            Controls.Add(txtDataPagamento);
            Controls.Add(lblDataPagamento);
            Controls.Add(txtValorPago);
            Controls.Add(lblValorPago);
            Controls.Add(txtParcelaSelecionada);
            Controls.Add(lblSequenciaParcela);
            Controls.Add(dgvParcelasPendFinEscolhida);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmRegistroPagamento2";
            Text = "FrmRegistroPagamento2";
            Load += FrmRegistroPagamento2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvParcelasPendFinEscolhida).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvParcelasPendFinEscolhida;
        private Label lblSequenciaParcela;
        private TextBox txtParcelaSelecionada;
        private TextBox txtValorPago;
        private Label lblValorPago;
        private TextBox txtDataPagamento;
        private Label lblDataPagamento;
        private Label lblEspeciePagamento;
        private ComboBox cmbEspeciePagamento;
        private Button btnRegistrarPagamento;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn sequencia;
        private DataGridViewTextBoxColumn vencimento;
        private DataGridViewTextBoxColumn valor;
    }
}