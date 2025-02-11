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
            dgvHistoricoAutomovel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoAutomovel.Columns.AddRange(new DataGridViewColumn[] { modelo, placa, cor, status, chassi, renavam, oleoKm, FreioKm });
            dgvHistoricoAutomovel.Location = new Point(-90, 19);
            dgvHistoricoAutomovel.Margin = new Padding(3, 2, 3, 2);
            dgvHistoricoAutomovel.Name = "dgvHistoricoAutomovel";
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
            // 
            // placa
            // 
            placa.DataPropertyName = "Placa";
            placa.HeaderText = "Placa";
            placa.Name = "placa";
            // 
            // cor
            // 
            cor.DataPropertyName = "Cor";
            cor.HeaderText = "Cor";
            cor.Name = "cor";
            // 
            // status
            // 
            status.DataPropertyName = "Status";
            status.HeaderText = "Status";
            status.Name = "status";
            // 
            // chassi
            // 
            chassi.DataPropertyName = "Chassi";
            chassi.HeaderText = "Chassi";
            chassi.Name = "chassi";
            // 
            // renavam
            // 
            renavam.DataPropertyName = "Renavam";
            renavam.HeaderText = "Renavam";
            renavam.Name = "renavam";
            // 
            // oleoKm
            // 
            oleoKm.DataPropertyName = "OleoKm";
            oleoKm.HeaderText = "OleoKm";
            oleoKm.Name = "oleoKm";
            // 
            // FreioKm
            // 
            FreioKm.DataPropertyName = "FreioKm";
            FreioKm.HeaderText = "PastilhaFreioKm";
            FreioKm.Name = "FreioKm";
            // 
            // FrmHistoricoAutomovel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 412);
            Controls.Add(dgvHistoricoAutomovel);
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