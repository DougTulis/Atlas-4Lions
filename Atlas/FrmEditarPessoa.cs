using Org.BouncyCastle.Ocsp;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using System;
using System.Collections;
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
    public partial class FrmEditarPessoa : Form
    {

        private IDictionary<string, string> listaCampos = new Dictionary<string, string>()
        {
            {"Nome Completo", "nome"},
            {"Email", "email"},
            {"Data Nascimento", "data_nascimento"},
            {"CPF/CNPJ", "numero_documento"},
            {"Numero de contato", "contato"},

        };

        private readonly IListarPessoaUseCase _listarPessoaUseCase;
        private readonly IAtualizarDadosPessoaUseCase _atualizarDadosPessoaUseCase;

        public FrmEditarPessoa(IListarPessoaUseCase listarPessoaUseCase, IAtualizarDadosPessoaUseCase atualizarDadosPessoaUseCase)
        {
            _listarPessoaUseCase = listarPessoaUseCase;
            _atualizarDadosPessoaUseCase = atualizarDadosPessoaUseCase;
            InitializeComponent();
            ConfigurarCombos();
        }

        private void FrmEditarPessoa_Load(object sender, EventArgs e)
        {

        }
        private void cbmPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cbmAtributos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmAtributos.SelectedIndex == -1)
            {
                txtNovoValor.Visible = false;
                lblNovoValor.Visible = false;
                btnAtualizarInformacao.Visible = false;
            }
            else
            {
                txtNovoValor.Visible = true;
                lblNovoValor.Visible = true;
                btnAtualizarInformacao.Visible = true;
            }

        }
        private void txtNovoValor_TextChanged(object sender, EventArgs e)
        {

        }
        private void lblNovoValor_Click(object sender, EventArgs e)
        {

        }
        private void ConfigurarCombos()
        {
            cbmPessoa.DataSource = _listarPessoaUseCase.Executar();
            cbmPessoa.SelectedIndex = -1;
            cbmAtributos.DataSource = listaCampos.Keys.ToList();
            cbmAtributos.SelectedIndex = -1;

            txtNovoValor.Visible = false;
            lblNovoValor.Visible = false;
            btnAtualizarInformacao.Visible = false;

        }

        private void btnAtualizarInformacao_Click(object sender, EventArgs e)
        {
            var pessoaSelecionada = (PessoaDTO)cbmPessoa.SelectedItem;
            var campoSelecionado = cbmAtributos.SelectedItem.ToString();
            var campoBanco = listaCampos[campoSelecionado];
            var valorNovo = txtNovoValor.Text;
            RespostaPadrao<string> resultado = _atualizarDadosPessoaUseCase.Executar(pessoaSelecionada, campoBanco,campoSelecionado, valorNovo);
            MessageBoxIcon icone = resultado.Procede ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
            MessageBox.Show(resultado.Dados,resultado.Mensagem,MessageBoxButtons.OK ,icone);

            if (resultado.Procede)
            {
                LimparCampos();
                ConfigurarCombos();
            }
        }

        private void LimparCampos()
        {
            txtNovoValor.Clear();
            btnAtualizarInformacao.Visible = false;
            txtNovoValor.Visible = false;
            lblNovoValor.Visible = false;
            cbmPessoa.SelectedIndex = -1;
            cbmAtributos.SelectedIndex = -1;
        }
    }
}
