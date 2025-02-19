using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmHistoricoLocacao : Form
    {

        private readonly IPessoaRepositorio _pessoaRepositorio;
        private readonly ILocacaoRepositorio _locacaoRepositorio;
        private readonly IListarHistoricoLocacaoUseCase _listarHistoricoLocacaoUseCase;

        public FrmHistoricoLocacao(IPessoaRepositorio pessoaRepositorio, ILocacaoRepositorio locacaoRepositorio, IListarHistoricoLocacaoUseCase listarHistoricoLocacaoUseCase)
        {
            _pessoaRepositorio = pessoaRepositorio;
            _locacaoRepositorio = locacaoRepositorio;
            _listarHistoricoLocacaoUseCase = listarHistoricoLocacaoUseCase;
            InitializeComponent();
            AtualizarGridView();
        }
        private void dgvHistoricoLocacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AtualizarGridView()
        {
            dgvHistoricoLocacao.AutoGenerateColumns = false;
            var dados = _listarHistoricoLocacaoUseCase.Executar().ToList();
            dgvHistoricoLocacao.DataSource = dados.ToList();
            dgvHistoricoLocacao.Refresh();

        }

        private void FrmHistoricoLocacao_Load(object sender, EventArgs e)
        {

        }

        private void FrmHistoricoLocacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
