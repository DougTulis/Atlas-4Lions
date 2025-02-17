using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;


namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmCadAutomovel : Form
    {
        private readonly ITabelaPrecoRepositorio tabelaPrecoRepositorio;
        private readonly IAutomovelRepositorio automovelRepositorio;
        private readonly CadastrarVeiculoUseCase cadastrarVeiculoUseCase;
        private readonly CadastrarPrecoAutomovelUseCase cadastrarPrecoAutomovelUseCase;
        private readonly ListarAutomovelUseCase listarAutomovelUseCase;
        private readonly ListarTabelaPrecoUseCase listarTabelaPrecoUseCase;

        public FrmCadAutomovel()
        {
            automovelRepositorio = new AutomovelRepositorio();
            tabelaPrecoRepositorio = new TabelaPrecoRepositorio();
            cadastrarVeiculoUseCase = new CadastrarVeiculoUseCase(automovelRepositorio);
            listarAutomovelUseCase = new ListarAutomovelUseCase(automovelRepositorio);
            cadastrarPrecoAutomovelUseCase = new CadastrarPrecoAutomovelUseCase(tabelaPrecoRepositorio);
            listarTabelaPrecoUseCase = new ListarTabelaPrecoUseCase(tabelaPrecoRepositorio);
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
            TabelaPrecoDTO precoSelecionado = (TabelaPrecoDTO)cbmDescricaoPreco.SelectedItem;

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
                IdPreco = precoSelecionado.Id
            };
            cadastrarVeiculoUseCase.Executar(automovelDto);

        }
        private void CarregarCombos()
        {
            cbmDescricaoPreco.DataSource = listarTabelaPrecoUseCase.Executar();
            cbmDescricaoPreco.ValueMember = "";
            cbmDescricaoPreco.SelectedIndex = -1;

        }

   
    }
}
