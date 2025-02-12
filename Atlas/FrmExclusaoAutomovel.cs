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

        private void txtIdAutomovelExclusao_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIdAutomovelExclusao_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirAutomovel_Click(object sender, EventArgs e)
        {
            int automovelId = int.Parse(txtIdAutomovelExclusao.Text);
            var automovelDto = listarAutomovelUseCase.ExecutarRecuperarPorId(automovelId);
            deletarAutomovelUseCase.Executar(automovelDto);
            AtualizarGridView();
        }

        private void AtualizarGridView()
        {
            dgvHistoricoAutomovelExclusaoAutomovel.AutoGenerateColumns = false;
            var dados = listarAutomovelUseCase.ExecutarDadosCompletos();
            dgvHistoricoAutomovelExclusaoAutomovel.DataSource = dados.ToList();
            dgvHistoricoAutomovelExclusaoAutomovel.Refresh();
        }
    }
}
