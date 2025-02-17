using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;

namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmExclusaoPessoas : Form
    {
        private readonly IPessoaRepositorio repositorio;
        private readonly DeletarPessoaUseCase deletarPessoaUseCase;
        private readonly ListarPessoaUseCase listarPessoaUseCase;

        public FrmExclusaoPessoas()
        {
            repositorio = new PessoaRepositorio();
            listarPessoaUseCase = new ListarPessoaUseCase(repositorio);
            deletarPessoaUseCase = new DeletarPessoaUseCase(repositorio);
            InitializeComponent();
            AtualizarGridView();
        }

        private void AtualizarGridView()
        {
            dgvHistoricoPessoasExclusaoPessoas.AutoGenerateColumns = false;
            dgvHistoricoPessoasExclusaoPessoas.DataSource = null;
            var dados = listarPessoaUseCase.ExecutarDadosCompletos();
            dgvHistoricoPessoasExclusaoPessoas.DataSource = dados.ToList();
            dgvHistoricoPessoasExclusaoPessoas.Update();
            dgvHistoricoPessoasExclusaoPessoas.Refresh();
        }

        private void FrmExclusaoPessoas_Load(object sender, EventArgs e)
        {
        }

        private void dgvHistoricoPessoasExclusaoPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHistoricoPessoasExclusaoPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvHistoricoPessoasExclusaoPessoas.Rows[e.RowIndex];
                int pessoaId = Convert.ToInt32(row.Cells[0].Value); 

                DialogResult resultado = MessageBox.Show(
                    "Deseja realmente excluir esta pessoa?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    var pessoaDto = listarPessoaUseCase.ExecutarRecuperarPorId(pessoaId);
                    deletarPessoaUseCase.Executar(pessoaDto);
                    MessageBox.Show("Pessoa excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGridView();
                }
            }
        }
    }
}
