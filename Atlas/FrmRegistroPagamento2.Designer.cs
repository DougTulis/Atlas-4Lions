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
            txtSequenciaParcela = new TextBox();
            txtValorPago = new TextBox();
            lblValorPago = new Label();
            txtDataPagamento = new TextBox();
            lblDataPagamento = new Label();
            txtEspeciePagamento = new TextBox();
            lblEspeciePagamento = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvParcelasPendFinEscolhida).BeginInit();
            SuspendLayout();
            // 
            // dgvParcelasPendFinEscolhida
            // 
            dgvParcelasPendFinEscolhida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParcelasPendFinEscolhida.Location = new Point(12, 40);
            dgvParcelasPendFinEscolhida.Name = "dgvParcelasPendFinEscolhida";
            dgvParcelasPendFinEscolhida.Size = new Size(296, 318);
            dgvParcelasPendFinEscolhida.TabIndex = 0;
            dgvParcelasPendFinEscolhida.CellContentClick += dgvParcelasPendFinEscolhida_CellContentClick;
            // 
            // lblSequenciaParcela
            // 
            lblSequenciaParcela.AutoSize = true;
            lblSequenciaParcela.Location = new Point(322, 22);
            lblSequenciaParcela.Name = "lblSequenciaParcela";
            lblSequenciaParcela.Size = new Size(38, 15);
            lblSequenciaParcela.TabIndex = 1;
            lblSequenciaParcela.Text = "label1";
            lblSequenciaParcela.Click += lblSequenciaParcela_Click;
            // 
            // txtSequenciaParcela
            // 
            txtSequenciaParcela.Location = new Point(322, 40);
            txtSequenciaParcela.Name = "txtSequenciaParcela";
            txtSequenciaParcela.Size = new Size(100, 23);
            txtSequenciaParcela.TabIndex = 2;
            txtSequenciaParcela.TextChanged += txtSequenciaParcela_TextChanged;
            // 
            // txtValorPago
            // 
            txtValorPago.Location = new Point(322, 99);
            txtValorPago.Name = "txtValorPago";
            txtValorPago.Size = new Size(100, 23);
            txtValorPago.TabIndex = 4;
            txtValorPago.TextChanged += txtValorPago_TextChanged;
            // 
            // lblValorPago
            // 
            lblValorPago.AutoSize = true;
            lblValorPago.Location = new Point(322, 81);
            lblValorPago.Name = "lblValorPago";
            lblValorPago.Size = new Size(38, 15);
            lblValorPago.TabIndex = 3;
            lblValorPago.Text = "label2";
            lblValorPago.Click += lblValorPago_Click;
            // 
            // txtDataPagamento
            // 
            txtDataPagamento.Location = new Point(322, 155);
            txtDataPagamento.Name = "txtDataPagamento";
            txtDataPagamento.Size = new Size(100, 23);
            txtDataPagamento.TabIndex = 6;
            txtDataPagamento.TextChanged += txtDataPagamento_TextChanged;
            // 
            // lblDataPagamento
            // 
            lblDataPagamento.AutoSize = true;
            lblDataPagamento.Location = new Point(322, 137);
            lblDataPagamento.Name = "lblDataPagamento";
            lblDataPagamento.Size = new Size(38, 15);
            lblDataPagamento.TabIndex = 5;
            lblDataPagamento.Text = "label3";
            lblDataPagamento.Click += lblDataPagamento_Click;
            // 
            // txtEspeciePagamento
            // 
            txtEspeciePagamento.Location = new Point(322, 210);
            txtEspeciePagamento.Name = "txtEspeciePagamento";
            txtEspeciePagamento.Size = new Size(100, 23);
            txtEspeciePagamento.TabIndex = 8;
            txtEspeciePagamento.TextChanged += txtEspeciePagamento_TextChanged;
            // 
            // lblEspeciePagamento
            // 
            lblEspeciePagamento.AutoSize = true;
            lblEspeciePagamento.Location = new Point(322, 192);
            lblEspeciePagamento.Name = "lblEspeciePagamento";
            lblEspeciePagamento.Size = new Size(38, 15);
            lblEspeciePagamento.TabIndex = 7;
            lblEspeciePagamento.Text = "label4";
            lblEspeciePagamento.Click += lblEspeciePagamento_Click;
            // 
            // FrmRegistroPagamento2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 384);
            Controls.Add(txtEspeciePagamento);
            Controls.Add(lblEspeciePagamento);
            Controls.Add(txtDataPagamento);
            Controls.Add(lblDataPagamento);
            Controls.Add(txtValorPago);
            Controls.Add(lblValorPago);
            Controls.Add(txtSequenciaParcela);
            Controls.Add(lblSequenciaParcela);
            Controls.Add(dgvParcelasPendFinEscolhida);
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
        private TextBox txtSequenciaParcela;
        private TextBox txtValorPago;
        private Label lblValorPago;
        private TextBox txtDataPagamento;
        private Label lblDataPagamento;
        private TextBox txtEspeciePagamento;
        private Label lblEspeciePagamento;
    }
}