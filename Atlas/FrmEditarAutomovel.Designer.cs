namespace Projeto_ATLAS___4LIONS.Forms
{
    partial class FrmEditarAutomovel
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
            lblNovoValor = new Label();
            txtNovoValor = new TextBox();
            btnAtualizarInformacao = new Button();
            lblAtributo = new Label();
            cbmAtributos = new ComboBox();
            cbmAutomovel = new ComboBox();
            lblSelecionarAutomovel = new Label();
            SuspendLayout();
            // 
            // lblNovoValor
            // 
            lblNovoValor.AutoSize = true;
            lblNovoValor.Location = new Point(50, 179);
            lblNovoValor.Name = "lblNovoValor";
            lblNovoValor.Size = new Size(151, 20);
            lblNovoValor.TabIndex = 53;
            lblNovoValor.Text = "Informe o novo valor:";
            // 
            // txtNovoValor
            // 
            txtNovoValor.Location = new Point(50, 203);
            txtNovoValor.Margin = new Padding(3, 4, 3, 4);
            txtNovoValor.Name = "txtNovoValor";
            txtNovoValor.Size = new Size(268, 27);
            txtNovoValor.TabIndex = 52;
            txtNovoValor.TextChanged += txtNovoValor_TextChanged;
            // 
            // btnAtualizarInformacao
            // 
            btnAtualizarInformacao.Location = new Point(50, 294);
            btnAtualizarInformacao.Name = "btnAtualizarInformacao";
            btnAtualizarInformacao.Size = new Size(233, 61);
            btnAtualizarInformacao.TabIndex = 51;
            btnAtualizarInformacao.Text = "Atualizar informações";
            btnAtualizarInformacao.UseVisualStyleBackColor = true;
            btnAtualizarInformacao.Click += btnAtualizarInformacao_Click;
            // 
            // lblAtributo
            // 
            lblAtributo.AutoSize = true;
            lblAtributo.Location = new Point(50, 112);
            lblAtributo.Name = "lblAtributo";
            lblAtributo.Size = new Size(259, 20);
            lblAtributo.TabIndex = 50;
            lblAtributo.Text = "Informe o o campo que deseja editar:";
            // 
            // cbmAtributos
            // 
            cbmAtributos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmAtributos.FormattingEnabled = true;
            cbmAtributos.Location = new Point(50, 135);
            cbmAtributos.Name = "cbmAtributos";
            cbmAtributos.Size = new Size(268, 28);
            cbmAtributos.TabIndex = 49;
            cbmAtributos.SelectedIndexChanged += cbmAtributos_SelectedIndexChanged;
            // 
            // cbmAutomovel
            // 
            cbmAutomovel.FormattingEnabled = true;
            cbmAutomovel.Location = new Point(50, 75);
            cbmAutomovel.Name = "cbmAutomovel";
            cbmAutomovel.Size = new Size(268, 28);
            cbmAutomovel.TabIndex = 48;
            cbmAutomovel.SelectedIndexChanged += cbmAutomovel_SelectedIndexChanged;
            // 
            // lblSelecionarAutomovel
            // 
            lblSelecionarAutomovel.AutoSize = true;
            lblSelecionarAutomovel.Location = new Point(50, 52);
            lblSelecionarAutomovel.Name = "lblSelecionarAutomovel";
            lblSelecionarAutomovel.Size = new Size(151, 20);
            lblSelecionarAutomovel.TabIndex = 47;
            lblSelecionarAutomovel.Text = "Informe a automóvel:";
            lblSelecionarAutomovel.Click += lblSelecionarAutomovel_Click;
            // 
            // FrmEditarAutomovel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNovoValor);
            Controls.Add(txtNovoValor);
            Controls.Add(btnAtualizarInformacao);
            Controls.Add(lblAtributo);
            Controls.Add(cbmAtributos);
            Controls.Add(cbmAutomovel);
            Controls.Add(lblSelecionarAutomovel);
            Name = "FrmEditarAutomovel";
            Text = "FrmEditarAutomovel";
            Load += FrmEditarAutomovel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNovoValor;
        private TextBox txtNovoValor;
        private Button btnAtualizarInformacao;
        private Label lblAtributo;
        private ComboBox cbmAtributos;
        private ComboBox cbmAutomovel;
        private Label lblSelecionarAutomovel;
    }
}