namespace Atlas
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pcbAtlas = new PictureBox();
            lblTitulo = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            mnuGerenciamentoPessoas = new ToolStripMenuItem();
            itmGerenciamentoPessoasCadPessoas = new ToolStripMenuItem();
            itmGerenciamentoPessoasHistPessoas = new ToolStripMenuItem();
            itmGerenciamentoPessoasExcluirPessoas = new ToolStripMenuItem();
            itmGerenciamentoPessoasVincularCnh = new ToolStripMenuItem();
            mnuGerenciamentoVeiculos = new ToolStripMenuItem();
            itmGerenciamentoVeiculosCadVeiculo = new ToolStripMenuItem();
            itmGerenciamentoVeiculosHistVeiculo = new ToolStripMenuItem();
            itmGerenciamentoVeiculosExcluirVeiculo = new ToolStripMenuItem();
            itmGerenciamentoVeiculosCadastrarPreco = new ToolStripMenuItem();
            mnuGerenciamentoLocacoes = new ToolStripMenuItem();
            itmGerenciamentoLocacoesCadLocacoes = new ToolStripMenuItem();
            itmGerenciamentoLocacoesHistLocacoes = new ToolStripMenuItem();
            itmGerenciamentoLocacoesRegPagamento = new ToolStripMenuItem();
            itmGerenciamentoLocacoesBaixaLocacao = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbAtlas).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pcbAtlas);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(nightControlBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(1098, 49);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pcbAtlas
            // 
            pcbAtlas.Image = Projeto_ATLAS___4LIONS.Forms.Properties.Resources._1455013;
            pcbAtlas.Location = new Point(15, 3);
            pcbAtlas.Margin = new Padding(3, 4, 3, 4);
            pcbAtlas.Name = "pcbAtlas";
            pcbAtlas.Size = new Size(42, 43);
            pcbAtlas.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAtlas.TabIndex = 7;
            pcbAtlas.TabStop = false;
            pcbAtlas.Click += pcbAtlas_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(76, 76, 77);
            lblTitulo.Location = new Point(64, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(249, 25);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "ATLAS - Locação de Carros";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(959, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            nightControlBox1.Click += nightControlBox1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.ForeColor = SystemColors.Control;
            flowLayoutPanel1.Location = new Point(0, 79);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(113, 568);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuGerenciamentoPessoas, mnuGerenciamentoVeiculos, mnuGerenciamentoLocacoes });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1098, 30);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuGerenciamentoPessoas
            // 
            mnuGerenciamentoPessoas.BackColor = SystemColors.AppWorkspace;
            mnuGerenciamentoPessoas.DropDownItems.AddRange(new ToolStripItem[] { itmGerenciamentoPessoasCadPessoas, itmGerenciamentoPessoasHistPessoas, itmGerenciamentoPessoasExcluirPessoas, itmGerenciamentoPessoasVincularCnh });
            mnuGerenciamentoPessoas.Name = "mnuGerenciamentoPessoas";
            mnuGerenciamentoPessoas.Size = new Size(201, 24);
            mnuGerenciamentoPessoas.Text = "Gerenciamento de pessoas";
            mnuGerenciamentoPessoas.Click += mnuGerenciamentoPessoas_Click;
            // 
            // itmGerenciamentoPessoasCadPessoas
            // 
            itmGerenciamentoPessoasCadPessoas.Name = "itmGerenciamentoPessoasCadPessoas";
            itmGerenciamentoPessoasCadPessoas.Size = new Size(274, 26);
            itmGerenciamentoPessoasCadPessoas.Text = "Cadastro de pessoas";
            itmGerenciamentoPessoasCadPessoas.Click += itmGerenciamentoPessoasCadPessoas_Click;
            // 
            // itmGerenciamentoPessoasHistPessoas
            // 
            itmGerenciamentoPessoasHistPessoas.Name = "itmGerenciamentoPessoasHistPessoas";
            itmGerenciamentoPessoasHistPessoas.Size = new Size(274, 26);
            itmGerenciamentoPessoasHistPessoas.Text = "Historico de Pessoas";
            itmGerenciamentoPessoasHistPessoas.Click += itmGerenciamentoPessoasHistPessoas_Click;
            // 
            // itmGerenciamentoPessoasExcluirPessoas
            // 
            itmGerenciamentoPessoasExcluirPessoas.Name = "itmGerenciamentoPessoasExcluirPessoas";
            itmGerenciamentoPessoasExcluirPessoas.Size = new Size(274, 26);
            itmGerenciamentoPessoasExcluirPessoas.Text = "Excluir pessoas cadastradas";
            itmGerenciamentoPessoasExcluirPessoas.Click += itmGerenciamentoPessoasExcluirPessoas_Click;
            // 
            // itmGerenciamentoPessoasVincularCnh
            // 
            itmGerenciamentoPessoasVincularCnh.Name = "itmGerenciamentoPessoasVincularCnh";
            itmGerenciamentoPessoasVincularCnh.Size = new Size(274, 26);
            itmGerenciamentoPessoasVincularCnh.Text = "Vincular CNH";
            itmGerenciamentoPessoasVincularCnh.Click += itmGerenciamentoPessoasVincularCnh_Click;
            // 
            // mnuGerenciamentoVeiculos
            // 
            mnuGerenciamentoVeiculos.BackColor = SystemColors.AppWorkspace;
            mnuGerenciamentoVeiculos.DropDownItems.AddRange(new ToolStripItem[] { itmGerenciamentoVeiculosCadVeiculo, itmGerenciamentoVeiculosHistVeiculo, itmGerenciamentoVeiculosExcluirVeiculo, itmGerenciamentoVeiculosCadastrarPreco });
            mnuGerenciamentoVeiculos.Name = "mnuGerenciamentoVeiculos";
            mnuGerenciamentoVeiculos.Size = new Size(202, 24);
            mnuGerenciamentoVeiculos.Text = "Gerenciamento de veículos";
            mnuGerenciamentoVeiculos.Click += mnuGerenciamentoVeiculos_Click;
            // 
            // itmGerenciamentoVeiculosCadVeiculo
            // 
            itmGerenciamentoVeiculosCadVeiculo.Name = "itmGerenciamentoVeiculosCadVeiculo";
            itmGerenciamentoVeiculosCadVeiculo.Size = new Size(230, 26);
            itmGerenciamentoVeiculosCadVeiculo.Text = "Cadastrar veículo";
            itmGerenciamentoVeiculosCadVeiculo.Click += itmGerenciamentoVeiculosCadVeiculo_Click;
            // 
            // itmGerenciamentoVeiculosHistVeiculo
            // 
            itmGerenciamentoVeiculosHistVeiculo.Name = "itmGerenciamentoVeiculosHistVeiculo";
            itmGerenciamentoVeiculosHistVeiculo.Size = new Size(230, 26);
            itmGerenciamentoVeiculosHistVeiculo.Text = "Histórico de veículos";
            itmGerenciamentoVeiculosHistVeiculo.Click += itmGerenciamentoVeiculosHistVeiculo_Click;
            // 
            // itmGerenciamentoVeiculosExcluirVeiculo
            // 
            itmGerenciamentoVeiculosExcluirVeiculo.Name = "itmGerenciamentoVeiculosExcluirVeiculo";
            itmGerenciamentoVeiculosExcluirVeiculo.Size = new Size(230, 26);
            itmGerenciamentoVeiculosExcluirVeiculo.Text = "Excluir veículo";
            itmGerenciamentoVeiculosExcluirVeiculo.Click += itmGerenciamentoVeiculosExcluirVeiculo_Click;
            // 
            // itmGerenciamentoVeiculosCadastrarPreco
            // 
            itmGerenciamentoVeiculosCadastrarPreco.Name = "itmGerenciamentoVeiculosCadastrarPreco";
            itmGerenciamentoVeiculosCadastrarPreco.Size = new Size(230, 26);
            itmGerenciamentoVeiculosCadastrarPreco.Text = "Cadastrar Preco ";
            itmGerenciamentoVeiculosCadastrarPreco.Click += itmGerenciamentoVeiculosCadastrarPreco_Click;
            // 
            // mnuGerenciamentoLocacoes
            // 
            mnuGerenciamentoLocacoes.BackColor = SystemColors.AppWorkspace;
            mnuGerenciamentoLocacoes.DropDownItems.AddRange(new ToolStripItem[] { itmGerenciamentoLocacoesCadLocacoes, itmGerenciamentoLocacoesHistLocacoes, itmGerenciamentoLocacoesRegPagamento, itmGerenciamentoLocacoesBaixaLocacao });
            mnuGerenciamentoLocacoes.Name = "mnuGerenciamentoLocacoes";
            mnuGerenciamentoLocacoes.Size = new Size(210, 24);
            mnuGerenciamentoLocacoes.Text = "Gerenciamento de Locações";
            mnuGerenciamentoLocacoes.Click += mnuGerenciamentoLocacoes_Click;
            // 
            // itmGerenciamentoLocacoesCadLocacoes
            // 
            itmGerenciamentoLocacoesCadLocacoes.Name = "itmGerenciamentoLocacoesCadLocacoes";
            itmGerenciamentoLocacoesCadLocacoes.Size = new Size(235, 26);
            itmGerenciamentoLocacoesCadLocacoes.Text = "Cadastrar Locação";
            itmGerenciamentoLocacoesCadLocacoes.Click += itmGerenciamentoLocacoesCadLocacoes_Click;
            // 
            // itmGerenciamentoLocacoesHistLocacoes
            // 
            itmGerenciamentoLocacoesHistLocacoes.Name = "itmGerenciamentoLocacoesHistLocacoes";
            itmGerenciamentoLocacoesHistLocacoes.Size = new Size(235, 26);
            itmGerenciamentoLocacoesHistLocacoes.Text = "Histórico de locações";
            itmGerenciamentoLocacoesHistLocacoes.Click += itmGerenciamentoLocacoesHistLocacoes_Click;
            // 
            // itmGerenciamentoLocacoesRegPagamento
            // 
            itmGerenciamentoLocacoesRegPagamento.Name = "itmGerenciamentoLocacoesRegPagamento";
            itmGerenciamentoLocacoesRegPagamento.Size = new Size(235, 26);
            itmGerenciamentoLocacoesRegPagamento.Text = "Registrar pagamento";
            itmGerenciamentoLocacoesRegPagamento.Click += itmGerenciamentoLocacoesRegPagamento_Click;
            // 
            // itmGerenciamentoLocacoesBaixaLocacao
            // 
            itmGerenciamentoLocacoesBaixaLocacao.Name = "itmGerenciamentoLocacoesBaixaLocacao";
            itmGerenciamentoLocacoesBaixaLocacao.Size = new Size(235, 26);
            itmGerenciamentoLocacoesBaixaLocacao.Text = "Baixa de locações";
            itmGerenciamentoLocacoesBaixaLocacao.Click += itmGerenciamentoLocacoesBaixaLocacao_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1098, 647);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1561, 971);
            MinimumSize = new Size(261, 65);
            Name = "FrmPrincipal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dungeonForm1";
            TransparencyKey = Color.MediumPurple;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbAtlas).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblTitulo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuGerenciamentoPessoas;
        private ToolStripMenuItem itmGerenciamentoPessoasCadPessoas;
        private ToolStripMenuItem mnuGerenciamentoVeiculos;
        private ToolStripMenuItem mnuGerenciamentoLocacoes;
        private ToolStripMenuItem itmGerenciamentoPessoasHistPessoas;
        private ToolStripMenuItem itmGerenciamentoPessoasExcluirPessoas;
        private ToolStripMenuItem itmGerenciamentoPessoasVincularCnh;
        private ToolStripMenuItem itmGerenciamentoVeiculosCadVeiculo;
        private ToolStripMenuItem itmGerenciamentoVeiculosHistVeiculo;
        private ToolStripMenuItem itmGerenciamentoVeiculosExcluirVeiculo;
        private ToolStripMenuItem itmGerenciamentoLocacoesCadLocacoes;
        private ToolStripMenuItem itmGerenciamentoLocacoesHistLocacoes;
        private ToolStripMenuItem itmGerenciamentoLocacoesRegPagamento;
        private ToolStripMenuItem itmGerenciamentoLocacoesBaixaLocacao;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pcbAtlas;
        private ToolStripMenuItem itmGerenciamentoVeiculosCadastrarPreco;
    }
}
