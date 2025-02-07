namespace Atlas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            veículosToolStripMenuItem = new ToolStripMenuItem();
            históricoDePessoasToolStripMenuItem = new ToolStripMenuItem();
            excluirPessoasCadastradasToolStripMenuItem = new ToolStripMenuItem();
            vincularCNHToolStripMenuItem = new ToolStripMenuItem();
            gerenciamentoToolStripMenuItem = new ToolStripMenuItem();
            gerenciamentoDeLocaçõesToolStripMenuItem = new ToolStripMenuItem();
            cadastrarVeículoToolStripMenuItem = new ToolStripMenuItem();
            históricoDeVeículosToolStripMenuItem = new ToolStripMenuItem();
            excluirVeículoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarLocaçãoToolStripMenuItem = new ToolStripMenuItem();
            históricoDeLocaçõesToolStripMenuItem = new ToolStripMenuItem();
            rehistrarPagamentoToolStripMenuItem = new ToolStripMenuItem();
            finalizarLocaçãoToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dungeonHeaderLabel1);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 37);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dungeonHeaderLabel1.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel1.Location = new Point(53, 10);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(195, 20);
            dungeonHeaderLabel1.TabIndex = 3;
            dungeonHeaderLabel1.Text = "ATLAS - Locação de Carros";
            dungeonHeaderLabel1.Click += dungeonHeaderLabel1_Click;
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
            nightControlBox1.Location = new Point(598, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 7);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.ForeColor = SystemColors.Control;
            flowLayoutPanel1.Location = new Point(0, 61);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(228, 367);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, gerenciamentoToolStripMenuItem, gerenciamentoDeLocaçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(737, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.BackColor = SystemColors.AppWorkspace;
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { veículosToolStripMenuItem, históricoDePessoasToolStripMenuItem, excluirPessoasCadastradasToolStripMenuItem, vincularCNHToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(160, 20);
            cadastroToolStripMenuItem.Text = "Gerenciamento de pessoas";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // veículosToolStripMenuItem
            // 
            veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            veículosToolStripMenuItem.Size = new Size(218, 22);
            veículosToolStripMenuItem.Text = "Cadastro de pessoas";
            veículosToolStripMenuItem.Click += veículosToolStripMenuItem_Click;
            // 
            // históricoDePessoasToolStripMenuItem
            // 
            históricoDePessoasToolStripMenuItem.Name = "históricoDePessoasToolStripMenuItem";
            históricoDePessoasToolStripMenuItem.Size = new Size(218, 22);
            históricoDePessoasToolStripMenuItem.Text = "Histórico de pessoas";
            // 
            // excluirPessoasCadastradasToolStripMenuItem
            // 
            excluirPessoasCadastradasToolStripMenuItem.Name = "excluirPessoasCadastradasToolStripMenuItem";
            excluirPessoasCadastradasToolStripMenuItem.Size = new Size(218, 22);
            excluirPessoasCadastradasToolStripMenuItem.Text = "Excluir pessoas cadastradas";
            // 
            // vincularCNHToolStripMenuItem
            // 
            vincularCNHToolStripMenuItem.Name = "vincularCNHToolStripMenuItem";
            vincularCNHToolStripMenuItem.Size = new Size(218, 22);
            vincularCNHToolStripMenuItem.Text = "Vincular CNH";
            // 
            // gerenciamentoToolStripMenuItem
            // 
            gerenciamentoToolStripMenuItem.BackColor = SystemColors.AppWorkspace;
            gerenciamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarVeículoToolStripMenuItem, históricoDeVeículosToolStripMenuItem, excluirVeículoToolStripMenuItem });
            gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
            gerenciamentoToolStripMenuItem.Size = new Size(162, 20);
            gerenciamentoToolStripMenuItem.Text = "Gerenciamento de veículos";
            gerenciamentoToolStripMenuItem.Click += gerenciamentoToolStripMenuItem_Click;
            // 
            // gerenciamentoDeLocaçõesToolStripMenuItem
            // 
            gerenciamentoDeLocaçõesToolStripMenuItem.BackColor = SystemColors.AppWorkspace;
            gerenciamentoDeLocaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarLocaçãoToolStripMenuItem, históricoDeLocaçõesToolStripMenuItem, rehistrarPagamentoToolStripMenuItem, finalizarLocaçãoToolStripMenuItem });
            gerenciamentoDeLocaçõesToolStripMenuItem.Name = "gerenciamentoDeLocaçõesToolStripMenuItem";
            gerenciamentoDeLocaçõesToolStripMenuItem.Size = new Size(168, 20);
            gerenciamentoDeLocaçõesToolStripMenuItem.Text = "Gerenciamento de Locações";
            // 
            // cadastrarVeículoToolStripMenuItem
            // 
            cadastrarVeículoToolStripMenuItem.Name = "cadastrarVeículoToolStripMenuItem";
            cadastrarVeículoToolStripMenuItem.Size = new Size(184, 22);
            cadastrarVeículoToolStripMenuItem.Text = "Cadastrar veículo";
            // 
            // históricoDeVeículosToolStripMenuItem
            // 
            históricoDeVeículosToolStripMenuItem.Name = "históricoDeVeículosToolStripMenuItem";
            históricoDeVeículosToolStripMenuItem.Size = new Size(184, 22);
            históricoDeVeículosToolStripMenuItem.Text = "Histórico de veículos";
            // 
            // excluirVeículoToolStripMenuItem
            // 
            excluirVeículoToolStripMenuItem.Name = "excluirVeículoToolStripMenuItem";
            excluirVeículoToolStripMenuItem.Size = new Size(184, 22);
            excluirVeículoToolStripMenuItem.Text = "Excluir veículo";
            // 
            // cadastrarLocaçãoToolStripMenuItem
            // 
            cadastrarLocaçãoToolStripMenuItem.Name = "cadastrarLocaçãoToolStripMenuItem";
            cadastrarLocaçãoToolStripMenuItem.Size = new Size(187, 22);
            cadastrarLocaçãoToolStripMenuItem.Text = "Cadastrar Locação";
            // 
            // históricoDeLocaçõesToolStripMenuItem
            // 
            históricoDeLocaçõesToolStripMenuItem.Name = "históricoDeLocaçõesToolStripMenuItem";
            históricoDeLocaçõesToolStripMenuItem.Size = new Size(187, 22);
            históricoDeLocaçõesToolStripMenuItem.Text = "Histórico de locações";
            // 
            // rehistrarPagamentoToolStripMenuItem
            // 
            rehistrarPagamentoToolStripMenuItem.Name = "rehistrarPagamentoToolStripMenuItem";
            rehistrarPagamentoToolStripMenuItem.Size = new Size(187, 22);
            rehistrarPagamentoToolStripMenuItem.Text = "Registrar pagamento";
            rehistrarPagamentoToolStripMenuItem.Click += rehistrarPagamentoToolStripMenuItem_Click;
            // 
            // finalizarLocaçãoToolStripMenuItem
            // 
            finalizarLocaçãoToolStripMenuItem.Name = "finalizarLocaçãoToolStripMenuItem";
            finalizarLocaçãoToolStripMenuItem.Size = new Size(187, 22);
            finalizarLocaçãoToolStripMenuItem.Text = "Baixa de locações";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 428);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem veículosToolStripMenuItem;
        private ToolStripMenuItem gerenciamentoToolStripMenuItem;
        private ToolStripMenuItem gerenciamentoDeLocaçõesToolStripMenuItem;
        private ToolStripMenuItem históricoDePessoasToolStripMenuItem;
        private ToolStripMenuItem excluirPessoasCadastradasToolStripMenuItem;
        private ToolStripMenuItem vincularCNHToolStripMenuItem;
        private ToolStripMenuItem cadastrarVeículoToolStripMenuItem;
        private ToolStripMenuItem históricoDeVeículosToolStripMenuItem;
        private ToolStripMenuItem excluirVeículoToolStripMenuItem;
        private ToolStripMenuItem cadastrarLocaçãoToolStripMenuItem;
        private ToolStripMenuItem históricoDeLocaçõesToolStripMenuItem;
        private ToolStripMenuItem rehistrarPagamentoToolStripMenuItem;
        private ToolStripMenuItem finalizarLocaçãoToolStripMenuItem;
    }
}
