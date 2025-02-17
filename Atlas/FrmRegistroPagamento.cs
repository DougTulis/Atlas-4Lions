using Org.BouncyCastle.Tls;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmRegistroPagamento : Form
    {
        private readonly IPendenciaFinanceiraRepositorio pendFinRepositorio;
        private readonly ILocacaoRepositorio locacaoRepositorio;
        private readonly IAutomovelRepositorio automovelRepositorio;
        private readonly IPessoaRepositorio pessoaRepositorio;
        private readonly ListarPendenciaFinanceiraUseCase listarPendFinUseCase;
        private FrmRegistroPagamento2 frmRegistroPagamento2;


        public FrmRegistroPagamento()
        {
            pessoaRepositorio = new PessoaRepositorio();
            automovelRepositorio = new AutomovelRepositorio();
            locacaoRepositorio = new LocacaoRepositorio(pessoaRepositorio, automovelRepositorio);
            pendFinRepositorio = new PendenciaFinanceiraRepositorio(locacaoRepositorio);
            listarPendFinUseCase = new ListarPendenciaFinanceiraUseCase(pendFinRepositorio);
            InitializeComponent();
            AtualizarGridView();
        }

        private void dgvHistoricoPendenciaFinanceiras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AtualizarGridView()
        {
            dgvHistoricoPendenciaFinanceiras.AutoGenerateColumns = false;
            dgvHistoricoPendenciaFinanceiras.DataSource = listarPendFinUseCase.Executar().ToList();
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
                frmRegistroPagamento2 = new FrmRegistroPagamento2(idSelecionado);
                frmRegistroPagamento2.ShowDialog();
            }
        }

        private void dgvHistoricoPendenciaFinanceiras_Enter(object sender, EventArgs e)
        {
        }

        private void FrmRegistroPagamento_Load(object sender, EventArgs e)
        {

        }
    }
}
