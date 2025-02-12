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
        private readonly ListarPendenciaFinanceiraUseCase listarPendFinUseCase;
        private FrmRegistroPagamento2 frmRegistroPagamento2 = new FrmRegistroPagamento2();

        public FrmRegistroPagamento()
        {
            pendFinRepositorio = new PendenciaFinanceiraRepositorio();
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

        private void btnPendenciasFinanceiras_Click(object sender, EventArgs e)
        {
            var pendFinDto = listarPendFinUseCase.ExecutarRecuperarPorId(int.Parse(txtPendenciasFinanceiras.Text));
            if (pendFinDto != null)
            {
                frmRegistroPagamento2.SetParametros(pendFinDto);
                frmRegistroPagamento2.Show();

            }
        }

        private void txtPendenciasFinanceiras_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvHistoricoPendenciaFinanceiras_DoubleClick(object sender, EventArgs e)
        {
        }

        private void dgvHistoricoPendenciaFinanceiras_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHistoricoPendenciaFinanceiras.Rows[e.RowIndex];
                txtPendenciasFinanceiras.Text = row.Cells[0].Value.ToString();
            }
        }

        private void dgvHistoricoPendenciaFinanceiras_Enter(object sender, EventArgs e)
        {
        }
    }
}
