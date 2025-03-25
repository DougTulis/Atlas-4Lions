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
            tipoPessoa = new DataGridViewTextBoxColumn();
            pessoaNome = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            contato = new DataGridViewTextBoxColumn();
            dataRegistro = new DataGridViewTextBoxColumn();
            numeroDocumento = new DataGridViewTextBoxColumn();
            vencimentoCnh = new DataGridViewTextBoxColumn();
            numeroCnh = new DataGridViewTextBoxColumn();
            txtBusca = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoPessoas).BeginInit();
            SuspendLayout();
            // 
            // dgvHistoricoPessoas
            // 
            dgvHistoricoPessoas.AllowUserToAddRows = false;
            dgvHistoricoPessoas.AllowUserToDeleteRows = false;
            dgvHistoricoPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoPessoas.Columns.AddRange(new DataGridViewColumn[] { tipoPessoa, pessoaNome, email, contato, dataRegistro, numeroDocumento, vencimentoCnh, numeroCnh });
            dgvHistoricoPessoas.Location = new Point(12, 88);
            dgvHistoricoPessoas.Margin = new Padding(3, 2, 3, 2);
            dgvHistoricoPessoas.Name = "dgvHistoricoPessoas";
            dgvHistoricoPessoas.ReadOnly = true;
            dgvHistoricoPessoas.RowHeadersWidth = 51;
            dgvHistoricoPessoas.Size = new Size(868, 317);
            dgvHistoricoPessoas.TabIndex = 0;
            dgvHistoricoPessoas.CellContentClick += dgvHistoricoPessoas_CellContentClick;
            // 
            // tipoPessoa
            // 
            tipoPessoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tipoPessoa.DataPropertyName = "TipoPessoa";
            tipoPessoa.HeaderText = "Tipo Pessoa";
            tipoPessoa.Name = "tipoPessoa";
            tipoPessoa.ReadOnly = true;
            tipoPessoa.Width = 94;
            // 
            // pessoaNome
            // 
            pessoaNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            pessoaNome.DataPropertyName = "Nome";
            pessoaNome.HeaderText = "Nome ";
            pessoaNome.MinimumWidth = 6;
            pessoaNome.Name = "pessoaNome";
            pessoaNome.ReadOnly = true;
            pessoaNome.Width = 68;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            email.DataPropertyName = "Email";
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 61;
            // 
            // contato
            // 
            contato.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            contato.DataPropertyName = "Contato";
            contato.HeaderText = "Contato";
            contato.MinimumWidth = 6;
            contato.Name = "contato";
            contato.ReadOnly = true;
            contato.Width = 75;
            // 
            // dataRegistro
            // 
            dataRegistro.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataRegistro.DataPropertyName = "DataRegistro";
            dataRegistro.HeaderText = "Data Nascimento/Fundação";
            dataRegistro.MinimumWidth = 6;
            dataRegistro.Name = "dataRegistro";
            dataRegistro.ReadOnly = true;
            dataRegistro.Width = 164;
            // 
            // numeroDocumento
            // 
            numeroDocumento.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            numeroDocumento.DataPropertyName = "NumeroDocumento";
            numeroDocumento.HeaderText = "CPF/CNPJ";
            numeroDocumento.MinimumWidth = 6;
            numeroDocumento.Name = "numeroDocumento";
            numeroDocumento.ReadOnly = true;
            numeroDocumento.Width = 85;
            // 
            // vencimentoCnh
            // 
            vencimentoCnh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            vencimentoCnh.DataPropertyName = "VencimentoCnh";
            vencimentoCnh.HeaderText = "Vencimento CNH";
            vencimentoCnh.MinimumWidth = 6;
            vencimentoCnh.Name = "vencimentoCnh";
            vencimentoCnh.ReadOnly = true;
            vencimentoCnh.Width = 114;
            // 
            // numeroCnh
            // 
            numeroCnh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            numeroCnh.DataPropertyName = "NumeroCnh";
            numeroCnh.HeaderText = "Numero da CNH";
            numeroCnh.MinimumWidth = 6;
            numeroCnh.Name = "numeroCnh";
            numeroCnh.ReadOnly = true;
            numeroCnh.Width = 88;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(12, 47);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(264, 23);
            txtBusca.TabIndex = 1;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // FrmHistoricoPessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(961, 485);
            Controls.Add(txtBusca);
            Controls.Add(dgvHistoricoPessoas);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmHistoricoPessoas";
            Text = "FrmHistoricoPessoas";
            FormClosing += FrmHistoricoPessoas_FormClosing;
            Load += FrmHistoricoPessoas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoPessoas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistoricoPessoas;
        private DataGridViewTextBoxColumn tipoPessoa;
        private DataGridViewTextBoxColumn pessoaNome;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn contato;
        private DataGridViewTextBoxColumn dataRegistro;
        private DataGridViewTextBoxColumn numeroDocumento;
        private DataGridViewTextBoxColumn vencimentoCnh;
        private DataGridViewTextBoxColumn numeroCnh;
        private TextBox txtBusca;
    }
}