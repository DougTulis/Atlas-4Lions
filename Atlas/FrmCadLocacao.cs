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
        private readonly IPendenciaFinanceiraRepositorio pendenciaFinanceiraRepositorio;
        private readonly ITabelaPrecoRepositorio precoRepositorio;
        private readonly ListarPessoaUseCase listarPessoaUseCase;
        private readonly ListarLocacoesUseCase listarLocacoesUseCase;
        private readonly ListarAutomovelUseCase listarAutomovelUseCase;
        private readonly AlterarStatusVeiculoUseCase alterarStatusVeiculoUseCase;
        private readonly CadastrarLocacaoUseCase cadastrarLocacaoUseCase;
        private readonly AlterarStatusLocacaoUseCase alterarStatusLocacaoUseCase;
        private readonly CadastrarPendenciaFinanceiraUseCase cadastrarPendenciaFinanceiraUseCase;

        public FrmCadLocacao()
        {
            locacaoRepositorio = new LocacaoRepositorio();
            pessoaRepositorio = new PessoaRepositorio();
            automovelRepositorio = new AutomovelRepositorio();
            precoRepositorio = new TabelaPrecoRepositorio();
            pendenciaFinanceiraRepositorio = new PendenciaFinanceiraRepositorio();
            listarLocacoesUseCase = new ListarLocacoesUseCase(locacaoRepositorio);
            listarPessoaUseCase = new ListarPessoaUseCase(pessoaRepositorio);
            listarAutomovelUseCase = new ListarAutomovelUseCase(automovelRepositorio);
            alterarStatusVeiculoUseCase = new AlterarStatusVeiculoUseCase(automovelRepositorio);
            cadastrarLocacaoUseCase = new CadastrarLocacaoUseCase(locacaoRepositorio, pessoaRepositorio, automovelRepositorio);
            alterarStatusLocacaoUseCase = new AlterarStatusLocacaoUseCase(locacaoRepositorio);
            cadastrarPendenciaFinanceiraUseCase = new CadastrarPendenciaFinanceiraUseCase(pendenciaFinanceiraRepositorio, locacaoRepositorio, pessoaRepositorio, automovelRepositorio,precoRepositorio);

            InitializeComponent();
            carregarComboBox();
            cmbTipoLocacao.DataSource = Enum.GetValues(typeof(ETipoLocacao));
            cmbTipoLocacao.SelectedIndex = -1;
            lblParcelas.Visible = false;
            cmbParcelas.Visible = false;

        }

        private void lblDataSaida_Click(object sender, EventArgs e)
        {
            
        }

        private void lblDataRetorno_Click(object sender, EventArgs e)
        {

        }
        private void lblParcelas_Click(object sender, EventArgs e)
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

            if (cmbTipoLocacao.SelectedItem == null)
                return;

            ETipoLocacao tipoSelecionado = (ETipoLocacao)cmbTipoLocacao.SelectedItem;

            bool exibirParcelas = tipoSelecionado == ETipoLocacao.CONTRATO;
            lblParcelas.Visible = exibirParcelas;
            cmbParcelas.Visible = exibirParcelas;


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
        private void cmbParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnCadastrarLocacao_Click(object sender, EventArgs e)
        {
            var locatarioDto = (PessoaDTO)cmbLocatario.SelectedItem;
            var condutorDto = (PessoaDTO)cmbCondutor.SelectedItem;
            var automovelDto = (AutomovelDTO)cmbAutomovel.SelectedItem;

            var locatario = new Pessoa
            {
                Id = locatarioDto.Id,
                Nome = locatarioDto.Nome,
                Cpf = locatarioDto.Cpf,
                Contato = locatarioDto.Contato,
                Email = locatarioDto.Email,
                NumeroCnh = locatarioDto.NumeroCnh,
                VencimentoCnh = locatarioDto.VencimentoCnh,
                DataNascimento = locatarioDto.DataNascimento
            };

            var condutor = new Pessoa
            {
                Id = condutorDto.Id,
                Nome = condutorDto.Nome,
                Cpf = condutorDto.Cpf,
                Contato = condutorDto.Contato,
                Email = condutorDto.Email,
                NumeroCnh = condutorDto.NumeroCnh,
                VencimentoCnh = condutorDto.VencimentoCnh,
                DataNascimento = condutorDto.DataNascimento
            };

            var automovel = new Automovel
            {
                Id = automovelDto.Id,
                Modelo = automovelDto.Modelo,
                Placa = automovelDto.Placa,
                Cor = automovelDto.Cor,
                Status = automovelDto.Status,
                Chassi = automovelDto.Chassi,
                Renavam = automovelDto.Renavam
            };
            var locacaoDto = new LocacaoDTO
            {
                Saida = DateTime.Parse(txtSaida.Text),
                Retorno = DateTime.Parse(txtRetorno.Text),
                TipoLocacao = (ETipoLocacao)cmbTipoLocacao.SelectedItem,
                IdCondutor = condutorDto.Id,
                Status = EStatusLocacao.ANDAMENTO,
                IdAutomovel = automovelDto.Id,
                IdLocatario = locatarioDto.Id,
            };

            int idLocacao = cadastrarLocacaoUseCase.Executar(locacaoDto);

            var pendenciaDto = new PendenciaFinanceiraDTO
            {
                TransacaoId = Guid.NewGuid(),
                ValorTotal = 40,
                DataCriacao = DateTime.Now,
                IdLocacao = idLocacao,
            };
            cadastrarPendenciaFinanceiraUseCase.Executar(pendenciaDto);
            alterarStatusVeiculoUseCase.Executar(automovel.Id, EStatusVeiculo.ALUGADO);
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
