namespace Projeto_ATLAS___4LIONS.Forms
{
    partial class FrmHistoricoLocacao
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
            dgvHistoricoLocacao = new DataGridView();
            saida = new DataGridViewTextBoxColumn();
            retorno = new DataGridViewTextBoxColumn();
            tipoLocacao = new DataGridViewTextBoxColumn();
            valorTotal = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            condutor = new DataGridViewTextBoxColumn();
            locatario = new DataGridViewTextBoxColumn();
            txtBusca = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoLocacao).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoricoLocacao
            // 
            dgvHistoricoLocacao.AllowUserToAddRows = false;
            dgvHistoricoLocacao.AllowUserToDeleteRows = false;
            dgvHistoricoLocacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoLocacao.Columns.AddRange(new DataGridViewColumn[] { saida, retorno, tipoLocacao, valorTotal, Status, condutor, locatario });
            dgvHistoricoLocacao.Location = new Point(1, 91);
            dgvHistoricoLocacao.Margin = new Padding(3, 2, 3, 2);
            dgvHistoricoLocacao.Name = "dgvHistoricoLocacao";
            dgvHistoricoLocacao.ReadOnly = true;
            dgvHistoricoLocacao.RowHeadersWidth = 51;
            dgvHistoricoLocacao.Size = new Size(890, 352);
            dgvHistoricoLocacao.TabIndex = 1;
            dgvHistoricoLocacao.CellContentClick += dgvHistoricoLocacao_CellContentClick;
            // 
            // saida
            // 
            saida.DataPropertyName = "Saida";
            saida.HeaderText = "Saida";
            saida.MinimumWidth = 6;
            saida.Name = "saida";
            saida.ReadOnly = true;
            saida.Width = 125;
            // 
            // retorno
            // 
            retorno.DataPropertyName = "Retorno";
            retorno.HeaderText = "Retorno";
            retorno.MinimumWidth = 6;
            retorno.Name = "retorno";
            retorno.ReadOnly = true;
            retorno.Width = 125;
            // 
            // tipoLocacao
            // 
            tipoLocacao.DataPropertyName = "TipoLocacao";
            tipoLocacao.HeaderText = "Tipo da Locação";
            tipoLocacao.MinimumWidth = 6;
            tipoLocacao.Name = "tipoLocacao";
            tipoLocacao.ReadOnly = true;
            tipoLocacao.Width = 125;
            // 
            // valorTotal
            // 
            valorTotal.DataPropertyName = "ValorTotal";
            valorTotal.HeaderText = "Valor Total";
            valorTotal.MinimumWidth = 6;
            valorTotal.Name = "valorTotal";
            valorTotal.ReadOnly = true;
            valorTotal.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // condutor
            // 
            condutor.DataPropertyName = "NomeCondutor";
            condutor.HeaderText = "Condutor";
            condutor.MinimumWidth = 6;
            condutor.Name = "condutor";
            condutor.ReadOnly = true;
            condutor.Width = 125;
            // 
            // locatario
            // 
            locatario.DataPropertyName = "NomeLocatario";
            locatario.HeaderText = "Locatario";
            locatario.MinimumWidth = 6;
            locatario.Name = "locatario";
            locatario.ReadOnly = true;
            locatario.Width = 125;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(12, 49);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(264, 23);
            txtBusca.TabIndex = 3;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // FrmHistoricoLocacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(961, 485);
            Controls.Add(txtBusca);
            Controls.Add(dgvHistoricoLocacao);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmHistoricoLocacao";
            Text = "FrmHistoricoLocacao";
            FormClosing += FrmHistoricoLocacao_FormClosing;
            Load += FrmHistoricoLocacao_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoLocacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistoricoLocacao;
        private DataGridViewTextBoxColumn saida;
        private DataGridViewTextBoxColumn retorno;
        private DataGridViewTextBoxColumn tipoLocacao;
        private DataGridViewTextBoxColumn valorTotal;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn condutor;
        private DataGridViewTextBoxColumn locatario;
        private TextBox txtBusca;
    }
}