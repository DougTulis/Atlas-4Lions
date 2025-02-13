using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
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
    public partial class FrmCadLocacao : Form
    {

        private readonly ILocacaoRepositorio locacaoRepositorio;
        private readonly IPessoaRepositorio pessoaRepositorio;
        private readonly IAutomovelRepositorio automovelRepositorio;
        private readonly ListarPessoaUseCase listarPessoaUseCase;
        private readonly ListarLocacoesUseCase listarLocacoesUseCase;
        private readonly ListarAutomovelUseCase listarAutomovelUseCase;

        public FrmCadLocacao()
        {
            locacaoRepositorio = new LocacaoRepositorio();
            pessoaRepositorio = new PessoaRepositorio();
            automovelRepositorio = new AutomovelRepositorio();
            listarLocacoesUseCase = new ListarLocacoesUseCase(locacaoRepositorio);
            listarPessoaUseCase = new ListarPessoaUseCase(pessoaRepositorio);
            listarAutomovelUseCase = new ListarAutomovelUseCase(automovelRepositorio);

            InitializeComponent();
            carregarComboBox();

        }

        private void lblDataSaida_Click(object sender, EventArgs e)
        {

        }

        private void lblDataRetorno_Click(object sender, EventArgs e)
        {

        }
        private void txtSaida_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRetorno_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoLocacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTipoLocacao.DataSource = Enum.GetValues(typeof(ETipoLocacao));

        }
        private void cmbLocatario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblLocatario_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadLocacao_Load(object sender, EventArgs e)
        {

        }
        private void cmbCondutor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbAutomovel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnCadastrarLocacao_Click(object sender, EventArgs e)
        {
            var locacaoDto = new LocacaoDTO
            {
                Saida = DateTime.Parse(txtSaida.Text),
                Retorno = DateTime.Parse(txtRetorno.Text),
                TipoLocacao = (ETipoLocacao)cmbTipoLocacao.SelectedItem,
                Condutor = (Pessoa)cmbCondutor.SelectedItem,
                Locatario = (Pessoa)cmbLocatario.SelectedItem,
                Automovel = (Automovel)cmbLocatario.SelectedItem



            };

        }

        private void carregarComboBox()
        {
            cmbLocatario.DataSource = listarPessoaUseCase.ExecutarDadosBreves().ToList();
            cmbCondutor.DataSource = listarPessoaUseCase.ExecutarDadosBreves().ToList();
            cmbAutomovel.DataSource = listarAutomovelUseCase.ExecutarStatusGaragem().ToList();

            cmbLocatario.DisplayMember = "Nome";
            cmbLocatario.ValueMember = "";

            cmbCondutor.DisplayMember = "Nome";
            cmbCondutor.ValueMember = "";

            cmbAutomovel.DisplayMember = "Modelo";
            cmbAutomovel.ValueMember = "";

            cmbLocatario.SelectedIndex = -1;
            cmbCondutor.SelectedIndex = -1;
            cmbAutomovel.SelectedIndex = -1;

            cmbLocatario.Refresh();
            cmbCondutor.Refresh();
            cmbAutomovel.Refresh();
        }

    
    }
}
