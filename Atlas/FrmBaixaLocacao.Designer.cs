namespace Projeto_ATLAS___4LIONS.Forms
{
    partial class FrmBaixaLocacao
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
            dgvBaixaLocacao = new DataGridView();
            saida = new DataGridViewTextBoxColumn();
            retorno = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            tipoLocacao = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBaixaLocacao).BeginInit();
            SuspendLayout();
            // 
            // dgvBaixaLocacao
            // 
            dgvBaixaLocacao.AllowUserToAddRows = false;
            dgvBaixaLocacao.AllowUserToDeleteRows = false;
            dgvBaixaLocacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaixaLocacao.Columns.AddRange(new DataGridViewColumn[] { saida, retorno, status, tipoLocacao });
            dgvBaixaLocacao.Location = new Point(0, 0);
            dgvBaixaLocacao.Margin = new Padding(3, 2, 3, 2);
            dgvBaixaLocacao.Name = "dgvBaixaLocacao";
            dgvBaixaLocacao.ReadOnly = true;
            dgvBaixaLocacao.RowHeadersWidth = 51;
            dgvBaixaLocacao.Size = new Size(604, 358);
            dgvBaixaLocacao.TabIndex = 0;
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
            // status
            // 
            status.DataPropertyName = "Status";
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            status.Width = 125;
            // 
            // tipoLocacao
            // 
            tipoLocacao.DataPropertyName = "TipoLocacao";
            tipoLocacao.HeaderText = "Tipo Locacao";
            tipoLocacao.MinimumWidth = 6;
            tipoLocacao.Name = "tipoLocacao";
            tipoLocacao.ReadOnly = true;
            tipoLocacao.Width = 125;
            // 
            // FrmBaixaLocacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(961, 485);
            Controls.Add(dgvBaixaLocacao);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmBaixaLocacao";
            Text = "FrmBaixaLocacao";
            Load += FrmBaixaLocacao_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBaixaLocacao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBaixaLocacao;
        private DataGridViewTextBoxColumn saida;
        private DataGridViewTextBoxColumn retorno;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn tipoLocacao;
    }
}