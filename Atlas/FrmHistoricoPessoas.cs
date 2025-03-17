
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;

namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmHistoricoPessoas : Form
    {
        private readonly IListarPessoaUseCase _listarPessoaUseCase;

        public FrmHistoricoPessoas(IListarPessoaUseCase listarPessoaUseCase)
        {

            InitializeComponent();
            _listarPessoaUseCase = listarPessoaUseCase;
            AtualizarGridView();
        }

        private void dgvHistoricoPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FrmHistoricoPessoas_Load(object sender, EventArgs e)
        {

        }
        private void AtualizarGridView()
        {
            dgvHistoricoPessoas.AutoGenerateColumns = false;
            var dados = _listarPessoaUseCase.Executar();
            dgvHistoricoPessoas.DataSource = dados.ToList();
            dgvHistoricoPessoas.Refresh();
        }

        private void FrmHistoricoPessoas_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}

