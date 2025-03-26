using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;


namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmCadastroPreco : Form
    {

        private readonly ICadastrarTabelaPrecoUseCase _cadastrarPreco;

        public FrmCadastroPreco(ICadastrarTabelaPrecoUseCase cadastrarPreco)
        {
            _cadastrarPreco = cadastrarPreco;
            InitializeComponent();
        }


        private void btnCadastrarPreco_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text) || string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var precoDto = new TabelaPrecoDTO
            {
                Descricao = txtDescricao.Text,
                Valor = Convert.ToDecimal(txtValor.Text)
            };

             RespostaPadrao<string> resultado = _cadastrarPreco.Executar(precoDto);
            MessageBox.Show(resultado.Dados, resultado.Mensagem, MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (resultado.Procede)
            {
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtValor.Clear();
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
