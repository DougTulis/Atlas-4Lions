using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
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
    public partial class FrmEditarAutomovel : Form
    {

        private IDictionary<string, string> listaAtributos = new Dictionary<string, string>()
        {
            { "Modelo","modelo" },
            {"Placa","placa"},
            {"Ano","ano"},
            { "Cor","cor"},
            { "Chassi","chassi"},
            { "Renavam","renavam"},
            { "Oleo quilometragem","oleo_km"},
            {"Pastilha Quilometragem","pastilha_freio_km" }
        };

        private readonly IListarAutomovelUseCase _listarAutomovelUseCase;
        private readonly IAlterarDadosAutomovelUseCase _alterarDadosAutomovelUseCase;

        public FrmEditarAutomovel(IListarAutomovelUseCase listarAutomovelUseCase, IAlterarDadosAutomovelUseCase alterarDadosAutomovelUseCase)
        {
            _listarAutomovelUseCase = listarAutomovelUseCase;
            _alterarDadosAutomovelUseCase = alterarDadosAutomovelUseCase;
            InitializeComponent();
            ConfigurarCombos();
        }



        private void FrmEditarAutomovel_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizarInformacao_Click(object sender, EventArgs e)
        {
            var automovelDto = (AutomovelDTO)cbmAutomovel.SelectedItem;
            var campoSelecionado = cbmAtributos.SelectedItem.ToString();
            var campoBanco = listaAtributos[campoSelecionado.ToString()];
            var valorNovo = txtNovoValor.Text;

            var resultado = _alterarDadosAutomovelUseCase.Executar(automovelDto, campoBanco, campoSelecionado, valorNovo);
            MessageBoxIcon icone = resultado.Procede ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
            MessageBox.Show(resultado.Dados, resultado.Mensagem, MessageBoxButtons.OK, icone);

            if (resultado.Procede)
            {
                LimparCampos();
                ConfigurarCombos();
            }

        }

        private void txtNovoValor_TextChanged(object sender, EventArgs e)
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

        private void cbmAutomovel_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void lblSelecionarAutomovel_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurarCombos()
        {
            cbmAutomovel.DataSource = _listarAutomovelUseCase.Executar().ToList();
            cbmAutomovel.SelectedIndex = -1;

            cbmAtributos.DataSource = listaAtributos.Keys.ToList();
            cbmAtributos.SelectedIndex = -1;

        }

        private void LimparCampos()
        {
            txtNovoValor.Clear();
            btnAtualizarInformacao.Visible = false;
            txtNovoValor.Visible = false;
            lblNovoValor.Visible = false;
            cbmAutomovel.SelectedIndex = -1;
            cbmAtributos.SelectedIndex = -1;
        }
    }
}
