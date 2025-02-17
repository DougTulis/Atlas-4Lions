using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Forms;
using Projeto_ATLAS___4LIONS.Forms.Properties;
using Projeto_ATLAS___4LIONS.Infra.Servicos;
using Projeto_ATLAS___4LIONS.Aplicacao.Servicos;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Validacoes;

namespace Atlas
{
    public partial class FrmPrincipal : Form
    {
        private FrmCadPessoas frmCadPessoas;
        private FrmCadAutomovel frmCadAutomovel;
        private FrmCadLocacao frmCadLocacao;
        private FrmHistoricoPessoas frmHistoricoPessoas;
        private FrmExclusaoPessoas frmExclusaoPessoas;
        private FrmVinculacaoCnh frmVinculacaoCnh;
        private FrmHistoricoAutomovel frmHistoricoAutomovel;
        private FrmExclusaoAutomovel frmExclusaoAutomovel;
        private FrmHistoricoLocacao frmHistoricoLocacao;
        private FrmBaixaLocacao frmBaixaLocacao;
        private FrmRegistroPagamento frmRegistroPagamento;

        // ✅ Adicionando os repositórios necessários
        private readonly IPessoaRepositorio pessoaRepositorio;
        private readonly IAutomovelRepositorio automovelRepositorio;
        private readonly ITabelaPrecoRepositorio tabelaPrecoRepositorio;
        private readonly ILocacaoRepositorio locacaoRepositorio;

        public FrmPrincipal(
            LocacaoService locacaoService,
            PendenciaFinanceiraServico pendenciaFinanceiraService,
            ListarPessoaUseCase listarPessoaUseCase,
            ListarAutomovelUseCase listarAutomovelUseCase,
            ListarHistoricoLocacaoUseCase listarHistoricoLocacaoUseCase,
            
            IPessoaRepositorio pessoaRepositorio,
            IAutomovelRepositorio automovelRepositorio,
            ITabelaPrecoRepositorio tabelaPrecoRepositorio)

            
        {
            InitializeComponent();

        
            this.pessoaRepositorio = pessoaRepositorio;
            this.automovelRepositorio = automovelRepositorio;

            frmCadPessoas = new FrmCadPessoas();
            frmCadAutomovel = new FrmCadAutomovel();
            frmCadLocacao = new FrmCadLocacao(locacaoService, pendenciaFinanceiraService, listarPessoaUseCase, listarAutomovelUseCase, tabelaPrecoRepositorio);
            frmHistoricoPessoas = new FrmHistoricoPessoas();
            frmExclusaoPessoas = new FrmExclusaoPessoas();
            frmVinculacaoCnh = new FrmVinculacaoCnh();
            frmHistoricoAutomovel = new FrmHistoricoAutomovel();
            frmExclusaoAutomovel = new FrmExclusaoAutomovel();
            frmHistoricoLocacao = new FrmHistoricoLocacao(pessoaRepositorio,locacaoRepositorio,listarHistoricoLocacaoUseCase);
            frmBaixaLocacao = new FrmBaixaLocacao();
            frmRegistroPagamento = new FrmRegistroPagamento();
            this.tabelaPrecoRepositorio = tabelaPrecoRepositorio;
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void lblTitulo_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e) { }

        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void button1_Click_1(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e) { }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e) { }

        private void airButton1_Click(object sender, EventArgs e) { }

        private void flowLayoutPanel2_Paint_1(object sender, PaintEventArgs e) { }

        private void mnuGerenciamentoPessoas_Click(object sender, EventArgs e) { }

        private void mnuGerenciamentoVeiculos_Click(object sender, EventArgs e) { }

        private void mnuGerenciamentoLocacoes_Click(object sender, EventArgs e) { }

        private void itmGerenciamentoLocacoesRegPagamento_Click(object sender, EventArgs e)
        {
            frmRegistroPagamento.MdiParent = this;
            frmRegistroPagamento.Show();
        }

        private void nightControlBox1_Click(object sender, EventArgs e) { }

        private void itmGerenciamentoPessoasCadPessoas_Click(object sender, EventArgs e)
        {
            frmCadPessoas.MdiParent = this;
            frmCadPessoas.Show();
        }

        private void itmGerenciamentoPessoasExcluirPessoas_Click(object sender, EventArgs e)
        {
            frmExclusaoPessoas.MdiParent = this;
            frmExclusaoPessoas.Show();
        }

        private void itmGerenciamentoPessoasVincularCnh_Click(object sender, EventArgs e)
        {
            frmVinculacaoCnh.MdiParent = this;
            frmVinculacaoCnh.Show();
        }

        private void itmGerenciamentoPessoasHistPessoas_Click(object sender, EventArgs e)
        {
            frmHistoricoPessoas.MdiParent = this;
            frmHistoricoPessoas.Show();
        }

        private void itmGerenciamentoVeiculosCadVeiculo_Click(object sender, EventArgs e)
        {
            frmCadAutomovel.MdiParent = this;
            frmCadAutomovel.Show();
        }

        private void itmGerenciamentoVeiculosHistVeiculo_Click(object sender, EventArgs e)
        {
            frmHistoricoAutomovel.MdiParent = this;
            frmHistoricoAutomovel.Show();
        }

        private void itmGerenciamentoVeiculosExcluirVeiculo_Click(object sender, EventArgs e)
        {
            frmExclusaoAutomovel.MdiParent = this;
            frmExclusaoAutomovel.Show();
        }

        private void itmGerenciamentoLocacoesCadLocacoes_Click(object sender, EventArgs e)
        {
            frmCadLocacao.MdiParent = this;
            frmCadLocacao.Show();
        }

        private void itmGerenciamentoLocacoesHistLocacoes_Click(object sender, EventArgs e)
        {
            frmHistoricoLocacao.MdiParent = this;
            frmHistoricoLocacao.Show();
        }

        private void itmGerenciamentoLocacoesBaixaLocacao_Click(object sender, EventArgs e)
        {
            frmBaixaLocacao.MdiParent = this;
            frmBaixaLocacao.Show();
        }

     
    }
}
