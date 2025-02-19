
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;

namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmHistoricoPessoas : Form
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;
        private readonly IListarPessoaUseCase _listarPessoaUseCase;

        public FrmHistoricoPessoas(IPessoaRepositorio pessoaRepositorio, IListarPessoaUseCase listarPessoaUseCase)
        {

            InitializeComponent();
            _pessoaRepositorio = pessoaRepositorio;
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
            var dados = _listarPessoaUseCase.ExecutarDadosCompletos();
            dgvHistoricoPessoas.DataSource = dados.ToList();
            dgvHistoricoPessoas.Refresh();
        }

        private void FrmHistoricoPessoas_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}

