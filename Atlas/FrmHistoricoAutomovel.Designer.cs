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
            dgvHistoricoAutomovel.Location = new Point(-90, 19);
            dgvHistoricoAutomovel.Margin = new Padding(3, 2, 3, 2);
            dgvHistoricoAutomovel.Name = "dgvHistoricoAutomovel";
            dgvHistoricoAutomovel.ReadOnly = true;
            dgvHistoricoAutomovel.RowHeadersWidth = 51;
            dgvHistoricoAutomovel.Size = new Size(746, 324);
            dgvHistoricoAutomovel.TabIndex = 1;
            dgvHistoricoAutomovel.CellContentClick += dgvHistoricoAutomovel_CellContentClick;
            // 
            // modelo
            // 
            modelo.DataPropertyName = "Modelo";
            modelo.HeaderText = "Modelo";
            modelo.Name = "modelo";
            modelo.ReadOnly = true;
            // 
            // placa
            // 
            placa.DataPropertyName = "Placa";
            placa.HeaderText = "Placa";
            placa.Name = "placa";
            placa.ReadOnly = true;
            // 
            // cor
            // 
            cor.DataPropertyName = "Cor";
            cor.HeaderText = "Cor";
            cor.Name = "cor";
            cor.ReadOnly = true;
            // 
            // status
            // 
            status.DataPropertyName = "Status";
            status.HeaderText = "Status";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // chassi
            // 
            chassi.DataPropertyName = "Chassi";
            chassi.HeaderText = "Chassi";
            chassi.Name = "chassi";
            chassi.ReadOnly = true;
            // 
            // renavam
            // 
            renavam.DataPropertyName = "Renavam";
            renavam.HeaderText = "Renavam";
            renavam.Name = "renavam";
            renavam.ReadOnly = true;
            // 
            // oleoKm
            // 
            oleoKm.DataPropertyName = "OleoKm";
            oleoKm.HeaderText = "OleoKm";
            oleoKm.Name = "oleoKm";
            oleoKm.ReadOnly = true;
            // 
            // FreioKm
            // 
            FreioKm.DataPropertyName = "FreioKm";
            FreioKm.HeaderText = "PastilhaFreioKm";
            FreioKm.Name = "FreioKm";
            FreioKm.ReadOnly = true;
            // 
            // FrmHistoricoAutomovel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(961, 485);
            Controls.Add(dgvHistoricoAutomovel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHistoricoAutomovel";
            Text = "FrmHistoricoAutomovel";
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