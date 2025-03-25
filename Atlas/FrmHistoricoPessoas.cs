
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
            txtBusca.PlaceholderText = "Buscar Pessoa";
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

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
           

            var lista = _listarPessoaUseCase.Executar();

            string busca = txtBusca.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(busca))
            {
                AtualizarGridView();
            }
            else
            {
                var listaFiltrada = lista.Where(a => a.Nome.ToLower().Contains(busca) || a.Contato.ToLower().Contains(busca) || a.Email.ToLower().Contains(busca) ||a.NumeroDocumento.ToLower().Contains(busca)||a.TipoPessoa.ToString().ToLower().Contains(busca)).ToList();

                dgvHistoricoPessoas.DataSource = listaFiltrada;
              
            }


        }
    }
}

