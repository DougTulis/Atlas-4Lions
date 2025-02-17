﻿namespace Projeto_ATLAS___4LIONS.Forms
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
            lblPendenciasFinanceiras = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoPendenciaFinanceiras).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoricoPendenciaFinanceiras
            // 
            dgvHistoricoPendenciaFinanceiras.AllowUserToAddRows = false;
            dgvHistoricoPendenciaFinanceiras.AllowUserToDeleteRows = false;
            dgvHistoricoPendenciaFinanceiras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoPendenciaFinanceiras.Columns.AddRange(new DataGridViewColumn[] { id, valorTotal, transacaoId });
            dgvHistoricoPendenciaFinanceiras.Location = new Point(14, 81);
            dgvHistoricoPendenciaFinanceiras.Margin = new Padding(3, 4, 3, 4);
            dgvHistoricoPendenciaFinanceiras.Name = "dgvHistoricoPendenciaFinanceiras";
            dgvHistoricoPendenciaFinanceiras.ReadOnly = true;
            dgvHistoricoPendenciaFinanceiras.RowHeadersWidth = 51;
            dgvHistoricoPendenciaFinanceiras.Size = new Size(570, 293);
            dgvHistoricoPendenciaFinanceiras.TabIndex = 0;
            dgvHistoricoPendenciaFinanceiras.CellContentClick += dgvHistoricoPendenciaFinanceiras_CellContentClick;
            dgvHistoricoPendenciaFinanceiras.CellMouseClick += dgvHistoricoPendenciaFinanceiras_CellMouseClick;
            dgvHistoricoPendenciaFinanceiras.DoubleClick += dgvHistoricoPendenciaFinanceiras_DoubleClick;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 125;
            // 
            // valorTotal
            // 
            valorTotal.DataPropertyName = "ValorTotal";
            valorTotal.HeaderText = "ValorTotal";
            valorTotal.MinimumWidth = 6;
            valorTotal.Name = "valorTotal";
            valorTotal.ReadOnly = true;
            valorTotal.Width = 125;
            // 
            // transacaoId
            // 
            transacaoId.DataPropertyName = "TransacaoId";
            transacaoId.HeaderText = "Código de transação";
            transacaoId.MinimumWidth = 6;
            transacaoId.Name = "transacaoId";
            transacaoId.ReadOnly = true;
            transacaoId.Width = 125;
            // 
            // lblPendenciasFinanceiras
            // 
            lblPendenciasFinanceiras.AutoSize = true;
            lblPendenciasFinanceiras.Location = new Point(14, 43);
            lblPendenciasFinanceiras.Name = "lblPendenciasFinanceiras";
            lblPendenciasFinanceiras.Size = new Size(425, 20);
            lblPendenciasFinanceiras.TabIndex = 2;
            lblPendenciasFinanceiras.Text = "Selecione a pendência que você deseja registrar o pagemento:";
            // 
            // FrmRegistroPagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 407);
            Controls.Add(lblPendenciasFinanceiras);
            Controls.Add(dgvHistoricoPendenciaFinanceiras);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmRegistroPagamento";
            Text = "FrmRegistroPagamento";
            Load += FrmRegistroPagamento_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoPendenciaFinanceiras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistoricoPendenciaFinanceiras;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn valorTotal;
        private DataGridViewTextBoxColumn transacaoId;
        private Label lblPendenciasFinanceiras;
    }
}