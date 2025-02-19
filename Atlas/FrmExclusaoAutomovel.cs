using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;

namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmExclusaoAutomovel : Form
    {

        private readonly IAutomovelRepositorio _automovelRepositorio;
        private readonly IListarAutomovelUseCase _listarAutomovelUseCase;
        private readonly IDeletarAutomovelUseCase _deletarAutomovelUseCase;

        public FrmExclusaoAutomovel(IAutomovelRepositorio automovelRepositorio, IListarAutomovelUseCase listarAutomovelUseCase, IDeletarAutomovelUseCase deletarAutomovelUseCase)
        {
            _automovelRepositorio = automovelRepositorio;
            _listarAutomovelUseCase = listarAutomovelUseCase;
            _deletarAutomovelUseCase = deletarAutomovelUseCase;
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
            dgvHistoricoAutomovelExclusaoAutomovel.Update();
            dgvHistoricoAutomovelExclusaoAutomovel.Refresh();
        }


        private void dgvHistoricoAutomovelExclusaoAutomovel_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHistoricoAutomovelExclusaoAutomovel.Rows[e.RowIndex];
                int automovelId = Convert.ToInt32(row.Cells[0].Value);

                DialogResult resultado = MessageBox.Show(
                    "Deseja realmente excluir este automóvel?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    var automovelDto = _listarAutomovelUseCase.ExecutarRecuperarPorId(automovelId);
                    _deletarAutomovelUseCase.Executar(automovelDto);
                    MessageBox.Show("Automóvel excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
