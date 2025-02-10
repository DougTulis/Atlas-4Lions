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
            lblIdPessoaExclusao = new Label();
            txtIdPessoaExclusao = new TextBox();
            btnExcluirPessoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoPessoasExclusaoPessoas).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoricoPessoasExclusaoPessoas
            // 
            dgvHistoricoPessoasExclusaoPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoPessoasExclusaoPessoas.Columns.AddRange(new DataGridViewColumn[] { id, pessoaNome });
            dgvHistoricoPessoasExclusaoPessoas.Location = new Point(12, 12);
            dgvHistoricoPessoasExclusaoPessoas.Name = "dgvHistoricoPessoasExclusaoPessoas";
            dgvHistoricoPessoasExclusaoPessoas.RowHeadersWidth = 51;
            dgvHistoricoPessoasExclusaoPessoas.Size = new Size(332, 445);
            dgvHistoricoPessoasExclusaoPessoas.TabIndex = 1;
            dgvHistoricoPessoasExclusaoPessoas.CellContentClick += dgvHistoricoPessoasExclusaoPessoas_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // pessoaNome
            // 
            pessoaNome.DataPropertyName = "Nome";
            pessoaNome.HeaderText = "Nome ";
            pessoaNome.MinimumWidth = 6;
            pessoaNome.Name = "pessoaNome";
            pessoaNome.Width = 125;
            // 
            // lblIdPessoaExclusao
            // 
            lblIdPessoaExclusao.AutoSize = true;
            lblIdPessoaExclusao.Location = new Point(371, 33);
            lblIdPessoaExclusao.Name = "lblIdPessoaExclusao";
            lblIdPessoaExclusao.Size = new Size(269, 20);
            lblIdPessoaExclusao.TabIndex = 2;
            lblIdPessoaExclusao.Text = "Insira o Id da Pessoa que deseja excluir:";
            lblIdPessoaExclusao.Click += lblIdPessoaExclusao_Click;
            // 
            // txtIdPessoaExclusao
            // 
            txtIdPessoaExclusao.Location = new Point(371, 56);
            txtIdPessoaExclusao.Name = "txtIdPessoaExclusao";
            txtIdPessoaExclusao.Size = new Size(269, 27);
            txtIdPessoaExclusao.TabIndex = 3;
            txtIdPessoaExclusao.TextChanged += txtIdPessoaExclusao_TextChanged;
            // 
            // btnExcluirPessoa
            // 
            btnExcluirPessoa.Location = new Point(371, 101);
            btnExcluirPessoa.Name = "btnExcluirPessoa";
            btnExcluirPessoa.Size = new Size(138, 29);
            btnExcluirPessoa.TabIndex = 4;
            btnExcluirPessoa.Text = "Excluir Pessoa";
            btnExcluirPessoa.UseVisualStyleBackColor = true;
            btnExcluirPessoa.Click += btnExcluirPessoa_Click;
            // 
            // FrmExclusaoPessoas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 469);
            Controls.Add(btnExcluirPessoa);
            Controls.Add(txtIdPessoaExclusao);
            Controls.Add(lblIdPessoaExclusao);
            Controls.Add(dgvHistoricoPessoasExclusaoPessoas);
            Name = "FrmExclusaoPessoas";
            Text = "FrmExclusaoPessoas";
            Load += FrmExclusaoPessoas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoPessoasExclusaoPessoas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistoricoPessoasExclusaoPessoas;
        private Label lblIdPessoaExclusao;
        private TextBox txtIdPessoaExclusao;
        private Button btnExcluirPessoa;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn pessoaNome;
    }
}