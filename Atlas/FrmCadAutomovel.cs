using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;


namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmCadAutomovel : Form
    {

        private readonly ICadastrarVeiculoUseCase _cadastrarVeiculoUseCase;
        private readonly ICadastrarTabelaPrecoUseCase _cadastrarPrecoAutomovelUseCase;
        private readonly IListarAutomovelUseCase _listarAutomovelUseCase;
        private readonly IListarTabelaPrecoUseCase _listarTabelaPrecoUseCase;

        public FrmCadAutomovel(ICadastrarVeiculoUseCase cadastrarVeiculoUseCase, ICadastrarTabelaPrecoUseCase cadastrarPrecoAutomovelUseCase, IListarAutomovelUseCase listarAutomovelUseCase, IListarTabelaPrecoUseCase listarTabelaPrecoUseCase)
        {
            _cadastrarVeiculoUseCase = cadastrarVeiculoUseCase;
            _cadastrarPrecoAutomovelUseCase = cadastrarPrecoAutomovelUseCase;
            _listarAutomovelUseCase = listarAutomovelUseCase;
            _listarTabelaPrecoUseCase = listarTabelaPrecoUseCase;
            InitializeComponent();
            CarregarCombos();
        }

        private void FrmCadAutomovel_Load(object sender, EventArgs e)
        {

        }

        private void lblModelo_Click(object sender, EventArgs e)
        {

        }

        private void lblPlaca_Click(object sender, EventArgs e)
        {

        }

        private void lblCor_Click(object sender, EventArgs e)
        {

        }

        private void lblChassi_Click(object sender, EventArgs e)
        {

        }

        private void lblOleoKm_Click(object sender, EventArgs e)
        {

        }

        private void lblFreioKm_Click(object sender, EventArgs e)
        {

        }

        private void lblDescricaoPreco_Click(object sender, EventArgs e)
        {

        }

        private void lblPreco_Click(object sender, EventArgs e)
        {

        }

        private void lblAno_Click(object sender, EventArgs e)
        {

        }


        private void txtCor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChassi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRenavam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOleoKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFreioKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbmDescricaoPreco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnCadastrarAutomovel_Click(object sender, EventArgs e)
        {
            var precoSelecionado = (TabelaPrecoDTO)cbmDescricaoPreco.SelectedItem;
            var automovelDto = new AutomovelDTO
            {
                Status = Dominio.ValueObjects.Enums.EStatusVeiculo.GARAGEM,
                DataCriacao = DateTime.Now,
                Modelo = txtModelo.Text,
                Ano = txtAno.Text,
                Cor = txtCor.Text,
                Placa = txtPlaca.Text,
                Chassi = txtChassi.Text,
                Renavam = txtRenavam.Text,
                Oleokm = int.TryParse(txtOleoKm.Text, out int oleo) ? oleo : null,
                PastilhaFreioKm = int.TryParse(txtFreioKm.Text, out int freio) ? freio : null,
                IdPreco = precoSelecionado.Id,

            };
            RespostaPadrao<string> resposta = _cadastrarVeiculoUseCase.Executar(automovelDto);
            MessageBoxIcon icone = resposta.Procede ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
            MessageBox.Show(resposta.Mensagem, "Cadastro de Automóvel", MessageBoxButtons.OK, icone);
        }
        private void CarregarCombos()
        {
            cbmDescricaoPreco.DataSource = _listarTabelaPrecoUseCase.Executar();
            cbmDescricaoPreco.ValueMember = "";
            cbmDescricaoPreco.SelectedIndex = -1;
        }

        private void FrmCadAutomovel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
