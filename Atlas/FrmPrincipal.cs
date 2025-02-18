using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Forms;
using Projeto_ATLAS___4LIONS.Forms.Properties;
using Projeto_ATLAS___4LIONS.Infra.Servicos;
using Projeto_ATLAS___4LIONS.Aplicacao.Servicos;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Validacoes;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;

namespace Atlas
{
    public partial class FrmPrincipal : Form
    {
        private FrmCadPessoas _frmCadPessoas;
        private FrmCadAutomovel _frmCadAutomovel;
        private FrmCadLocacao _frmCadLocacao;
        private FrmHistoricoPessoas _frmHistoricoPessoas;
        private FrmExclusaoPessoas _frmExclusaoPessoas;
        private FrmVinculacaoCnh _frmVinculacaoCnh;
        private FrmHistoricoAutomovel _frmHistoricoAutomovel;
        private FrmExclusaoAutomovel _frmExclusaoAutomovel;
        private FrmHistoricoLocacao _frmHistoricoLocacao;
        private FrmBaixaLocacao _frmBaixaLocacao;
        private FrmRegistroPagamento _frmRegistroPagamento;

        //aki os repositorios
        private readonly IPessoaRepositorio _pessoaRepositorio;
        private readonly IAutomovelRepositorio _automovelRepositorio;
        private readonly ITabelaPrecoRepositorio _tabelaPrecoRepositorio;
        private readonly ILocacaoRepositorio _locacaoRepositorio;



        // aki use cases
        private readonly ICadastrarPessoaUseCase _cadastrarPessoaUseCase;
        private readonly ICadastrarVeiculoUseCase _cadastrarVeiculoUseCase;
        private readonly ICadastrarTabelaPrecoUseCase _cadastrarTabelaPrecoUseCase;
        private readonly IListarAutomovelUseCase _listarAutomovelUseCase;
        private readonly IListarTabelaPrecoUseCase _listartabelaPrecoUseCase;
        private readonly IListarHistoricoLocacaoUseCase _listarHistoricoLocacaoUseCase;

        public FrmPrincipal(FrmCadPessoas frmCadPessoas, FrmCadAutomovel frmCadAutomovel, FrmCadLocacao frmCadLocacao, FrmHistoricoPessoas frmHistoricoPessoas, FrmExclusaoPessoas frmExclusaoPessoas, FrmVinculacaoCnh frmVinculacaoCnh, FrmHistoricoAutomovel frmHistoricoAutomovel, FrmExclusaoAutomovel frmExclusaoAutomovel, FrmHistoricoLocacao frmHistoricoLocacao, FrmBaixaLocacao frmBaixaLocacao, FrmRegistroPagamento frmRegistroPagamento, IPessoaRepositorio pessoaRepositorio, IAutomovelRepositorio automovelRepositorio, ITabelaPrecoRepositorio tabelaPrecoRepositorio, ILocacaoRepositorio locacaoRepositorio, ICadastrarPessoaUseCase cadastrarPessoaUseCase, ICadastrarVeiculoUseCase cadastrarVeiculoUseCase, ICadastrarTabelaPrecoUseCase cadastrarTabelaPrecoUseCase, IListarAutomovelUseCase listarAutomovelUseCase, IListarTabelaPrecoUseCase listartabelaPrecoUseCase, IListarHistoricoLocacaoUseCase listarHistoricoLocacaoUseCase)
        {
            _frmCadPessoas = frmCadPessoas;
            _frmCadAutomovel = frmCadAutomovel;
            _frmCadLocacao = frmCadLocacao;
            _frmHistoricoPessoas = frmHistoricoPessoas;
            _frmExclusaoPessoas = frmExclusaoPessoas;
            _frmVinculacaoCnh = frmVinculacaoCnh;
            _frmHistoricoAutomovel = frmHistoricoAutomovel;
            _frmExclusaoAutomovel = frmExclusaoAutomovel;
            _frmHistoricoLocacao = frmHistoricoLocacao;
            _frmBaixaLocacao = frmBaixaLocacao;
            _frmRegistroPagamento = frmRegistroPagamento;
            _pessoaRepositorio = pessoaRepositorio;
            _automovelRepositorio = automovelRepositorio;
            _tabelaPrecoRepositorio = tabelaPrecoRepositorio;
            _locacaoRepositorio = locacaoRepositorio;
            _cadastrarPessoaUseCase = cadastrarPessoaUseCase;
            _cadastrarVeiculoUseCase = cadastrarVeiculoUseCase;
            _cadastrarTabelaPrecoUseCase = cadastrarTabelaPrecoUseCase;
            _listarAutomovelUseCase = listarAutomovelUseCase;
            _listartabelaPrecoUseCase = listartabelaPrecoUseCase;
            _listarHistoricoLocacaoUseCase = listarHistoricoLocacaoUseCase;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

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
            _frmRegistroPagamento.MdiParent = this;
            _frmRegistroPagamento.Show();
        }

        private void nightControlBox1_Click(object sender, EventArgs e) { }

        private void itmGerenciamentoPessoasCadPessoas_Click(object sender, EventArgs e)
        {
            _frmCadPessoas.MdiParent = this;
            _frmCadPessoas.Show();
        }

        private void itmGerenciamentoPessoasExcluirPessoas_Click(object sender, EventArgs e)
        {
            _frmExclusaoPessoas.MdiParent = this;
            _frmExclusaoPessoas.Show();
        }

        private void itmGerenciamentoPessoasVincularCnh_Click(object sender, EventArgs e)
        {
            _frmVinculacaoCnh.MdiParent = this;
            _frmVinculacaoCnh.Show();
        }

        private void itmGerenciamentoPessoasHistPessoas_Click(object sender, EventArgs e)
        {
            _frmHistoricoPessoas.MdiParent = this;
            _frmHistoricoPessoas.Show();
        }

        private void itmGerenciamentoVeiculosCadVeiculo_Click(object sender, EventArgs e)
        {
            _frmCadAutomovel.MdiParent = this;
            _frmCadAutomovel.Show();
        }

        private void itmGerenciamentoVeiculosHistVeiculo_Click(object sender, EventArgs e)
        {
            _frmHistoricoAutomovel.MdiParent = this;
            _frmHistoricoAutomovel.Show();
        }

        private void itmGerenciamentoVeiculosExcluirVeiculo_Click(object sender, EventArgs e)
        {
            _frmExclusaoAutomovel.MdiParent = this;
            _frmExclusaoAutomovel.Show();
        }

        private void itmGerenciamentoLocacoesCadLocacoes_Click(object sender, EventArgs e)
        {
            _frmCadLocacao.MdiParent = this;
            _frmCadLocacao.Show();
        }

        private void itmGerenciamentoLocacoesHistLocacoes_Click(object sender, EventArgs e)
        {
            _frmHistoricoLocacao.MdiParent = this;
            _frmHistoricoLocacao.Show();
        }

        private void itmGerenciamentoLocacoesBaixaLocacao_Click(object sender, EventArgs e)
        {
            _frmBaixaLocacao.MdiParent = this;
            _frmBaixaLocacao.Show();
        }

        private void pcbAtlas_Click(object sender, EventArgs e)
        {

        }
    }
}
