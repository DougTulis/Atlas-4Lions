using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmCadPessoas : Form
    {
        private readonly ICadastrarPessoaUseCase _cadastrarPessoaUseCase;
        public FrmCadPessoas(ICadastrarPessoaUseCase cadastrarPessoaUseCase)
        {
            _cadastrarPessoaUseCase = cadastrarPessoaUseCase;

            InitializeComponent();
            CarregarCombos();
        }

        private void FecharFormulario<T>()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Close();
            }
        }


        private void cbmTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContato_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataNascimento_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadPessoas_Load(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblContato_Click(object sender, EventArgs e)
        {

        }

        private void lblDataNascimento_Click(object sender, EventArgs e)
        {

        }
        private void lblNumeroDocumento_Click(object sender, EventArgs e)
        {

        }
        private void btnCadastrarPessoa_Click(object sender, EventArgs e)
        {

            var pessoaDto = new PessoaDTO
            {
                Nome = textNome.Text,
                Email = txtEmail.Text,
                Contato = txtContato.Text,
                DataRegistro = DateTime.TryParse(txtDataNascimento.Text, out DateTime data) ? data : DateTime.MinValue,
                TipoPessoa = (ETipoPessoa)cbmTipoPessoa.SelectedItem,
                NumeroDocumento = txtNumeroDocumento.Text,
            };


            RespostaPadrao<string> resultado = _cadastrarPessoaUseCase.Executar(pessoaDto);
            MessageBoxIcon icone = resultado.Procede ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
            MessageBox.Show(resultado.Mensagem, "Cadastro de Pessoa", MessageBoxButtons.OK, icone);
        }

        private void CarregarCombos()
        {
            cbmTipoPessoa.DataSource = Enum.GetValues(typeof(ETipoPessoa));
            cbmTipoPessoa.SelectedIndex = -1;
        }

        private void FrmCadPessoas_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
