using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;

namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmExclusaoAutomovel : Form
    {

        private readonly IListarAutomovelUseCase _listarAutomovelUseCase;
        private readonly IDeletarAutomovelUseCase _deletarAutomovelUseCase;

        public FrmExclusaoAutomovel(IListarAutomovelUseCase listarAutomovelUseCase, IDeletarAutomovelUseCase deletarAutomovelUseCase)
        {
            _listarAutomovelUseCase = listarAutomovelUseCase;
            _deletarAutomovelUseCase = deletarAutomovelUseCase;
            InitializeComponent();
            AtualizarGridView();

        }
        private void dgvHistoricoAutomovelExclusaoAutomovel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AtualizarGridView()
        {
            dgvHistoricoAutomovelExclusaoAutomovel.AutoGenerateColumns = false;
            dgvHistoricoAutomovelExclusaoAutomovel.DataSource = null;
            var dados = _listarAutomovelUseCase.ExecutarStatusGaragem();
            dgvHistoricoAutomovelExclusaoAutomovel.DataSource = dados.ToList();
            dgvHistoricoAutomovelExclusaoAutomovel.Refresh();
        }


        private void dgvHistoricoAutomovelExclusaoAutomovel_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHistoricoAutomovelExclusaoAutomovel.Rows[e.RowIndex];
                var automovelId = (row.Cells[0].Value).ToString();

                DialogResult resultado = MessageBox.Show(
                    "Deseja realmente excluir este automóvel?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    var automovelDto = _listarAutomovelUseCase.ExecutarRecuperarPorId(Guid.Parse(automovelId));
                   var resposta =  _deletarAutomovelUseCase.Executar(automovelDto);
                    MessageBoxIcon icone = resposta.Procede ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
                    MessageBox.Show(resposta.Mensagem, "Exclusão de Automóveis", MessageBoxButtons.OK, icone);

                    AtualizarGridView();
                }
            }
        }

        private void FrmExclusaoAutomovel_Load(object sender, EventArgs e)
        {

        }

        private void FrmExclusaoAutomovel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
