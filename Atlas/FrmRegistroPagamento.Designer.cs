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
            lblPendenciasFinanceiras = new Label();
            id = new DataGridViewTextBoxColumn();
            valorTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoPendenciaFinanceiras).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoricoPendenciaFinanceiras
            // 
            dgvHistoricoPendenciaFinanceiras.AllowUserToAddRows = false;
            dgvHistoricoPendenciaFinanceiras.AllowUserToDeleteRows = false;
            dgvHistoricoPendenciaFinanceiras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoPendenciaFinanceiras.Columns.AddRange(new DataGridViewColumn[] { id, valorTotal });
            dgvHistoricoPendenciaFinanceiras.Location = new Point(12, 24);
            dgvHistoricoPendenciaFinanceiras.Name = "dgvHistoricoPendenciaFinanceiras";
            dgvHistoricoPendenciaFinanceiras.ReadOnly = true;
            dgvHistoricoPendenciaFinanceiras.RowHeadersWidth = 51;
            dgvHistoricoPendenciaFinanceiras.Size = new Size(547, 359);
            dgvHistoricoPendenciaFinanceiras.TabIndex = 0;
            dgvHistoricoPendenciaFinanceiras.CellContentClick += dgvHistoricoPendenciaFinanceiras_CellContentClick;
            dgvHistoricoPendenciaFinanceiras.CellMouseClick += dgvHistoricoPendenciaFinanceiras_CellMouseClick;
            dgvHistoricoPendenciaFinanceiras.DoubleClick += dgvHistoricoPendenciaFinanceiras_DoubleClick;
            // 
            // lblPendenciasFinanceiras
            // 
            lblPendenciasFinanceiras.AutoSize = true;
            lblPendenciasFinanceiras.Location = new Point(12, 6);
            lblPendenciasFinanceiras.Name = "lblPendenciasFinanceiras";
            lblPendenciasFinanceiras.Size = new Size(334, 15);
            lblPendenciasFinanceiras.TabIndex = 2;
            lblPendenciasFinanceiras.Text = "Selecione a pendência que você deseja registrar o pagamento:";
            lblPendenciasFinanceiras.Click += lblPendenciasFinanceiras_Click;
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
            // FrmRegistroPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(961, 485);
            Controls.Add(lblPendenciasFinanceiras);
            Controls.Add(dgvHistoricoPendenciaFinanceiras);
            FormBorderStyle = FormBorderStyle.None;
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
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn valorTotal;
    }
}