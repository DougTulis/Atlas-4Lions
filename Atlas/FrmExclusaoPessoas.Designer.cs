namespace Projeto_ATLAS___4LIONS.Forms
{
    partial class FrmExclusaoPessoas
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
            dgvHistoricoPessoasExclusaoPessoas = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            pessoaNome = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoPessoasExclusaoPessoas).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoricoPessoasExclusaoPessoas
            // 
            dgvHistoricoPessoasExclusaoPessoas.AllowUserToAddRows = false;
            dgvHistoricoPessoasExclusaoPessoas.AllowUserToDeleteRows = false;
            dgvHistoricoPessoasExclusaoPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoPessoasExclusaoPessoas.Columns.AddRange(new DataGridViewColumn[] { id, pessoaNome });
            dgvHistoricoPessoasExclusaoPessoas.Location = new Point(10, 9);
            dgvHistoricoPessoasExclusaoPessoas.Margin = new Padding(3, 2, 3, 2);
            dgvHistoricoPessoasExclusaoPessoas.Name = "dgvHistoricoPessoasExclusaoPessoas";
            dgvHistoricoPessoasExclusaoPessoas.ReadOnly = true;
            dgvHistoricoPessoasExclusaoPessoas.RowHeadersWidth = 51;
            dgvHistoricoPessoasExclusaoPessoas.Size = new Size(388, 308);
            dgvHistoricoPessoasExclusaoPessoas.TabIndex = 1;
            dgvHistoricoPessoasExclusaoPessoas.CellContentClick += dgvHistoricoPessoasExclusaoPessoas_CellContentClick;
            dgvHistoricoPessoasExclusaoPessoas.CellDoubleClick += dgvHistoricoPessoasExclusaoPessoas_CellDoubleClick;
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
            // pessoaNome
            // 
            pessoaNome.DataPropertyName = "Nome";
            pessoaNome.HeaderText = "Nome ";
            pessoaNome.MinimumWidth = 6;
            pessoaNome.Name = "pessoaNome";
            pessoaNome.ReadOnly = true;
            pessoaNome.Width = 125;
            // 
            // FrmExclusaoPessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(961, 485);
            Controls.Add(dgvHistoricoPessoasExclusaoPessoas);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmExclusaoPessoas";
            Text = "FrmExclusaoPessoas";
            Load += FrmExclusaoPessoas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoPessoasExclusaoPessoas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistoricoPessoasExclusaoPessoas;
        private Label lblIdPessoaExclusao;
        private TextBox txtIdPessoaExclusao;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn pessoaNome;
    }
}