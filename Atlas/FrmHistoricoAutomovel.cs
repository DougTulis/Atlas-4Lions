using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
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
    public partial class FrmHistoricoAutomovel : Form
    {
        private readonly IListarAutomovelUseCase _listarAutomovelUseCase;
        public FrmHistoricoAutomovel(IListarAutomovelUseCase listarAutomovelUseCase)
        {
            _listarAutomovelUseCase = listarAutomovelUseCase;
            InitializeComponent();
            AtualizarGridView();
        }

        private void FrmHistoricoAutomovel_Load(object sender, EventArgs e)
        {

        }

        private void dgvHistoricoAutomovel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void AtualizarGridView()
        {
            dgvHistoricoAutomovel.AutoGenerateColumns = false;
            var dados = _listarAutomovelUseCase.Executar();
            dgvHistoricoAutomovel.DataSource = dados.ToList();
            dgvHistoricoAutomovel.Refresh();
        }

        private void FrmHistoricoAutomovel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
