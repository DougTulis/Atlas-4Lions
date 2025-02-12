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
            btnExcluirAutomovel = new Button();
            txtIdAutomovelExclusao = new TextBox();
            lblIdAutomovelExclusao = new Label();
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
            // btnExcluirAutomovel
            // 
            btnExcluirAutomovel.Location = new Point(434, 101);
            btnExcluirAutomovel.Name = "btnExcluirAutomovel";
            btnExcluirAutomovel.Size = new Size(138, 29);
            btnExcluirAutomovel.TabIndex = 8;
            btnExcluirAutomovel.Text = "Excluir Automovel";
            btnExcluirAutomovel.UseVisualStyleBackColor = true;
            btnExcluirAutomovel.Click += btnExcluirAutomovel_Click;
            // 
            // txtIdAutomovelExclusao
            // 
            txtIdAutomovelExclusao.Location = new Point(434, 56);
            txtIdAutomovelExclusao.Name = "txtIdAutomovelExclusao";
            txtIdAutomovelExclusao.Size = new Size(269, 27);
            txtIdAutomovelExclusao.TabIndex = 7;
            txtIdAutomovelExclusao.TextChanged += txtIdAutomovelExclusao_TextChanged;
            // 
            // lblIdAutomovelExclusao
            // 
            lblIdAutomovelExclusao.AutoSize = true;
            lblIdAutomovelExclusao.Location = new Point(434, 33);
            lblIdAutomovelExclusao.Name = "lblIdAutomovelExclusao";
            lblIdAutomovelExclusao.Size = new Size(297, 20);
            lblIdAutomovelExclusao.TabIndex = 6;
            lblIdAutomovelExclusao.Text = "Insira o Id do automovel que deseja excluir:";
            lblIdAutomovelExclusao.Click += lblIdAutomovelExclusao_Click;
            // 
            // dgvHistoricoAutomovelExclusaoAutomovel
            // 
            dgvHistoricoAutomovelExclusaoAutomovel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoAutomovelExclusaoAutomovel.Columns.AddRange(new DataGridViewColumn[] { id, modelo, placa, cor, status, chassi, renavam, OleoKm, pastilhaFreioKm });
            dgvHistoricoAutomovelExclusaoAutomovel.Location = new Point(12, 12);
            dgvHistoricoAutomovelExclusaoAutomovel.Name = "dgvHistoricoAutomovelExclusaoAutomovel";
            dgvHistoricoAutomovelExclusaoAutomovel.RowHeadersWidth = 51;
            dgvHistoricoAutomovelExclusaoAutomovel.Size = new Size(400, 445);
            dgvHistoricoAutomovelExclusaoAutomovel.TabIndex = 5;
            dgvHistoricoAutomovelExclusaoAutomovel.CellContentClick += dgvHistoricoAutomovelExclusaoAutomovel_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // modelo
            // 
            modelo.DataPropertyName = "Modelo";
            modelo.HeaderText = "Modelo";
            modelo.MinimumWidth = 6;
            modelo.Name = "modelo";
            modelo.Width = 125;
            // 
            // placa
            // 
            placa.DataPropertyName = "Placa";
            placa.HeaderText = "Placa";
            placa.MinimumWidth = 6;
            placa.Name = "placa";
            placa.Width = 125;
            // 
            // cor
            // 
            cor.DataPropertyName = "Cor";
            cor.HeaderText = "Cor";
            cor.MinimumWidth = 6;
            cor.Name = "cor";
            cor.Width = 125;
            // 
            // status
            // 
            status.DataPropertyName = "Status";
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.Width = 125;
            // 
            // chassi
            // 
            chassi.DataPropertyName = "Chassi";
            chassi.HeaderText = "Chassi";
            chassi.MinimumWidth = 6;
            chassi.Name = "chassi";
            chassi.Width = 125;
            // 
            // renavam
            // 
            renavam.DataPropertyName = "Renavam";
            renavam.HeaderText = "Renavam";
            renavam.MinimumWidth = 6;
            renavam.Name = "renavam";
            renavam.Width = 125;
            // 
            // OleoKm
            // 
            OleoKm.DataPropertyName = "OleoKm";
            OleoKm.HeaderText = "OleoKm";
            OleoKm.MinimumWidth = 6;
            OleoKm.Name = "OleoKm";
            OleoKm.Width = 125;
            // 
            // pastilhaFreioKm
            // 
            pastilhaFreioKm.DataPropertyName = "FreioKm";
            pastilhaFreioKm.HeaderText = "PastilhaFreioKm";
            pastilhaFreioKm.MinimumWidth = 6;
            pastilhaFreioKm.Name = "pastilhaFreioKm";
            pastilhaFreioKm.Width = 125;
            // 
            // FrmExclusaoAutomovel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluirAutomovel);
            Controls.Add(txtIdAutomovelExclusao);
            Controls.Add(lblIdAutomovelExclusao);
            Controls.Add(dgvHistoricoAutomovelExclusaoAutomovel);
            Name = "FrmExclusaoAutomovel";
            Text = "FrmExclusaoAutomovel";
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoAutomovelExclusaoAutomovel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcluirAutomovel;
        private TextBox txtIdAutomovelExclusao;
        private Label lblIdAutomovelExclusao;
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