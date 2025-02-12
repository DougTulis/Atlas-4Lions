using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmHistoricoLocacao : Form
    {
        private readonly ListarLocacoesUseCase listarLocacoesUseCase;
        private readonly ILocacaoRepositorio locacaoRepositorio;
        public FrmHistoricoLocacao()
        {
            locacaoRepositorio = new LocacaoRepositorio();
            listarLocacoesUseCase = new ListarLocacoesUseCase(locacaoRepositorio);
            InitializeComponent();
            AtualizarGridView();
        }

        private void dgvHistoricoLocacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AtualizarGridView()
        {
            dgvHistoricoLocacao.AutoGenerateColumns = false;
            var dados = listarLocacoesUseCase.Executar();
            dgvHistoricoLocacao.DataSource = dados.ToList();
            dgvHistoricoLocacao.Refresh();

        }
    }
}
