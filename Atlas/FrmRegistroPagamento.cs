using Org.BouncyCastle.Tls;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmRegistroPagamento : Form
    {
        private readonly IPendenciaFinanceiraRepositorio _pendFinRepositorio;
        private readonly ILocacaoRepositorio _locacaoRepositorio;
        private readonly IAutomovelRepositorio _automovelRepositorio;
        private readonly IPessoaRepositorio _pessoaRepositorio;
        private readonly IListarPendenciaFinanceiraUseCase _listarPendFinUseCase;
        private readonly IIncluirPagamentoUseCase _incluirPagamentoUseCase;
        private readonly IListarParcelaUseCase _listarParcelaUseCase;
        private readonly IParcelaRepositorio _parcelaRepositorio;
        private FrmRegistroPagamento2 _frmRegistroPagamento2;

        public FrmRegistroPagamento(IPendenciaFinanceiraRepositorio pendFinRepositorio, ILocacaoRepositorio locacaoRepositorio, IAutomovelRepositorio automovelRepositorio, IPessoaRepositorio pessoaRepositorio, IListarPendenciaFinanceiraUseCase listarPendFinUseCase, IIncluirPagamentoUseCase incluirPagamentoUseCase, IListarParcelaUseCase listarParcelaUseCase, IParcelaRepositorio parcelaRepositorio, FrmRegistroPagamento2 frmRegistroPagamento2)
        {
            _incluirPagamentoUseCase = incluirPagamentoUseCase;
            _listarParcelaUseCase = listarParcelaUseCase;
            _parcelaRepositorio = parcelaRepositorio;
            _frmRegistroPagamento2 = frmRegistroPagamento2;
            _listarPendFinUseCase = listarPendFinUseCase;

            InitializeComponent();
            AtualizarGridView();
        }

        private void dgvHistoricoPendenciaFinanceiras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AtualizarGridView()
        {
            dgvHistoricoPendenciaFinanceiras.AutoGenerateColumns = false;
            dgvHistoricoPendenciaFinanceiras.DataSource = _listarPendFinUseCase.Executar().ToList();
            dgvHistoricoPendenciaFinanceiras.Refresh();
        }
        private void dgvHistoricoPendenciaFinanceiras_DoubleClick(object sender, EventArgs e)
        {
        }

        private void dgvHistoricoPendenciaFinanceiras_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHistoricoPendenciaFinanceiras.Rows[e.RowIndex];
                int idSelecionado = Convert.ToInt16(dgvHistoricoPendenciaFinanceiras.Rows[e.RowIndex].Cells[0].Value);
                _frmRegistroPagamento2 = new FrmRegistroPagamento2(idSelecionado, _incluirPagamentoUseCase, _listarParcelaUseCase, _parcelaRepositorio);
                _frmRegistroPagamento2.ShowDialog();
                this.Close();
            }
        }

        private void dgvHistoricoPendenciaFinanceiras_Enter(object sender, EventArgs e)
        {
        }

        private void FrmRegistroPagamento_Load(object sender, EventArgs e)
        {

        }

        private void lblPendenciasFinanceiras_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistroPagamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
