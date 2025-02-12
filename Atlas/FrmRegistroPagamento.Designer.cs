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
            id = new DataGridViewTextBoxColumn();
            valorTotal = new DataGridViewTextBoxColumn();
            transacaoId = new DataGridViewTextBoxColumn();
            txtPendenciasFinanceiras = new TextBox();
            lblPendenciasFinanceiras = new Label();
            btnPendenciasFinanceiras = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoPendenciaFinanceiras).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoricoPendenciaFinanceiras
            // 
            dgvHistoricoPendenciaFinanceiras.AllowUserToAddRows = false;
            dgvHistoricoPendenciaFinanceiras.AllowUserToDeleteRows = false;
            dgvHistoricoPendenciaFinanceiras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoPendenciaFinanceiras.Columns.AddRange(new DataGridViewColumn[] { id, valorTotal, transacaoId });
            dgvHistoricoPendenciaFinanceiras.Location = new Point(12, 61);
            dgvHistoricoPendenciaFinanceiras.Name = "dgvHistoricoPendenciaFinanceiras";
            dgvHistoricoPendenciaFinanceiras.ReadOnly = true;
            dgvHistoricoPendenciaFinanceiras.Size = new Size(344, 220);
            dgvHistoricoPendenciaFinanceiras.TabIndex = 0;
            dgvHistoricoPendenciaFinanceiras.CellContentClick += dgvHistoricoPendenciaFinanceiras_CellContentClick;
            dgvHistoricoPendenciaFinanceiras.CellMouseClick += dgvHistoricoPendenciaFinanceiras_CellMouseClick;
            dgvHistoricoPendenciaFinanceiras.DoubleClick += dgvHistoricoPendenciaFinanceiras_DoubleClick;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // valorTotal
            // 
            valorTotal.DataPropertyName = "ValorTotal";
            valorTotal.HeaderText = "ValorTotal";
            valorTotal.Name = "valorTotal";
            valorTotal.ReadOnly = true;
            // 
            // transacaoId
            // 
            transacaoId.DataPropertyName = "TransacaoId";
            transacaoId.HeaderText = "Código de transação";
            transacaoId.Name = "transacaoId";
            transacaoId.ReadOnly = true;
            // 
            // txtPendenciasFinanceiras
            // 
            txtPendenciasFinanceiras.Location = new Point(362, 32);
            txtPendenciasFinanceiras.Name = "txtPendenciasFinanceiras";
            txtPendenciasFinanceiras.Size = new Size(158, 23);
            txtPendenciasFinanceiras.TabIndex = 1;
            txtPendenciasFinanceiras.TextChanged += txtPendenciasFinanceiras_TextChanged;
            // 
            // lblPendenciasFinanceiras
            // 
            lblPendenciasFinanceiras.AutoSize = true;
            lblPendenciasFinanceiras.Location = new Point(12, 32);
            lblPendenciasFinanceiras.Name = "lblPendenciasFinanceiras";
            lblPendenciasFinanceiras.Size = new Size(334, 15);
            lblPendenciasFinanceiras.TabIndex = 2;
            lblPendenciasFinanceiras.Text = "Selecione a pendência que você deseja registrar o pagemento:";
            // 
            // btnPendenciasFinanceiras
            // 
            btnPendenciasFinanceiras.Location = new Point(362, 61);
            btnPendenciasFinanceiras.Name = "btnPendenciasFinanceiras";
            btnPendenciasFinanceiras.Size = new Size(158, 23);
            btnPendenciasFinanceiras.TabIndex = 3;
            btnPendenciasFinanceiras.Text = "Selecionar Pendência";
            btnPendenciasFinanceiras.UseVisualStyleBackColor = true;
            btnPendenciasFinanceiras.Click += btnPendenciasFinanceiras_Click;
            // 
            // FrmRegistroPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 305);
            Controls.Add(btnPendenciasFinanceiras);
            Controls.Add(lblPendenciasFinanceiras);
            Controls.Add(txtPendenciasFinanceiras);
            Controls.Add(dgvHistoricoPendenciaFinanceiras);
            Name = "FrmRegistroPagamento";
            Text = "FrmRegistroPagamento";
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoPendenciaFinanceiras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistoricoPendenciaFinanceiras;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn valorTotal;
        private DataGridViewTextBoxColumn transacaoId;
        private TextBox txtPendenciasFinanceiras;
        private Label lblPendenciasFinanceiras;
        private Button btnPendenciasFinanceiras;
    }
}