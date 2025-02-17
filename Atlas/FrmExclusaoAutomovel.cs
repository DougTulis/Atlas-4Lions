using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmExclusaoAutomovel : Form
    {

        private readonly IAutomovelRepositorio automovelRepositorio;
        private readonly ListarAutomovelUseCase listarAutomovelUseCase;
        private readonly DeletarAutomovelUseCase deletarAutomovelUseCase;

        public FrmExclusaoAutomovel()
        {
            automovelRepositorio = new AutomovelRepositorio();
            listarAutomovelUseCase = new ListarAutomovelUseCase(automovelRepositorio);
            deletarAutomovelUseCase = new DeletarAutomovelUseCase(automovelRepositorio);
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
            var dados = listarAutomovelUseCase.ExecutarStatusGaragem();
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
                    var automovelDto = listarAutomovelUseCase.ExecutarRecuperarPorId(automovelId);
                    deletarAutomovelUseCase.Executar(automovelDto);
                    MessageBox.Show("Automóvel excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGridView();
                }
            }
        }
    }
}
