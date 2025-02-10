namespace Projeto_ATLAS___4LIONS.Forms
{
    partial class FrmVinculacaoCnh
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
            dgvVinculacaoCnh = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            cnpj = new DataGridViewTextBoxColumn();
            bigLblVinculacaoCnh = new ReaLTaiizor.Controls.BigLabel();
            txtPessoa = new TextBox();
            lblPessoa = new Label();
            btnVincularCnh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVinculacaoCnh).BeginInit();
            SuspendLayout();
            // 
            // dgvVinculacaoCnh
            // 
            dgvVinculacaoCnh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVinculacaoCnh.Columns.AddRange(new DataGridViewColumn[] { id, nome, cpf, cnpj });
            dgvVinculacaoCnh.Location = new Point(12, 69);
            dgvVinculacaoCnh.Name = "dgvVinculacaoCnh";
            dgvVinculacaoCnh.Size = new Size(329, 331);
            dgvVinculacaoCnh.TabIndex = 0;
            dgvVinculacaoCnh.CellContentClick += dgvVinculacaoCnh_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.HeaderText = "Id";
            id.Name = "id";
            // 
            // nome
            // 
            nome.DataPropertyName = "Nome";
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            // 
            // cpf
            // 
            cpf.DataPropertyName = "Cpf";
            cpf.HeaderText = "Cpf";
            cpf.Name = "cpf";
            // 
            // cnpj
            // 
            cnpj.DataPropertyName = "Cnpj";
            cnpj.HeaderText = "Cnpj";
            cnpj.Name = "cnpj";
            // 
            // bigLblVinculacaoCnh
            // 
            bigLblVinculacaoCnh.AutoSize = true;
            bigLblVinculacaoCnh.BackColor = Color.Transparent;
            bigLblVinculacaoCnh.Font = new Font("Segoe UI", 15F);
            bigLblVinculacaoCnh.ForeColor = Color.FromArgb(80, 80, 80);
            bigLblVinculacaoCnh.Location = new Point(12, 38);
            bigLblVinculacaoCnh.Name = "bigLblVinculacaoCnh";
            bigLblVinculacaoCnh.Size = new Size(252, 28);
            bigLblVinculacaoCnh.TabIndex = 1;
            bigLblVinculacaoCnh.Text = "Pessoas sem CNH vínculada";
            // 
            // txtPessoa
            // 
            txtPessoa.Location = new Point(356, 93);
            txtPessoa.Name = "txtPessoa";
            txtPessoa.Size = new Size(121, 23);
            txtPessoa.TabIndex = 2;
            txtPessoa.TextChanged += txtPessoa_TextChanged;
            // 
            // lblPessoa
            // 
            lblPessoa.AutoSize = true;
            lblPessoa.Location = new Point(354, 75);
            lblPessoa.Name = "lblPessoa";
            lblPessoa.Size = new Size(292, 15);
            lblPessoa.TabIndex = 3;
            lblPessoa.Text = "Informe o ID da pessoa que você quer vincular a CNH:";
            lblPessoa.Click += lblPessoa_Click;
            // 
            // btnVincularCnh
            // 
            btnVincularCnh.Location = new Point(358, 131);
            btnVincularCnh.Name = "btnVincularCnh";
            btnVincularCnh.Size = new Size(119, 23);
            btnVincularCnh.TabIndex = 4;
            btnVincularCnh.Text = "Vincular";
            btnVincularCnh.UseVisualStyleBackColor = true;
            btnVincularCnh.Click += btnVincularCnh_Click;
            // 
            // FrmVinculacaoCnh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 450);
            Controls.Add(btnVincularCnh);
            Controls.Add(lblPessoa);
            Controls.Add(txtPessoa);
            Controls.Add(bigLblVinculacaoCnh);
            Controls.Add(dgvVinculacaoCnh);
            Name = "FrmVinculacaoCnh";
            Text = "FrmVinculacaoCnh";
            Load += FrmVinculacaoCnh_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVinculacaoCnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVinculacaoCnh;
        private ReaLTaiizor.Controls.BigLabel bigLblVinculacaoCnh;
        private TextBox txtPessoa;
        private Label lblPessoa;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn cnpj;
        private Button btnVincularCnh;
    }
}