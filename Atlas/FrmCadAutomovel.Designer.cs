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
            txtPlaca = new TextBox();
            txtModelo = new TextBox();
            txtFreioKm = new TextBox();
            lblFreioKm = new Label();
            lblDescricaoPreco = new Label();
            txtDescricaoPreco = new TextBox();
            lblPreco = new Label();
            txtPreco = new TextBox();
            SuspendLayout();
            // 
            // lblRenavam
            // 
            lblRenavam.AutoSize = true;
            lblRenavam.Location = new Point(86, 165);
            lblRenavam.Name = "lblRenavam";
            lblRenavam.Size = new Size(193, 20);
            lblRenavam.TabIndex = 23;
            lblRenavam.Text = "Insira o renavam (opcional):";
            // 
            // lblOleoKm
            // 
            lblOleoKm.AutoSize = true;
            lblOleoKm.Location = new Point(375, 165);
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
            lblChassi.Location = new Point(375, 96);
            lblChassi.Name = "lblChassi";
            lblChassi.Size = new Size(103, 20);
            lblChassi.TabIndex = 21;
            lblChassi.Text = "Insira o chassi:";
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
            lblPlaca.Location = new Point(375, 30);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(99, 20);
            lblPlaca.TabIndex = 19;
            lblPlaca.Text = "Insira a placa:";
            lblPlaca.Click += lblPlaca_Click;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(86, 30);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(213, 20);
            lblModelo.TabIndex = 18;
            lblModelo.Text = "Insira o modelo do automóvel:";
            lblModelo.Click += lblModelo_Click;
            // 
            // txtOleoKm
            // 
            txtOleoKm.Location = new Point(375, 188);
            txtOleoKm.Name = "txtOleoKm";
            txtOleoKm.Size = new Size(268, 27);
            txtOleoKm.TabIndex = 17;
            txtOleoKm.TextChanged += txtOleoKm_TextChanged;
            // 
            // txtRenavam
            // 
            txtRenavam.Location = new Point(86, 188);
            txtRenavam.Name = "txtRenavam";
            txtRenavam.Size = new Size(268, 27);
            txtRenavam.TabIndex = 16;
            txtRenavam.TextChanged += txtRenavam_TextChanged;
            // 
            // txtChassi
            // 
            txtChassi.Location = new Point(375, 119);
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
            // txtPlaca
            // 
            txtPlaca.Location = new Point(375, 53);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(268, 27);
            txtPlaca.TabIndex = 13;
            txtPlaca.TextChanged += txtPlaca_TextChanged;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(86, 53);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(268, 27);
            txtModelo.TabIndex = 12;
            txtModelo.TextChanged += txtModelo_TextChanged;
            // 
            // txtFreioKm
            // 
            txtFreioKm.Location = new Point(86, 248);
            txtFreioKm.Name = "txtFreioKm";
            txtFreioKm.Size = new Size(268, 27);
            txtFreioKm.TabIndex = 24;
            txtFreioKm.TextChanged += txtFreioKm_TextChanged;
            // 
            // lblFreioKm
            // 
            lblFreioKm.AutoSize = true;
            lblFreioKm.Location = new Point(86, 225);
            lblFreioKm.Name = "lblFreioKm";
            lblFreioKm.Size = new Size(488, 20);
            lblFreioKm.TabIndex = 25;
            lblFreioKm.Text = "Insira a quilometragem da última troca das pastilhas de freio (opcional):";
            lblFreioKm.Click += lblFreioKm_Click;
            // 
            // lblDescricaoPreco
            // 
            lblDescricaoPreco.AutoSize = true;
            lblDescricaoPreco.Location = new Point(86, 290);
            lblDescricaoPreco.Name = "lblDescricaoPreco";
            lblDescricaoPreco.Size = new Size(190, 20);
            lblDescricaoPreco.TabIndex = 27;
            lblDescricaoPreco.Text = "insira a descrição do preço:";
            lblDescricaoPreco.Click += lblDescricaoPreco_Click;
            // 
            // txtDescricaoPreco
            // 
            txtDescricaoPreco.Location = new Point(86, 313);
            txtDescricaoPreco.Name = "txtDescricaoPreco";
            txtDescricaoPreco.Size = new Size(268, 27);
            txtDescricaoPreco.TabIndex = 26;
            txtDescricaoPreco.TextChanged += txtDescricaoPreco_TextChanged;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(86, 352);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(276, 20);
            lblPreco.TabIndex = 29;
            lblPreco.Text = "Insira o preço de locação do automóvel:";
            lblPreco.Click += lblPreco_Click;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(86, 375);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(268, 27);
            txtPreco.TabIndex = 28;
            txtPreco.TextChanged += txtPreco_TextChanged;
            // 
            // FrmCadAutomovel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPreco);
            Controls.Add(txtPreco);
            Controls.Add(lblDescricaoPreco);
            Controls.Add(txtDescricaoPreco);
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
            Controls.Add(txtPlaca);
            Controls.Add(txtModelo);
            Name = "FrmCadAutomovel";
            Text = "FrmCadAutomovel";
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
        private TextBox txtPlaca;
        private TextBox txtModelo;
        private TextBox txtFreioKm;
        private Label lblFreioKm;
        private Label lblDescricaoPreco;
        private TextBox txtDescricaoPreco;
        private Label lblPreco;
        private TextBox txtPreco;
    }
}