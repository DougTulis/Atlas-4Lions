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
            txtBusca.PlaceholderText = "Buscar automóvel";
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

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            var lista = _listarAutomovelUseCase.Executar();
            string busca = txtBusca.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(busca))
            {
                AtualizarGridView();
                return;
            }

            var listaFiltrada = lista.Where(a => a.Modelo.ToLower().Contains(busca)||a.Placa.ToLower().Contains(busca) || a.Cor.ToLower().Contains(busca) || a.Ano.ToLower().Contains(busca) || a.Status.ToString().ToLower().Contains(busca)).ToList();

            dgvHistoricoAutomovel.DataSource = listaFiltrada;

        }
    }
}
