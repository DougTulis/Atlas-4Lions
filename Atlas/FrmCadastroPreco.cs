using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;


namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmCadastroPreco : Form
    {

        private readonly ICadastrarTabelaPrecoUseCase _cadastrarPreco;

        public FrmCadastroPreco(ICadastrarTabelaPrecoUseCase cadastrarPreco, ITabelaPrecoRepositorio precoRepositorio)
        {
            _cadastrarPreco = cadastrarPreco;
            InitializeComponent();
        }


        private void btnCadastrarPreco_Click(object sender, EventArgs e)
        {
            var precoDto = new TabelaPrecoDTO
            {
                Descricao = txtDescricao.Text,
                Valor = Convert.ToDecimal(txtValor.Text)
            };

            _cadastrarPreco.Executar(precoDto);
            MessageBox.Show("Preço cadastrado com sucesooso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadastroPreco_Load(object sender, EventArgs e)
        {

        }
    }
}
