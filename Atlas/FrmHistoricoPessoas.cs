using MySqlX.XDevAPI;
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
    public partial class FrmHistoricoPessoas : Form
    {
        private readonly IPessoaRepositorio repositorio;
        private readonly ListarPessoaUseCase listarPessoaUseCase;

        public FrmHistoricoPessoas()
        {

            InitializeComponent();
            repositorio = new PessoaRepositorio();
            listarPessoaUseCase = new ListarPessoaUseCase(repositorio);
            dgvHistoricoPessoas.AutoGenerateColumns = false;
            AtualizarGridView();
        }

        private void dgvHistoricoPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AtualizarGridView()
        {
            var dados = listarPessoaUseCase.ExecutarDadosCompletos();
            dgvHistoricoPessoas.DataSource = dados.ToList();
            dgvHistoricoPessoas.Refresh();
        }

        private void FrmHistoricoPessoas_Load(object sender, EventArgs e)
        {

        }
    }
}

