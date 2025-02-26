using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.Servicos;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmCadLocacao : Form
    {

        private readonly IListarPessoaUseCase _listarPessoaUseCase;
        private readonly IListarAutomovelUseCase _listarAutomovelUseCase;
        private readonly IListarTabelaPrecoUseCase _listarTabelaPrecoUseCase;

        public FrmCadLocacao(IListarPessoaUseCase listarPessoaUseCase, IListarAutomovelUseCase listarAutomovelUseCase, IListarTabelaPrecoUseCase listarTabelaPrecoUseCase)
        {
            _listarPessoaUseCase = listarPessoaUseCase;
            _listarAutomovelUseCase = listarAutomovelUseCase;
            _listarTabelaPrecoUseCase = listarTabelaPrecoUseCase;
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            cmbTipoLocacao.DataSource = Enum.GetValues(typeof(ETipoLocacao));
            cmbTipoLocacao.SelectedIndex = -1;
            lblParcelas.Visible = false;
            cmbParcelas.Visible = false;
            CarregarCombos();
        }

        private void CarregarCombos()
        {
            cmbLocatario.DataSource = _listarPessoaUseCase.ExecutarDadosBreves().ToList();
            cmbLocatario.DisplayMember = "Nome";
            cmbLocatario.SelectedIndex = -1;

            cmbCondutor.DataSource = _listarPessoaUseCase.ExecutarDadosBreves().ToList();
            cmbCondutor.DisplayMember = "Nome";
            cmbCondutor.SelectedIndex = -1;

            cmbAutomovel.DataSource = _listarAutomovelUseCase.ExecutarStatusGaragem().ToList();
            cmbAutomovel.DisplayMember = "Modelo";
            cmbAutomovel.SelectedIndex = -1;
        }

        private void cmbTipoLocacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblParcelas.Visible = cmbTipoLocacao.SelectedItem.Equals(ETipoLocacao.CONTRATO);
            cmbParcelas.Visible = lblParcelas.Visible;
        }

        private void btnCadastrarLocacao_Click(object sender, EventArgs e)
        {
         
                var locatarioDto = (PessoaDTO)cmbLocatario.SelectedItem;
                var condutorDto = (PessoaDTO)cmbCondutor.SelectedItem;
                var automovelDto = (AutomovelDTO)cmbAutomovel.SelectedItem;

                if (locatarioDto == null || condutorDto == null || automovelDto == null)
                {
                    MessageBox.Show("Todos os campos são obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int numeroParcelas = cmbParcelas.SelectedItem != null ? Convert.ToInt32(cmbParcelas.SelectedItem) : 1;
                DateTime dataSaida = DateTime.Parse(txtSaida.Text);
                DateTime dataRetorno = DateTime.Parse(txtRetorno.Text);

                var locacao = Locacao.Create(dataSaida, dataRetorno, (ETipoLocacao)cmbTipoLocacao.SelectedItem, locatarioDto.Id, condutorDto.Id, automovelDto.Id);

            }
        private void lblDataSaida_Click(object sender, EventArgs e) { }
        private void lblDataRetorno_Click(object sender, EventArgs e) { }
        private void lblParcelas_Click(object sender, EventArgs e) { }
        private void txtSaida_TextChanged(object sender, EventArgs e) { }
        private void txtRetorno_TextChanged(object sender, EventArgs e) { }
        private void cmbLocatario_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblLocatario_Click(object sender, EventArgs e) { }
        private void FrmCadLocacao_Load(object sender, EventArgs e) { }
        private void cmbCondutor_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbAutomovel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAutomovel.SelectedItem is AutomovelDTO automovelSelecionado)
            {

                var precoDiaria = _listarTabelaPrecoUseCase.ExecutarRecuperarPorId(automovelSelecionado.IdPreco);
                txtPreco.Text = precoDiaria.Valor.ToString("C");
            }
            else
            {
                txtPreco.Text = "";
            }
        }

        private void cmbParcelas_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadLocacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
