namespace Projeto_ATLAS___4LIONS.Forms
{
    partial class FrmExclusaoAutomovel
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
            dgvHistoricoAutomovelExclusaoAutomovel = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            modelo = new DataGridViewTextBoxColumn();
            placa = new DataGridViewTextBoxColumn();
            cor = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            chassi = new DataGridViewTextBoxColumn();
            renavam = new DataGridViewTextBoxColumn();
            OleoKm = new DataGridViewTextBoxColumn();
            pastilhaFreioKm = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoAutomovelExclusaoAutomovel).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoricoAutomovelExclusaoAutomovel
            // 
            dgvHistoricoAutomovelExclusaoAutomovel.AllowUserToAddRows = false;
            dgvHistoricoAutomovelExclusaoAutomovel.AllowUserToDeleteRows = false;
            dgvHistoricoAutomovelExclusaoAutomovel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoAutomovelExclusaoAutomovel.Columns.AddRange(new DataGridViewColumn[] { id, modelo, placa, cor, status, chassi, renavam, OleoKm, pastilhaFreioKm });
            dgvHistoricoAutomovelExclusaoAutomovel.Location = new Point(0, -1);
            dgvHistoricoAutomovelExclusaoAutomovel.Margin = new Padding(3, 2, 3, 2);
            dgvHistoricoAutomovelExclusaoAutomovel.Name = "dgvHistoricoAutomovelExclusaoAutomovel";
            dgvHistoricoAutomovelExclusaoAutomovel.ReadOnly = true;
            dgvHistoricoAutomovelExclusaoAutomovel.RowHeadersWidth = 51;
            dgvHistoricoAutomovelExclusaoAutomovel.Size = new Size(669, 334);
            dgvHistoricoAutomovelExclusaoAutomovel.TabIndex = 5;
            dgvHistoricoAutomovelExclusaoAutomovel.CellContentClick += dgvHistoricoAutomovelExclusaoAutomovel_CellContentClick;
            dgvHistoricoAutomovelExclusaoAutomovel.CellMouseDoubleClick += dgvHistoricoAutomovelExclusaoAutomovel_CellMouseDoubleClick;
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
            // OleoKm
            // 
            OleoKm.DataPropertyName = "OleoKm";
            OleoKm.HeaderText = "OleoKm";
            OleoKm.MinimumWidth = 6;
            OleoKm.Name = "OleoKm";
            OleoKm.ReadOnly = true;
            OleoKm.Width = 125;
            // 
            // pastilhaFreioKm
            // 
            pastilhaFreioKm.DataPropertyName = "FreioKm";
            pastilhaFreioKm.HeaderText = "PastilhaFreioKm";
            pastilhaFreioKm.MinimumWidth = 6;
            pastilhaFreioKm.Name = "pastilhaFreioKm";
            pastilhaFreioKm.ReadOnly = true;
            pastilhaFreioKm.Width = 125;
            // 
            // FrmExclusaoAutomovel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(961, 485);
            Controls.Add(dgvHistoricoAutomovelExclusaoAutomovel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmExclusaoAutomovel";
            Text = "FrmExclusaoAutomovel";
            Load += FrmExclusaoAutomovel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoAutomovelExclusaoAutomovel).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvHistoricoAutomovelExclusaoAutomovel;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn modelo;
        private DataGridViewTextBoxColumn placa;
        private DataGridViewTextBoxColumn cor;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn chassi;
        private DataGridViewTextBoxColumn renavam;
        private DataGridViewTextBoxColumn OleoKm;
        private DataGridViewTextBoxColumn pastilhaFreioKm;
    }
}