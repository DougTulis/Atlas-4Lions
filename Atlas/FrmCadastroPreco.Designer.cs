namespace Projeto_ATLAS___4LIONS.Forms
{
    partial class FrmCadastroPreco
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
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            txtValor = new TextBox();
            lblValor = new Label();
            btnCadastrarPreco = new Button();
            SuspendLayout();
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(43, 38);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(143, 20);
            lblDescricao.TabIndex = 0;
            lblDescricao.Text = "Informe a descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(43, 61);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(187, 27);
            txtDescricao.TabIndex = 1;
            txtDescricao.TextChanged += txtDescricao_TextChanged;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(43, 130);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(187, 27);
            txtValor.TabIndex = 3;
            txtValor.TextChanged += txtValor_TextChanged;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(43, 107);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(114, 20);
            lblValor.TabIndex = 2;
            lblValor.Text = "Informe o valor:";
            // 
            // btnCadastrarPreco
            // 
            btnCadastrarPreco.Location = new Point(43, 189);
            btnCadastrarPreco.Name = "btnCadastrarPreco";
            btnCadastrarPreco.Size = new Size(201, 66);
            btnCadastrarPreco.TabIndex = 4;
            btnCadastrarPreco.Text = "Cadastrar preço";
            btnCadastrarPreco.UseVisualStyleBackColor = true;
            btnCadastrarPreco.Click += btnCadastrarPreco_Click;
            // 
            // FrmCadastroPreco
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(875, 496);
            Controls.Add(btnCadastrarPreco);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCadastroPreco";
            Text = "FrmCadastroPreco";
            Load += FrmCadastroPreco_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescricao;
        private TextBox txtDescricao;
        private TextBox txtValor;
        private Label lblValor;
        private Button btnCadastrarPreco;
    }
}