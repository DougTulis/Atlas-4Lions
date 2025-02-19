namespace Projeto_ATLAS___4LIONS.Forms
{
    partial class FrmCadAutomovel
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
            lblRenavam = new Label();
            lblOleoKm = new Label();
            lblChassi = new Label();
            lblCor = new Label();
            lblPlaca = new Label();
            lblModelo = new Label();
            txtOleoKm = new TextBox();
            txtRenavam = new TextBox();
            txtChassi = new TextBox();
            txtCor = new TextBox();
            txtFreioKm = new TextBox();
            lblFreioKm = new Label();
            lblDescricaoPreco = new Label();
            btnCadastrarAutomovel = new Button();
            lblAno = new Label();
            txtAno = new TextBox();
            cbmDescricaoPreco = new ComboBox();
            txtModelo = new TextBox();
            txtPlaca = new TextBox();
            SuspendLayout();
            // 
            // lblRenavam
            // 
            lblRenavam.AutoSize = true;
            lblRenavam.Location = new Point(86, 220);
            lblRenavam.Name = "lblRenavam";
            lblRenavam.Size = new Size(193, 20);
            lblRenavam.TabIndex = 23;
            lblRenavam.Text = "Insira o renavam (opcional):";
            // 
            // lblOleoKm
            // 
            lblOleoKm.AutoSize = true;
            lblOleoKm.Location = new Point(375, 221);
            lblOleoKm.Name = "lblOleoKm";
            lblOleoKm.Size = new Size(394, 20);
            lblOleoKm.TabIndex = 22;
            lblOleoKm.Text = "Insira a quilometragem da útima troca de óleo (opcional):";
            lblOleoKm.TextAlign = ContentAlignment.MiddleCenter;
            lblOleoKm.Click += lblOleoKm_Click;
            // 
            // lblChassi
            // 
            lblChassi.AutoSize = true;
            lblChassi.Location = new Point(375, 163);
            lblChassi.Name = "lblChassi";
            lblChassi.Size = new Size(175, 20);
            lblChassi.TabIndex = 21;
            lblChassi.Text = "Insira o chassi (opcional):";
            lblChassi.Click += lblChassi_Click;
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Location = new Point(86, 96);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(84, 20);
            lblCor.TabIndex = 20;
            lblCor.Text = "Insira a cor:";
            lblCor.Click += lblCor_Click;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(375, 29);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(99, 20);
            lblPlaca.TabIndex = 19;
            lblPlaca.Text = "Insira a placa:";
            lblPlaca.Click += lblPlaca_Click;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(86, 29);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(213, 20);
            lblModelo.TabIndex = 18;
            lblModelo.Text = "Insira o modelo do automóvel:";
            lblModelo.Click += lblModelo_Click;
            // 
            // txtOleoKm
            // 
            txtOleoKm.Location = new Point(375, 243);
            txtOleoKm.Name = "txtOleoKm";
            txtOleoKm.Size = new Size(268, 27);
            txtOleoKm.TabIndex = 17;
            txtOleoKm.TextChanged += txtOleoKm_TextChanged;
            // 
            // txtRenavam
            // 
            txtRenavam.Location = new Point(86, 243);
            txtRenavam.Name = "txtRenavam";
            txtRenavam.Size = new Size(268, 27);
            txtRenavam.TabIndex = 16;
            txtRenavam.TextChanged += txtRenavam_TextChanged;
            // 
            // txtChassi
            // 
            txtChassi.Location = new Point(375, 184);
            txtChassi.Name = "txtChassi";
            txtChassi.Size = new Size(268, 27);
            txtChassi.TabIndex = 15;
            txtChassi.TextChanged += txtChassi_TextChanged;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(86, 119);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(268, 27);
            txtCor.TabIndex = 14;
            txtCor.TextChanged += txtCor_TextChanged;
            // 
            // txtFreioKm
            // 
            txtFreioKm.Location = new Point(86, 307);
            txtFreioKm.Name = "txtFreioKm";
            txtFreioKm.Size = new Size(268, 27);
            txtFreioKm.TabIndex = 24;
            txtFreioKm.TextChanged += txtFreioKm_TextChanged;
            // 
            // lblFreioKm
            // 
            lblFreioKm.AutoSize = true;
            lblFreioKm.Location = new Point(86, 284);
            lblFreioKm.Name = "lblFreioKm";
            lblFreioKm.Size = new Size(488, 20);
            lblFreioKm.TabIndex = 25;
            lblFreioKm.Text = "Insira a quilometragem da última troca das pastilhas de freio (opcional):";
            lblFreioKm.Click += lblFreioKm_Click;
            // 
            // lblDescricaoPreco
            // 
            lblDescricaoPreco.AutoSize = true;
            lblDescricaoPreco.Location = new Point(86, 160);
            lblDescricaoPreco.Name = "lblDescricaoPreco";
            lblDescricaoPreco.Size = new Size(190, 20);
            lblDescricaoPreco.TabIndex = 27;
            lblDescricaoPreco.Text = "insira a descrição do preço:";
            lblDescricaoPreco.Click += lblDescricaoPreco_Click;
            // 
            // btnCadastrarAutomovel
            // 
            btnCadastrarAutomovel.Location = new Point(248, 396);
            btnCadastrarAutomovel.Name = "btnCadastrarAutomovel";
            btnCadastrarAutomovel.Size = new Size(233, 61);
            btnCadastrarAutomovel.TabIndex = 30;
            btnCadastrarAutomovel.Text = "Cadastrar Automóvel";
            btnCadastrarAutomovel.UseVisualStyleBackColor = true;
            btnCadastrarAutomovel.Click += btnCadastrarAutomovel_Click;
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Location = new Point(375, 96);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(89, 20);
            lblAno.TabIndex = 32;
            lblAno.Text = "Insira o ano:";
            lblAno.Click += lblAno_Click;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(375, 119);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(268, 27);
            txtAno.TabIndex = 31;
            txtAno.TextChanged += txtAno_TextChanged;
            // 
            // cbmDescricaoPreco
            // 
            cbmDescricaoPreco.FormattingEnabled = true;
            cbmDescricaoPreco.Location = new Point(86, 183);
            cbmDescricaoPreco.Name = "cbmDescricaoPreco";
            cbmDescricaoPreco.Size = new Size(268, 28);
            cbmDescricaoPreco.TabIndex = 33;
            cbmDescricaoPreco.SelectedIndexChanged += cbmDescricaoPreco_SelectedIndexChanged;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(86, 52);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(268, 27);
            txtModelo.TabIndex = 35;
            txtModelo.TextChanged += txtModelo_TextChanged;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(375, 52);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(268, 27);
            txtPlaca.TabIndex = 36;
            txtPlaca.TextChanged += txtPlaca_TextChanged;
            // 
            // FrmCadAutomovel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1098, 647);
            Controls.Add(txtPlaca);
            Controls.Add(txtModelo);
            Controls.Add(cbmDescricaoPreco);
            Controls.Add(lblAno);
            Controls.Add(txtAno);
            Controls.Add(btnCadastrarAutomovel);
            Controls.Add(lblDescricaoPreco);
            Controls.Add(lblFreioKm);
            Controls.Add(txtFreioKm);
            Controls.Add(lblRenavam);
            Controls.Add(lblOleoKm);
            Controls.Add(lblChassi);
            Controls.Add(lblCor);
            Controls.Add(lblPlaca);
            Controls.Add(lblModelo);
            Controls.Add(txtOleoKm);
            Controls.Add(txtRenavam);
            Controls.Add(txtChassi);
            Controls.Add(txtCor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCadAutomovel";
            Text = "FrmCadAutomovel";
            FormClosing += FrmCadAutomovel_FormClosing;
            Load += FrmCadAutomovel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRenavam;
        private Label lblOleoKm;
        private Label lblChassi;
        private Label lblCor;
        private Label lblPlaca;
        private Label lblModelo;
        private TextBox txtOleoKm;
        private TextBox txtRenavam;
        private TextBox txtChassi;
        private TextBox txtCor;
        private TextBox txtFreioKm;
        private Label lblFreioKm;
        private Label lblDescricaoPreco;
        private Button btnCadastrarAutomovel;
        private Label lblAno;
        private TextBox txtAno;
        private ComboBox cbmDescricaoPreco;
        private TextBox txtModelo;
        private TextBox txtPlaca;
    }
}