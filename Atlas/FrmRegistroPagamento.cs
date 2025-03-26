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

        private FrmRegistroPagamento2 _frmRegistroPagamento2;
        private readonly IListarPendenciaFinanceiraUseCase _listarPendFin;
        private readonly IIncluirPagamentoUseCase _incluirPagamentoUseCase;
        private readonly IListarParcelaUseCase _listparcelaUseCase;

        public FrmRegistroPagamento(IListarPendenciaFinanceiraUseCase listarPendFin, IIncluirPagamentoUseCase incluirPagamentoUseCase, IListarParcelaUseCase listarparcelaUseCase)
        {
            _listarPendFin = listarPendFin;
            _incluirPagamentoUseCase = incluirPagamentoUseCase;
            _listparcelaUseCase = listarparcelaUseCase;
            InitializeComponent();
            AtualizarGridView();
        }

        private void dgvHistoricoPendenciaFinanceiras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AtualizarGridView()
        {
            dgvHistoricoPendenciaFinanceiras.AutoGenerateColumns = false;
            dgvHistoricoPendenciaFinanceiras.DataSource = _listarPendFin.ExecutarPagamentosPendentes().ToList();
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
                var idSelecionado = (Guid)dgvHistoricoPendenciaFinanceiras.Rows[e.RowIndex].Cells[0].Value;

                var frmRegistroPagamento2 = new FrmRegistroPagamento2(idSelecionado, _incluirPagamentoUseCase, _listparcelaUseCase);
                frmRegistroPagamento2.ShowDialog(); 
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
