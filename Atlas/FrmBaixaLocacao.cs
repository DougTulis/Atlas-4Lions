using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
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
            dgvBaixaLocacao.DataSource = _listarLocacoesUseCase.ExecutarRecuperacaoStatusAndamento().ToList();
            dgvBaixaLocacao.Refresh();
        }

        private void dgvBaixaLocacao_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void dgvBaixaLocacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvBaixaLocacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var locacaoId = Guid.TryParse(dgvBaixaLocacao.Rows[e.RowIndex].Cells[0].Value.ToString(), out var id) ? id : throw new Exception("ID da locação inválido!");

            var resultadoLocacao = _alterarStatusLocacaoUseCase.Executar(locacaoId, Dominio.ValueObjects.Enums.EStatusLocacao.FINALIZADA);
            var resultadoAutomovel = _alterarStatusAutomovelUseCase.Executar(locacaoId, Dominio.ValueObjects.Enums.EStatusVeiculo.GARAGEM);

            var mensagem = $"{resultadoLocacao.Mensagem}\n{resultadoAutomovel.Mensagem}";
            MessageBox.Show(mensagem, "Baixa de Locação", MessageBoxButtons.OK,
                resultadoLocacao.Procede && resultadoAutomovel.Procede ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            AtualizarGridView();
        }
        private void FrmBaixaLocacao_Load(object sender, EventArgs e)
        {
       
        }



        private void FrmBaixaLocacao_FormClosing(object sender, FormClosingEventArgs e) { }
    }
}
