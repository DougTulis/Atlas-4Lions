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
        private readonly IAlterarStatusLocacaoUseCase _alterarStatusLocacaoUseCase;
        private readonly IAlterarStatusVeiculoUseCase _alterarStatusAutomovelUseCase;
        private readonly IListarHistoricoLocacaoUseCase _listarHistoricoLocacaoUseCase;

        public FrmBaixaLocacao(IListarHistoricoLocacaoUseCase listarHistoricoLocacaoUseCase, IAlterarStatusLocacaoUseCase alterarStatusLocacaoUseCase, IAlterarStatusVeiculoUseCase alterarStatusAutomovelUseCase)
        {
            _alterarStatusLocacaoUseCase = alterarStatusLocacaoUseCase;
            _alterarStatusAutomovelUseCase = alterarStatusAutomovelUseCase;
            _listarHistoricoLocacaoUseCase = listarHistoricoLocacaoUseCase;
            InitializeComponent();
            AtualizarGridView();
        }

        private void AtualizarGridView()
        {
            dgvBaixaLocacao.AutoGenerateColumns = false;
            dgvBaixaLocacao.DataSource = _listarHistoricoLocacaoUseCase.ExecutarLocacoesAndamento();
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
            var locacaoId = Guid.Parse(dgvBaixaLocacao.Rows[e.RowIndex].Cells[0].Value.ToString());

            var automovelId = Guid.Parse(dgvBaixaLocacao.Rows[e.RowIndex].Cells[1].Value.ToString());

            var resultadoLocacao = _alterarStatusLocacaoUseCase.ExecutarParaFinalizada(locacaoId);

            var resultadoAutomovel = _alterarStatusAutomovelUseCase.ExecutarParaGaragem(automovelId);

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
