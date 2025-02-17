using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Servicos;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmCadLocacao : Form
    {
        private readonly LocacaoService _locacaoService;
        private readonly PendenciaFinanceiraServico _pendenciaService;
        private readonly ListarPessoaUseCase _listarPessoaUseCase;
        private readonly ListarAutomovelUseCase _listarAutomovelUseCase;
        private readonly ITabelaPrecoRepositorio _tabelaPrecoRepositorio;

        public FrmCadLocacao(
            LocacaoService locacaoService,
            PendenciaFinanceiraServico pendenciaFinanceiraService,
            ListarPessoaUseCase listarPessoaUseCase,
            ListarAutomovelUseCase listarAutomovelUseCase,
            ITabelaPrecoRepositorio tabelaPrecoRepositorio)
        {
            _locacaoService = locacaoService;
            _pendenciaService = pendenciaFinanceiraService;
            _listarPessoaUseCase = listarPessoaUseCase;
            _listarAutomovelUseCase = listarAutomovelUseCase;
            _tabelaPrecoRepositorio = tabelaPrecoRepositorio;

            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            cmbTipoLocacao.DataSource = Enum.GetValues(typeof(ETipoLocacao));
            cmbTipoLocacao.SelectedIndex = -1;
            lblParcelas.Visible = false;
            cmbParcelas.Visible = false;
            CarregarCombos();
        }

        private void CarregarCombos()
        {
            cmbLocatario.DataSource = _listarPessoaUseCase.ExecutarDadosBreves().ToList();
            cmbLocatario.DisplayMember = "Nome";
            cmbLocatario.SelectedIndex = -1;

            cmbCondutor.DataSource = _listarPessoaUseCase.ExecutarDadosBreves().ToList();
            cmbCondutor.DisplayMember = "Nome";
            cmbCondutor.SelectedIndex = -1;

            cmbAutomovel.DataSource = _listarAutomovelUseCase.ExecutarStatusGaragem().ToList();
            cmbAutomovel.DisplayMember = "Modelo";
            cmbAutomovel.SelectedIndex = -1;
        }

        private void cmbTipoLocacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoLocacao.SelectedItem == null) return;
            lblParcelas.Visible = cmbTipoLocacao.SelectedItem.Equals(ETipoLocacao.CONTRATO);
            cmbParcelas.Visible = lblParcelas.Visible;
        }

        private void btnCadastrarLocacao_Click(object sender, EventArgs e)
        {
            try
            {
                var locatarioDto = (PessoaDTO)cmbLocatario.SelectedItem;
                var condutorDto = (PessoaDTO)cmbCondutor.SelectedItem;
                var automovelDto = (AutomovelDTO)cmbAutomovel.SelectedItem;

                if (locatarioDto == null || condutorDto == null || automovelDto == null)
                {
                    MessageBox.Show("Todos os campos são obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int numeroParcelas = cmbParcelas.SelectedItem != null ? Convert.ToInt32(cmbParcelas.SelectedItem) : 1;
                DateTime dataSaida = DateTime.Parse(txtSaida.Text);
                DateTime dataRetorno = DateTime.Parse(txtRetorno.Text);

                int idLocacao = _locacaoService.CadastrarLocacao(locatarioDto, condutorDto, automovelDto, dataSaida, dataRetorno, (ETipoLocacao)cmbTipoLocacao.SelectedItem);

                int idPreco = automovelDto.IdPreco ?? throw new Exception("Preço não encontrado.");

                _pendenciaService.CriarPendenciaFinanceira(idLocacao, idPreco, numeroParcelas);

                MessageBox.Show("Locação cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar locação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔹 Mantendo TODOS os métodos de eventos para botões e labels
        private void lblDataSaida_Click(object sender, EventArgs e) { }
        private void lblDataRetorno_Click(object sender, EventArgs e) { }
        private void lblParcelas_Click(object sender, EventArgs e) { }
        private void txtSaida_TextChanged(object sender, EventArgs e) { }
        private void txtRetorno_TextChanged(object sender, EventArgs e) { }
        private void cmbLocatario_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblLocatario_Click(object sender, EventArgs e) { }
        private void FrmCadLocacao_Load(object sender, EventArgs e) { }
        private void cmbCondutor_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbAutomovel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAutomovel.SelectedItem is AutomovelDTO automovelSelecionado)
            {

                var precoDiaria = _tabelaPrecoRepositorio.RecuperarPorId(automovelSelecionado.IdPreco.Value);
                txtPreco.Text = precoDiaria.Valor.ToString("C");
            }
            else
            {
                txtPreco.Text = "";
            }
        }

        private void cmbParcelas_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
