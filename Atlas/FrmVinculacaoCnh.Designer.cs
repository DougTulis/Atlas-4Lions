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
            btnSelecionarPessoa = new Button();
            lblVencimentoCnh = new Label();
            txtVencimentoCnh = new TextBox();
            txtNumeroCnh = new TextBox();
            lblNumeroCnh = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVinculacaoCnh).BeginInit();
            SuspendLayout();
            // 
            // dgvVinculacaoCnh
            // 
            dgvVinculacaoCnh.AllowUserToAddRows = false;
            dgvVinculacaoCnh.AllowUserToDeleteRows = false;
            dgvVinculacaoCnh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVinculacaoCnh.Columns.AddRange(new DataGridViewColumn[] { id, nome, cpf, cnpj });
            dgvVinculacaoCnh.Location = new Point(11, 89);
            dgvVinculacaoCnh.Margin = new Padding(3, 4, 3, 4);
            dgvVinculacaoCnh.Name = "dgvVinculacaoCnh";
            dgvVinculacaoCnh.ReadOnly = true;
            dgvVinculacaoCnh.RowHeadersWidth = 51;
            dgvVinculacaoCnh.Size = new Size(559, 404);
            dgvVinculacaoCnh.TabIndex = 0;
            dgvVinculacaoCnh.CellContentClick += dgvVinculacaoCnh_CellContentClick;
            dgvVinculacaoCnh.CellMouseClick += dgvVinculacaoCnh_CellMouseClick;
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
            // nome
            // 
            nome.DataPropertyName = "Nome";
            nome.HeaderText = "Nome";
            nome.MinimumWidth = 6;
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Width = 125;
            // 
            // cpf
            // 
            cpf.DataPropertyName = "Cpf";
            cpf.HeaderText = "Cpf";
            cpf.MinimumWidth = 6;
            cpf.Name = "cpf";
            cpf.ReadOnly = true;
            cpf.Width = 125;
            // 
            // cnpj
            // 
            cnpj.DataPropertyName = "Cnpj";
            cnpj.HeaderText = "Cnpj";
            cnpj.MinimumWidth = 6;
            cnpj.Name = "cnpj";
            cnpj.ReadOnly = true;
            cnpj.Width = 125;
            // 
            // bigLblVinculacaoCnh
            // 
            bigLblVinculacaoCnh.AutoSize = true;
            bigLblVinculacaoCnh.BackColor = Color.Transparent;
            bigLblVinculacaoCnh.Font = new Font("Segoe UI", 15F);
            bigLblVinculacaoCnh.ForeColor = Color.White;
            bigLblVinculacaoCnh.Location = new Point(14, 51);
            bigLblVinculacaoCnh.Name = "bigLblVinculacaoCnh";
            bigLblVinculacaoCnh.Size = new Size(326, 35);
            bigLblVinculacaoCnh.TabIndex = 1;
            bigLblVinculacaoCnh.Text = "Pessoas sem CNH vínculada";
            // 
            // txtPessoa
            // 
            txtPessoa.Location = new Point(599, 137);
            txtPessoa.Margin = new Padding(3, 4, 3, 4);
            txtPessoa.Name = "txtPessoa";
            txtPessoa.Size = new Size(138, 27);
            txtPessoa.TabIndex = 2;
            txtPessoa.TextChanged += txtPessoa_TextChanged;
            // 
            // lblPessoa
            // 
            lblPessoa.AutoSize = true;
            lblPessoa.Location = new Point(597, 113);
            lblPessoa.Name = "lblPessoa";
            lblPessoa.Size = new Size(367, 20);
            lblPessoa.TabIndex = 3;
            lblPessoa.Text = "Informe o ID da pessoa que você quer vincular a CNH:";
            lblPessoa.Click += lblPessoa_Click;
            // 
            // btnSelecionarPessoa
            // 
            btnSelecionarPessoa.Location = new Point(597, 336);
            btnSelecionarPessoa.Margin = new Padding(3, 4, 3, 4);
            btnSelecionarPessoa.Name = "btnSelecionarPessoa";
            btnSelecionarPessoa.Size = new Size(141, 31);
            btnSelecionarPessoa.TabIndex = 4;
            btnSelecionarPessoa.Text = "Selecionar Pessoa";
            btnSelecionarPessoa.UseVisualStyleBackColor = true;
            btnSelecionarPessoa.Click += btnSelecionarPessoa_Click;
            // 
            // lblVencimentoCnh
            // 
            lblVencimentoCnh.AutoSize = true;
            lblVencimentoCnh.Location = new Point(597, 185);
            lblVencimentoCnh.Name = "lblVencimentoCnh";
            lblVencimentoCnh.Size = new Size(214, 20);
            lblVencimentoCnh.TabIndex = 5;
            lblVencimentoCnh.Text = "Informe o vencimento da CNH:";
            lblVencimentoCnh.Click += lblVencimentoCnh_Click;
            // 
            // txtVencimentoCnh
            // 
            txtVencimentoCnh.Location = new Point(599, 219);
            txtVencimentoCnh.Name = "txtVencimentoCnh";
            txtVencimentoCnh.Size = new Size(138, 27);
            txtVencimentoCnh.TabIndex = 6;
            txtVencimentoCnh.TextChanged += txtVencimentoCnh_TextChanged_1;
            // 
            // txtNumeroCnh
            // 
            txtNumeroCnh.Location = new Point(599, 292);
            txtNumeroCnh.Name = "txtNumeroCnh";
            txtNumeroCnh.Size = new Size(138, 27);
            txtNumeroCnh.TabIndex = 8;
            txtNumeroCnh.TextChanged += txtNumeroCnh_TextChanged;
            // 
            // lblNumeroCnh
            // 
            lblNumeroCnh.AutoSize = true;
            lblNumeroCnh.Location = new Point(597, 259);
            lblNumeroCnh.Name = "lblNumeroCnh";
            lblNumeroCnh.Size = new Size(188, 20);
            lblNumeroCnh.TabIndex = 7;
            lblNumeroCnh.Text = "Informe o numero da CNH:";
            lblNumeroCnh.Click += lblNumeroCnh_Click;
            // 
            // FrmVinculacaoCnh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1098, 647);
            Controls.Add(txtNumeroCnh);
            Controls.Add(lblNumeroCnh);
            Controls.Add(txtVencimentoCnh);
            Controls.Add(lblVencimentoCnh);
            Controls.Add(btnSelecionarPessoa);
            Controls.Add(lblPessoa);
            Controls.Add(txtPessoa);
            Controls.Add(bigLblVinculacaoCnh);
            Controls.Add(dgvVinculacaoCnh);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnSelecionarPessoa;
        private Label lblVencimentoCnh;
        private TextBox txtVencimentoCnh;
        private TextBox txtNumeroCnh;
        private Label lblNumeroCnh;
    }
}