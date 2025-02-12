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
            btnCadastrarAutomovel = new Button();
            lblAno = new Label();
            txtAno = new TextBox();
            SuspendLayout();
            // 
            // lblRenavam
            // 
            lblRenavam.AutoSize = true;
            lblRenavam.Location = new Point(75, 216);
            lblRenavam.Name = "lblRenavam";
            lblRenavam.Size = new Size(154, 15);
            lblRenavam.TabIndex = 23;
            lblRenavam.Text = "Insira o renavam (opcional):";
            // 
            // lblOleoKm
            // 
            lblOleoKm.AutoSize = true;
            lblOleoKm.Location = new Point(328, 164);
            lblOleoKm.Name = "lblOleoKm";
            lblOleoKm.Size = new Size(311, 15);
            lblOleoKm.TabIndex = 22;
            lblOleoKm.Text = "Insira a quilometragem da útima troca de óleo (opcional):";
            lblOleoKm.TextAlign = ContentAlignment.MiddleCenter;
            lblOleoKm.Click += lblOleoKm_Click;
            // 
            // lblChassi
            // 
            lblChassi.AutoSize = true;
            lblChassi.Location = new Point(75, 164);
            lblChassi.Name = "lblChassi";
            lblChassi.Size = new Size(140, 15);
            lblChassi.TabIndex = 21;
            lblChassi.Text = "Insira o chassi (opcional):";
            lblChassi.Click += lblChassi_Click;
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Location = new Point(75, 72);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(67, 15);
            lblCor.TabIndex = 20;
            lblCor.Text = "Insira a cor:";
            lblCor.Click += lblCor_Click;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(328, 22);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(78, 15);
            lblPlaca.TabIndex = 19;
            lblPlaca.Text = "Insira a placa:";
            lblPlaca.Click += lblPlaca_Click;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(75, 22);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(169, 15);
            lblModelo.TabIndex = 18;
            lblModelo.Text = "Insira o modelo do automóvel:";
            lblModelo.Click += lblModelo_Click;
            // 
            // txtOleoKm
            // 
            txtOleoKm.Location = new Point(328, 181);
            txtOleoKm.Margin = new Padding(3, 2, 3, 2);
            txtOleoKm.Name = "txtOleoKm";
            txtOleoKm.Size = new Size(235, 23);
            txtOleoKm.TabIndex = 17;
            txtOleoKm.TextChanged += txtOleoKm_TextChanged;
            // 
            // txtRenavam
            // 
            txtRenavam.Location = new Point(75, 233);
            txtRenavam.Margin = new Padding(3, 2, 3, 2);
            txtRenavam.Name = "txtRenavam";
            txtRenavam.Size = new Size(235, 23);
            txtRenavam.TabIndex = 16;
            txtRenavam.TextChanged += txtRenavam_TextChanged;
            // 
            // txtChassi
            // 
            txtChassi.Location = new Point(75, 181);
            txtChassi.Margin = new Padding(3, 2, 3, 2);
            txtChassi.Name = "txtChassi";
            txtChassi.Size = new Size(235, 23);
            txtChassi.TabIndex = 15;
            txtChassi.TextChanged += txtChassi_TextChanged;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(75, 89);
            txtCor.Margin = new Padding(3, 2, 3, 2);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(235, 23);
            txtCor.TabIndex = 14;
            txtCor.TextChanged += txtCor_TextChanged;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(328, 40);
            txtPlaca.Margin = new Padding(3, 2, 3, 2);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(235, 23);
            txtPlaca.TabIndex = 13;
            txtPlaca.TextChanged += txtPlaca_TextChanged;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(75, 40);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(235, 23);
            txtModelo.TabIndex = 12;
            txtModelo.TextChanged += txtModelo_TextChanged;
            // 
            // txtFreioKm
            // 
            txtFreioKm.Location = new Point(328, 233);
            txtFreioKm.Margin = new Padding(3, 2, 3, 2);
            txtFreioKm.Name = "txtFreioKm";
            txtFreioKm.Size = new Size(235, 23);
            txtFreioKm.TabIndex = 24;
            txtFreioKm.TextChanged += txtFreioKm_TextChanged;
            // 
            // lblFreioKm
            // 
            lblFreioKm.AutoSize = true;
            lblFreioKm.Location = new Point(328, 216);
            lblFreioKm.Name = "lblFreioKm";
            lblFreioKm.Size = new Size(385, 15);
            lblFreioKm.TabIndex = 25;
            lblFreioKm.Text = "Insira a quilometragem da última troca das pastilhas de freio (opcional):";
            lblFreioKm.Click += lblFreioKm_Click;
            // 
            // lblDescricaoPreco
            // 
            lblDescricaoPreco.AutoSize = true;
            lblDescricaoPreco.Location = new Point(75, 120);
            lblDescricaoPreco.Name = "lblDescricaoPreco";
            lblDescricaoPreco.Size = new Size(150, 15);
            lblDescricaoPreco.TabIndex = 27;
            lblDescricaoPreco.Text = "insira a descrição do preço:";
            lblDescricaoPreco.Click += lblDescricaoPreco_Click;
            // 
            // txtDescricaoPreco
            // 
            txtDescricaoPreco.Location = new Point(75, 137);
            txtDescricaoPreco.Margin = new Padding(3, 2, 3, 2);
            txtDescricaoPreco.Name = "txtDescricaoPreco";
            txtDescricaoPreco.Size = new Size(235, 23);
            txtDescricaoPreco.TabIndex = 26;
            txtDescricaoPreco.TextChanged += txtDescricaoPreco_TextChanged;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(328, 120);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(218, 15);
            lblPreco.TabIndex = 29;
            lblPreco.Text = "Insira o preço de locação do automóvel:";
            lblPreco.Click += lblPreco_Click;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(328, 137);
            txtPreco.Margin = new Padding(3, 2, 3, 2);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(235, 23);
            txtPreco.TabIndex = 28;
            txtPreco.TextChanged += txtPreco_TextChanged;
            // 
            // btnCadastrarAutomovel
            // 
            btnCadastrarAutomovel.Location = new Point(217, 297);
            btnCadastrarAutomovel.Margin = new Padding(3, 2, 3, 2);
            btnCadastrarAutomovel.Name = "btnCadastrarAutomovel";
            btnCadastrarAutomovel.Size = new Size(204, 46);
            btnCadastrarAutomovel.TabIndex = 30;
            btnCadastrarAutomovel.Text = "Cadastrar Automóvel";
            btnCadastrarAutomovel.UseVisualStyleBackColor = true;
            btnCadastrarAutomovel.Click += btnCadastrarAutomovel_Click;
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Location = new Point(328, 72);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(71, 15);
            lblAno.TabIndex = 32;
            lblAno.Text = "Insira o ano:";
            lblAno.Click += lblAno_Click;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(328, 89);
            txtAno.Margin = new Padding(3, 2, 3, 2);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(235, 23);
            txtAno.TabIndex = 31;
            txtAno.TextChanged += txtAno_TextChanged;
            // 
            // FrmCadAutomovel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(723, 378);
            Controls.Add(lblAno);
            Controls.Add(txtAno);
            Controls.Add(btnCadastrarAutomovel);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnCadastrarAutomovel;
        private Label lblAno;
        private TextBox txtAno;
    }
}