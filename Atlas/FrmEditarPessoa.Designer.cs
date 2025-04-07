namespace Projeto_ATLAS___4LIONS.Forms
{
    partial class FrmEditarPessoa
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
            lblSelecionarPessoa = new Label();
            cbmPessoa = new ComboBox();
            cbmAtributos = new ComboBox();
            lblAtributo = new Label();
            btnAtualizarInformacao = new Button();
            txtNovoValor = new TextBox();
            lblNovoValor = new Label();
            SuspendLayout();
            // 
            // lblSelecionarPessoa
            // 
            lblSelecionarPessoa.AutoSize = true;
            lblSelecionarPessoa.Location = new Point(76, 75);
            lblSelecionarPessoa.Name = "lblSelecionarPessoa";
            lblSelecionarPessoa.Size = new Size(126, 20);
            lblSelecionarPessoa.TabIndex = 32;
            lblSelecionarPessoa.Text = "Informe a pessoa:";
            // 
            // cbmPessoa
            // 
            cbmPessoa.FormattingEnabled = true;
            cbmPessoa.Location = new Point(76, 98);
            cbmPessoa.Name = "cbmPessoa";
            cbmPessoa.Size = new Size(268, 28);
            cbmPessoa.TabIndex = 33;
            cbmPessoa.SelectedIndexChanged += cbmPessoa_SelectedIndexChanged;
            // 
            // cbmAtributos
            // 
            cbmAtributos.FormattingEnabled = true;
            cbmAtributos.Location = new Point(76, 158);
            cbmAtributos.Name = "cbmAtributos";
            cbmAtributos.Size = new Size(268, 28);
            cbmAtributos.TabIndex = 34;
            cbmAtributos.SelectedIndexChanged += cbmAtributos_SelectedIndexChanged;
            // 
            // lblAtributo
            // 
            lblAtributo.AutoSize = true;
            lblAtributo.Location = new Point(76, 135);
            lblAtributo.Name = "lblAtributo";
            lblAtributo.Size = new Size(259, 20);
            lblAtributo.TabIndex = 35;
            lblAtributo.Text = "Informe o o campo que deseja editar:";
            // 
            // btnAtualizarInformacao
            // 
            btnAtualizarInformacao.Location = new Point(76, 317);
            btnAtualizarInformacao.Name = "btnAtualizarInformacao";
            btnAtualizarInformacao.Size = new Size(233, 61);
            btnAtualizarInformacao.TabIndex = 36;
            btnAtualizarInformacao.Text = "Atualizar informações";
            btnAtualizarInformacao.UseVisualStyleBackColor = true;
            btnAtualizarInformacao.Click += btnAtualizarInformacao_Click;
            // 
            // txtNovoValor
            // 
            txtNovoValor.Location = new Point(76, 226);
            txtNovoValor.Margin = new Padding(3, 4, 3, 4);
            txtNovoValor.Name = "txtNovoValor";
            txtNovoValor.Size = new Size(268, 27);
            txtNovoValor.TabIndex = 45;
            txtNovoValor.TextChanged += txtNovoValor_TextChanged;
            // 
            // lblNovoValor
            // 
            lblNovoValor.AutoSize = true;
            lblNovoValor.Location = new Point(76, 202);
            lblNovoValor.Name = "lblNovoValor";
            lblNovoValor.Size = new Size(151, 20);
            lblNovoValor.TabIndex = 46;
            lblNovoValor.Text = "Informe o novo valor:";
            lblNovoValor.Click += lblNovoValor_Click;
            // 
            // FrmEditarPessoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(424, 479);
            Controls.Add(lblNovoValor);
            Controls.Add(txtNovoValor);
            Controls.Add(btnAtualizarInformacao);
            Controls.Add(lblAtributo);
            Controls.Add(cbmAtributos);
            Controls.Add(cbmPessoa);
            Controls.Add(lblSelecionarPessoa);
            Name = "FrmEditarPessoa";
            Text = "FrmEditarPessoa";
            Load += FrmEditarPessoa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelecionarPessoa;
        private ComboBox cbmPessoa;
        private ComboBox cbmAtributos;
        private Label lblAtributo;
        private Button btnAtualizarInformacao;
        private TextBox txtNovoValor;
        private Label lblNovoValor;
    }
}