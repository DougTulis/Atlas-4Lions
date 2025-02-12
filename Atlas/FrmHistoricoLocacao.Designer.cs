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
            idCondutor = new DataGridViewTextBoxColumn();
            idLocatario = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoLocacao).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoricoLocacao
            // 
            dgvHistoricoLocacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoLocacao.Columns.AddRange(new DataGridViewColumn[] { saida, retorno, tipoLocacao, valorTotal, idCondutor, idLocatario });
            dgvHistoricoLocacao.Location = new Point(-26, 9);
            dgvHistoricoLocacao.Name = "dgvHistoricoLocacao";
            dgvHistoricoLocacao.RowHeadersWidth = 51;
            dgvHistoricoLocacao.Size = new Size(853, 432);
            dgvHistoricoLocacao.TabIndex = 1;
            dgvHistoricoLocacao.CellContentClick += dgvHistoricoLocacao_CellContentClick;
            // 
            // saida
            // 
            saida.DataPropertyName = "Saida";
            saida.HeaderText = "Saida";
            saida.MinimumWidth = 6;
            saida.Name = "saida";
            saida.Width = 125;
            // 
            // retorno
            // 
            retorno.DataPropertyName = "Retorno";
            retorno.HeaderText = "Retorno";
            retorno.MinimumWidth = 6;
            retorno.Name = "retorno";
            retorno.Width = 125;
            // 
            // tipoLocacao
            // 
            tipoLocacao.DataPropertyName = "TipoLocacao";
            tipoLocacao.HeaderText = "Tipo da Locação";
            tipoLocacao.MinimumWidth = 6;
            tipoLocacao.Name = "tipoLocacao";
            tipoLocacao.Width = 125;
            // 
            // valorTotal
            // 
            valorTotal.DataPropertyName = "ValorTotal";
            valorTotal.HeaderText = "Valor Total";
            valorTotal.MinimumWidth = 6;
            valorTotal.Name = "valorTotal";
            valorTotal.Width = 125;
            // 
            // idCondutor
            // 
            idCondutor.DataPropertyName = "Condutor";
            idCondutor.HeaderText = "ID Condutor";
            idCondutor.MinimumWidth = 6;
            idCondutor.Name = "idCondutor";
            idCondutor.Width = 125;
            // 
            // idLocatario
            // 
            idLocatario.DataPropertyName = "Locatario";
            idLocatario.HeaderText = "ID Locatario";
            idLocatario.MinimumWidth = 6;
            idLocatario.Name = "idLocatario";
            idLocatario.Width = 125;
            // 
            // FrmHistoricoLocacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvHistoricoLocacao);
            Name = "FrmHistoricoLocacao";
            Text = "FrmHistoricoLocacao";
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoLocacao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistoricoLocacao;
        private DataGridViewTextBoxColumn saida;
        private DataGridViewTextBoxColumn retorno;
        private DataGridViewTextBoxColumn tipoLocacao;
        private DataGridViewTextBoxColumn valorTotal;
        private DataGridViewTextBoxColumn idCondutor;
        private DataGridViewTextBoxColumn idLocatario;
    }
}