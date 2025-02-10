namespace Projeto_ATLAS___4LIONS.Forms
{
    partial class FrmHistoricoPessoas
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
            dgvHistoricoPessoas = new DataGridView();
            pessoaNome = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            contato = new DataGridViewTextBoxColumn();
            dataNascimento = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            cnpj = new DataGridViewTextBoxColumn();
            vencimentoCnh = new DataGridViewTextBoxColumn();
            numeroCnh = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoPessoas).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoricoPessoas
            // 
            dgvHistoricoPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoPessoas.Columns.AddRange(new DataGridViewColumn[] { pessoaNome, email, contato, dataNascimento, cpf, cnpj, vencimentoCnh, numeroCnh });
            dgvHistoricoPessoas.Location = new Point(0, 26);
            dgvHistoricoPessoas.Name = "dgvHistoricoPessoas";
            dgvHistoricoPessoas.RowHeadersWidth = 51;
            dgvHistoricoPessoas.Size = new Size(853, 432);
            dgvHistoricoPessoas.TabIndex = 0;
            dgvHistoricoPessoas.CellContentClick += dgvHistoricoPessoas_CellContentClick;
            // 
            // pessoaNome
            // 
            pessoaNome.DataPropertyName = "Nome";
            pessoaNome.HeaderText = "Nome ";
            pessoaNome.MinimumWidth = 6;
            pessoaNome.Name = "pessoaNome";
            pessoaNome.Width = 125;
            // 
            // email
            // 
            email.DataPropertyName = "Email";
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.Width = 125;
            // 
            // contato
            // 
            contato.DataPropertyName = "Contato";
            contato.HeaderText = "Contato";
            contato.MinimumWidth = 6;
            contato.Name = "contato";
            contato.Width = 125;
            // 
            // dataNascimento
            // 
            dataNascimento.DataPropertyName = "DataNascimento";
            dataNascimento.HeaderText = "Data de Nascimento";
            dataNascimento.MinimumWidth = 6;
            dataNascimento.Name = "dataNascimento";
            dataNascimento.Width = 125;
            // 
            // cpf
            // 
            cpf.DataPropertyName = "Cpf";
            cpf.HeaderText = "Cpf";
            cpf.MinimumWidth = 6;
            cpf.Name = "cpf";
            cpf.Width = 125;
            // 
            // cnpj
            // 
            cnpj.DataPropertyName = "Cnpj";
            cnpj.HeaderText = "Cnpj";
            cnpj.MinimumWidth = 6;
            cnpj.Name = "cnpj";
            cnpj.Width = 125;
            // 
            // vencimentoCnh
            // 
            vencimentoCnh.DataPropertyName = "VencimentoCnh";
            vencimentoCnh.HeaderText = "Vencimento CNH";
            vencimentoCnh.MinimumWidth = 6;
            vencimentoCnh.Name = "vencimentoCnh";
            vencimentoCnh.Width = 125;
            // 
            // numeroCnh
            // 
            numeroCnh.DataPropertyName = "NumeroCnh";
            numeroCnh.HeaderText = "Numero da CNH";
            numeroCnh.MinimumWidth = 6;
            numeroCnh.Name = "numeroCnh";
            numeroCnh.Width = 125;
            // 
            // FrmHistoricoPessoas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 491);
            Controls.Add(dgvHistoricoPessoas);
            Name = "FrmHistoricoPessoas";
            Text = "FrmHistoricoPessoas";
            Load += FrmHistoricoPessoas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoPessoas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistoricoPessoas;
        private DataGridViewTextBoxColumn pessoaNome;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn contato;
        private DataGridViewTextBoxColumn dataNascimento;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn cnpj;
        private DataGridViewTextBoxColumn vencimentoCnh;
        private DataGridViewTextBoxColumn numeroCnh;
    }
}