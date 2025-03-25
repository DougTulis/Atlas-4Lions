namespace Projeto_ATLAS___4LIONS.Forms
{
    partial class FrmHistoricoAutomovel
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
            dgvHistoricoAutomovel = new DataGridView();
            modelo = new DataGridViewTextBoxColumn();
            placa = new DataGridViewTextBoxColumn();
            cor = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            chassi = new DataGridViewTextBoxColumn();
            renavam = new DataGridViewTextBoxColumn();
            oleoKm = new DataGridViewTextBoxColumn();
            FreioKm = new DataGridViewTextBoxColumn();
            txtBusca = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoAutomovel).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoricoAutomovel
            // 
            dgvHistoricoAutomovel.AllowUserToAddRows = false;
            dgvHistoricoAutomovel.AllowUserToDeleteRows = false;
            dgvHistoricoAutomovel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoAutomovel.Columns.AddRange(new DataGridViewColumn[] { modelo, placa, cor, status, chassi, renavam, oleoKm, FreioKm });
            dgvHistoricoAutomovel.Location = new Point(10, 76);
            dgvHistoricoAutomovel.Margin = new Padding(3, 2, 3, 2);
            dgvHistoricoAutomovel.Name = "dgvHistoricoAutomovel";
            dgvHistoricoAutomovel.ReadOnly = true;
            dgvHistoricoAutomovel.RowHeadersWidth = 51;
            dgvHistoricoAutomovel.Size = new Size(939, 388);
            dgvHistoricoAutomovel.TabIndex = 1;
            dgvHistoricoAutomovel.CellContentClick += dgvHistoricoAutomovel_CellContentClick;
            // 
            // modelo
            // 
            modelo.DataPropertyName = "Modelo";
            modelo.HeaderText = "Modelo";
            modelo.MinimumWidth = 6;
            modelo.Name = "modelo";
            modelo.ReadOnly = true;
            modelo.Width = 125;
            // 
            // placa
            // 
            placa.DataPropertyName = "Placa";
            placa.HeaderText = "Placa";
            placa.MinimumWidth = 6;
            placa.Name = "placa";
            placa.ReadOnly = true;
            placa.Width = 125;
            // 
            // cor
            // 
            cor.DataPropertyName = "Cor";
            cor.HeaderText = "Cor";
            cor.MinimumWidth = 6;
            cor.Name = "cor";
            cor.ReadOnly = true;
            cor.Width = 125;
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
            // chassi
            // 
            chassi.DataPropertyName = "Chassi";
            chassi.HeaderText = "Chassi";
            chassi.MinimumWidth = 6;
            chassi.Name = "chassi";
            chassi.ReadOnly = true;
            chassi.Width = 125;
            // 
            // renavam
            // 
            renavam.DataPropertyName = "Renavam";
            renavam.HeaderText = "Renavam";
            renavam.MinimumWidth = 6;
            renavam.Name = "renavam";
            renavam.ReadOnly = true;
            renavam.Width = 125;
            // 
            // oleoKm
            // 
            oleoKm.DataPropertyName = "OleoKm";
            oleoKm.HeaderText = "OleoKm";
            oleoKm.MinimumWidth = 6;
            oleoKm.Name = "oleoKm";
            oleoKm.ReadOnly = true;
            oleoKm.Width = 125;
            // 
            // FreioKm
            // 
            FreioKm.DataPropertyName = "FreioKm";
            FreioKm.HeaderText = "PastilhaFreioKm";
            FreioKm.MinimumWidth = 6;
            FreioKm.Name = "FreioKm";
            FreioKm.ReadOnly = true;
            FreioKm.Width = 125;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(10, 38);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(264, 23);
            txtBusca.TabIndex = 2;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // FrmHistoricoAutomovel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(961, 485);
            Controls.Add(txtBusca);
            Controls.Add(dgvHistoricoAutomovel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHistoricoAutomovel";
            Text = "FrmHistoricoAutomovel";
            FormClosing += FrmHistoricoAutomovel_FormClosing;
            Load += FrmHistoricoAutomovel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoAutomovel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistoricoAutomovel;
        private DataGridViewTextBoxColumn modelo;
        private DataGridViewTextBoxColumn placa;
        private DataGridViewTextBoxColumn cor;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn chassi;
        private DataGridViewTextBoxColumn renavam;
        private DataGridViewTextBoxColumn oleoKm;
        private DataGridViewTextBoxColumn FreioKm;
        private TextBox txtBusca;
    }
}