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
        private readonly IDevolverAutomovelEncerrarLocUseCase _devolverAutomovelEncerrarLocUseCase;
        private readonly IListarHistoricoLocacaoUseCase _listarHistoricoLocacaoUseCase;

        public FrmBaixaLocacao(IDevolverAutomovelEncerrarLocUseCase devolverAutomovelEncerrarLocUseCase, IListarHistoricoLocacaoUseCase listarHistoricoLocacaoUseCase)
        {
            _devolverAutomovelEncerrarLocUseCase = devolverAutomovelEncerrarLocUseCase;
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

            var resposta = _devolverAutomovelEncerrarLocUseCase.ExecutarDevolucaoAutomovel(automovelId, locacaoId);

            MessageBoxIcon icone = resposta.Procede ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
            MessageBox.Show(resposta.Dados, resposta.Mensagem, MessageBoxButtons.OK,icone);
            AtualizarGridView();
        }
        private void FrmBaixaLocacao_Load(object sender, EventArgs e)
        {

        }
        private void FrmBaixaLocacao_FormClosing(object sender, FormClosingEventArgs e) { }
    }
}
