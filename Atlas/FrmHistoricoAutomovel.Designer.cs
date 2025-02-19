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
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoAutomovel).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoricoAutomovel
            // 
            dgvHistoricoAutomovel.AllowUserToAddRows = false;
            dgvHistoricoAutomovel.AllowUserToDeleteRows = false;
            dgvHistoricoAutomovel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoAutomovel.Columns.AddRange(new DataGridViewColumn[] { modelo, placa, cor, status, chassi, renavam, oleoKm, FreioKm });
            dgvHistoricoAutomovel.Location = new Point(-103, 25);
            dgvHistoricoAutomovel.Name = "dgvHistoricoAutomovel";
            dgvHistoricoAutomovel.ReadOnly = true;
            dgvHistoricoAutomovel.RowHeadersWidth = 51;
            dgvHistoricoAutomovel.Size = new Size(853, 432);
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
            // FrmHistoricoAutomovel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1098, 647);
            Controls.Add(dgvHistoricoAutomovel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmHistoricoAutomovel";
            Text = "FrmHistoricoAutomovel";
            FormClosing += FrmHistoricoAutomovel_FormClosing;
            Load += FrmHistoricoAutomovel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoAutomovel).EndInit();
            ResumeLayout(false);
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
    }
}