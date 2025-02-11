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
    public partial class FrmHistoricoAutomovel : Form
    {
        private readonly IAutomovelRepositorio automovelRepositorio;
        private readonly ListarAutomovelUseCase listarAutomovelUseCase;
        public FrmHistoricoAutomovel()
        {
            automovelRepositorio = new AutomovelRepositorio();
            listarAutomovelUseCase = new ListarAutomovelUseCase(automovelRepositorio);
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
            var dados = listarAutomovelUseCase.ExecutarDadosCompletos();
            dgvHistoricoAutomovel.DataSource = dados.ToList();
            dgvHistoricoAutomovel.Refresh();
        }
    }
}
