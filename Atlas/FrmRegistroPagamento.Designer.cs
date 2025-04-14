namespace Projeto_ATLAS___4LIONS.Forms
{
    partial class FrmRegistroPagamento
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
            dgvHistoricoPendenciaFinanceiras = new DataGridView();
            lblPendenciasFinanceiras = new Label();
            Id = new DataGridViewTextBoxColumn();
            NomeLocatario = new DataGridViewTextBoxColumn();
            ValorTotal = new DataGridViewTextBoxColumn();
            QuantidadeParcelas = new DataGridViewTextBoxColumn();
            StatusPagamento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoPendenciaFinanceiras).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoricoPendenciaFinanceiras
            // 
            dgvHistoricoPendenciaFinanceiras.AllowUserToAddRows = false;
            dgvHistoricoPendenciaFinanceiras.AllowUserToDeleteRows = false;
            dgvHistoricoPendenciaFinanceiras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoPendenciaFinanceiras.Columns.AddRange(new DataGridViewColumn[] { Id, NomeLocatario, ValorTotal, QuantidadeParcelas, StatusPagamento });
            dgvHistoricoPendenciaFinanceiras.Location = new Point(14, 32);
            dgvHistoricoPendenciaFinanceiras.Margin = new Padding(3, 4, 3, 4);
            dgvHistoricoPendenciaFinanceiras.Name = "dgvHistoricoPendenciaFinanceiras";
            dgvHistoricoPendenciaFinanceiras.ReadOnly = true;
            dgvHistoricoPendenciaFinanceiras.RowHeadersWidth = 51;
            dgvHistoricoPendenciaFinanceiras.Size = new Size(858, 479);
            dgvHistoricoPendenciaFinanceiras.TabIndex = 0;
            dgvHistoricoPendenciaFinanceiras.CellContentClick += dgvHistoricoPendenciaFinanceiras_CellContentClick;
            dgvHistoricoPendenciaFinanceiras.CellMouseClick += dgvHistoricoPendenciaFinanceiras_CellMouseClick;
            dgvHistoricoPendenciaFinanceiras.DoubleClick += dgvHistoricoPendenciaFinanceiras_DoubleClick;
            // 
            // lblPendenciasFinanceiras
            // 
            lblPendenciasFinanceiras.AutoSize = true;
            lblPendenciasFinanceiras.Location = new Point(14, 8);
            lblPendenciasFinanceiras.Name = "lblPendenciasFinanceiras";
            lblPendenciasFinanceiras.Size = new Size(425, 20);
            lblPendenciasFinanceiras.TabIndex = 2;
            lblPendenciasFinanceiras.Text = "Selecione a pendência que você deseja registrar o pagamento:";
            lblPendenciasFinanceiras.Click += lblPendenciasFinanceiras_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // NomeLocatario
            // 
            NomeLocatario.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NomeLocatario.DataPropertyName = "Nome";
            NomeLocatario.HeaderText = "Nome Locatario";
            NomeLocatario.MinimumWidth = 6;
            NomeLocatario.Name = "NomeLocatario";
            NomeLocatario.ReadOnly = true;
            NomeLocatario.Width = 145;
            // 
            // ValorTotal
            // 
            ValorTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ValorTotal.DataPropertyName = "ValorTotal";
            ValorTotal.HeaderText = "Valor Total da Locação";
            ValorTotal.MinimumWidth = 6;
            ValorTotal.Name = "ValorTotal";
            ValorTotal.ReadOnly = true;
            ValorTotal.Width = 123;
            // 
            // QuantidadeParcelas
            // 
            QuantidadeParcelas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            QuantidadeParcelas.DataPropertyName = "QuantidadeParcelas";
            QuantidadeParcelas.HeaderText = "Quantidade de Parcelas";
            QuantidadeParcelas.MinimumWidth = 6;
            QuantidadeParcelas.Name = "QuantidadeParcelas";
            QuantidadeParcelas.ReadOnly = true;
            QuantidadeParcelas.Width = 129;
            // 
            // StatusPagamento
            // 
            StatusPagamento.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StatusPagamento.DataPropertyName = "Status";
            StatusPagamento.HeaderText = "Status do Pagamento";
            StatusPagamento.MinimumWidth = 6;
            StatusPagamento.Name = "StatusPagamento";
            StatusPagamento.ReadOnly = true;
            StatusPagamento.Width = 164;
            // 
            // FrmRegistroPagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1098, 647);
            Controls.Add(lblPendenciasFinanceiras);
            Controls.Add(dgvHistoricoPendenciaFinanceiras);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmRegistroPagamento";
            Text = "FrmRegistroPagamento";
            FormClosing += FrmRegistroPagamento_FormClosing;
            Load += FrmRegistroPagamento_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoPendenciaFinanceiras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistoricoPendenciaFinanceiras;
        private Label lblPendenciasFinanceiras;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NomeLocatario;
        private DataGridViewTextBoxColumn ValorTotal;
        private DataGridViewTextBoxColumn QuantidadeParcelas;
        private DataGridViewTextBoxColumn StatusPagamento;
    }
}