using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmBaixaLocacao : Form
    {
        private readonly IListarLocacoesUseCase _listarLocacoesUseCase;
        private readonly IAlterarStatusLocacaoUseCase _alterarStatusLocacaoUseCase;
        private readonly IAlterarStatusVeiculoUseCase _alterarStatusAutomovelUseCase;

        public FrmBaixaLocacao(IListarLocacoesUseCase listarLocacoesUseCase, IAlterarStatusLocacaoUseCase alterarStatusLocacaoUseCase, IAlterarStatusVeiculoUseCase alterarStatusAutomovelUseCase)
        {
            _listarLocacoesUseCase = listarLocacoesUseCase;
            _alterarStatusLocacaoUseCase = alterarStatusLocacaoUseCase;
            _alterarStatusAutomovelUseCase = alterarStatusAutomovelUseCase;
            InitializeComponent();
            AtualizarGridView();
        }

        private void AtualizarGridView()
        {
            dgvBaixaLocacao.AutoGenerateColumns = false;
            dgvBaixaLocacao.DataSource = null;

            var locacoes = _listarLocacoesUseCase.ExecutarRecuperacaoStatusAndamento();
            dgvBaixaLocacao.DataSource = locacoes.ToList();
            dgvBaixaLocacao.Update();
            dgvBaixaLocacao.Refresh();
        }

        private void dgvBaixaLocacao_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void FrmBaixaLocacao_Load(object sender, EventArgs e)
        {

        }

        private void dgvBaixaLocacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmBaixaLocacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void dgvBaixaLocacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

