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
            lblSequenciaParcela = new Label();
            txtParcelaSelecionada = new TextBox();
            txtValorPago = new TextBox();
            lblValorPago = new Label();
            txtDataPagamento = new TextBox();
            lblDataPagamento = new Label();
            lblEspeciePagamento = new Label();
            cmbEspeciePagamento = new ComboBox();
            btnRegistrarPagamento = new Button();
            sequencia = new DataGridViewTextBoxColumn();
            vencimento = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvParcelasPendFinEscolhida).BeginInit();
            SuspendLayout();
            // 
            // dgvParcelasPendFinEscolhida
            // 
            dgvParcelasPendFinEscolhida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParcelasPendFinEscolhida.Columns.AddRange(new DataGridViewColumn[] { sequencia, vencimento, valor });
            dgvParcelasPendFinEscolhida.Location = new Point(3, 29);
            dgvParcelasPendFinEscolhida.Margin = new Padding(3, 4, 3, 4);
            dgvParcelasPendFinEscolhida.Name = "dgvParcelasPendFinEscolhida";
            dgvParcelasPendFinEscolhida.RowHeadersWidth = 51;
            dgvParcelasPendFinEscolhida.Size = new Size(400, 424);
            dgvParcelasPendFinEscolhida.TabIndex = 0;
            dgvParcelasPendFinEscolhida.CellContentClick += dgvParcelasPendFinEscolhida_CellContentClick;
            dgvParcelasPendFinEscolhida.CellMouseClick += dgvParcelasPendFinEscolhida_CellMouseClick;
            // 
            // lblSequenciaParcela
            // 
            lblSequenciaParcela.AutoSize = true;
            lblSequenciaParcela.Location = new Point(420, 28);
            lblSequenciaParcela.Name = "lblSequenciaParcela";
            lblSequenciaParcela.Size = new Size(144, 20);
            lblSequenciaParcela.TabIndex = 1;
            lblSequenciaParcela.Text = "Parcela Selecionada:";
            lblSequenciaParcela.Click += lblSequenciaParcela_Click;
            // 
            // txtParcelaSelecionada
            // 
            txtParcelaSelecionada.Location = new Point(420, 52);
            txtParcelaSelecionada.Margin = new Padding(3, 4, 3, 4);
            txtParcelaSelecionada.Name = "txtParcelaSelecionada";
            txtParcelaSelecionada.Size = new Size(144, 27);
            txtParcelaSelecionada.TabIndex = 2;
            txtParcelaSelecionada.TextChanged += txtParcelaSelecionada_TextChanged;
            // 
            // txtValorPago
            // 
            txtValorPago.Location = new Point(420, 120);
            txtValorPago.Margin = new Padding(3, 4, 3, 4);
            txtValorPago.Name = "txtValorPago";
            txtValorPago.Size = new Size(144, 27);
            txtValorPago.TabIndex = 4;
            txtValorPago.TextChanged += txtValorPago_TextChanged;
            // 
            // lblValorPago
            // 
            lblValorPago.AutoSize = true;
            lblValorPago.Location = new Point(420, 96);
            lblValorPago.Name = "lblValorPago";
            lblValorPago.Size = new Size(153, 20);
            lblValorPago.TabIndex = 3;
            lblValorPago.Text = "Informe o valor pago:";
            lblValorPago.Click += lblValorPago_Click;
            // 
            // txtDataPagamento
            // 
            txtDataPagamento.Location = new Point(420, 190);
            txtDataPagamento.Margin = new Padding(3, 4, 3, 4);
            txtDataPagamento.Name = "txtDataPagamento";
            txtDataPagamento.Size = new Size(144, 27);
            txtDataPagamento.TabIndex = 6;
            txtDataPagamento.TextChanged += txtDataPagamento_TextChanged;
            // 
            // lblDataPagamento
            // 
            lblDataPagamento.AutoSize = true;
            lblDataPagamento.Location = new Point(420, 166);
            lblDataPagamento.Name = "lblDataPagamento";
            lblDataPagamento.Size = new Size(212, 20);
            lblDataPagamento.TabIndex = 5;
            lblDataPagamento.Text = "Informe a data de pagamento:";
            lblDataPagamento.Click += lblDataPagamento_Click;
            // 
            // lblEspeciePagamento
            // 
            lblEspeciePagamento.AutoSize = true;
            lblEspeciePagamento.Location = new Point(420, 235);
            lblEspeciePagamento.Name = "lblEspeciePagamento";
            lblEspeciePagamento.Size = new Size(142, 20);
            lblEspeciePagamento.TabIndex = 7;
            lblEspeciePagamento.Text = "Selecione a espécie:";
            lblEspeciePagamento.Click += lblEspeciePagamento_Click;
            // 
            // cmbEspeciePagamento
            // 
            cmbEspeciePagamento.FormattingEnabled = true;
            cmbEspeciePagamento.Location = new Point(420, 258);
            cmbEspeciePagamento.Name = "cmbEspeciePagamento";
            cmbEspeciePagamento.Size = new Size(144, 28);
            cmbEspeciePagamento.TabIndex = 8;
            cmbEspeciePagamento.SelectedIndexChanged += cmbEspeciePagamento_SelectedIndexChanged;
            // 
            // btnRegistrarPagamento
            // 
            btnRegistrarPagamento.Location = new Point(420, 315);
            btnRegistrarPagamento.Name = "btnRegistrarPagamento";
            btnRegistrarPagamento.Size = new Size(169, 44);
            btnRegistrarPagamento.TabIndex = 9;
            btnRegistrarPagamento.Text = "Registrar Pagamento";
            btnRegistrarPagamento.UseVisualStyleBackColor = true;
            btnRegistrarPagamento.Click += btnRegistrarPagamento_Click;
            // 
            // sequencia
            // 
            sequencia.DataPropertyName = "Sequencia";
            sequencia.HeaderText = "Sequencia";
            sequencia.MinimumWidth = 6;
            sequencia.Name = "sequencia";
            sequencia.Width = 125;
            // 
            // vencimento
            // 
            vencimento.DataPropertyName = "DataVencimento";
            vencimento.HeaderText = "Vencimento";
            vencimento.MinimumWidth = 6;
            vencimento.Name = "vencimento";
            vencimento.Width = 125;
            // 
            // valor
            // 
            valor.DataPropertyName = "Valor";
            valor.HeaderText = "Valor";
            valor.MinimumWidth = 6;
            valor.Name = "valor";
            valor.Width = 125;
            // 
            // FrmRegistroPagamento2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 463);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private DataGridViewTextBoxColumn sequencia;
        private DataGridViewTextBoxColumn vencimento;
        private DataGridViewTextBoxColumn valor;
    }
}