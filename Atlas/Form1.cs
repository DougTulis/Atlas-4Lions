using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Forms;
using Projeto_ATLAS___4LIONS.Forms.Properties;
using Projeto_ATLAS___4LIONS.Infra.Servicos;

namespace Atlas
{
    public partial class Form1 : Form
    {
        private FrmCadPessoas frmCadPessoas = new FrmCadPessoas();
        private FrmCadAutomovel frmCadAutomovel = new FrmCadAutomovel();
        private FrmCadLocacao frmCadLocacao = new FrmCadLocacao();
        private FrmHistoricoPessoas frmHistoricoPessoas = new FrmHistoricoPessoas();
        private FrmExclusaoPessoas frmExclusaoPessoas = new FrmExclusaoPessoas();
        private FrmVinculacaoCnh frmVinculacaoCnh = new FrmVinculacaoCnh();


        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void airButton1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void mnuGerenciamentoPessoas_Click(object sender, EventArgs e)
        {


        }

        private void mnuGerenciamentoVeiculos_Click(object sender, EventArgs e)
        {

        }

        private void itmGerenciamentoLocacoesRegPagamento_Click(object sender, EventArgs e)
        {

        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void itmGerenciamentoPessoasCadPessoas_Click(object sender, EventArgs e)
        {
            frmCadPessoas.MdiParent = this;
            frmCadPessoas.Show();
        }

        private void itmGerenciamentoPessoasExcluirPessoas_Click(object sender, EventArgs e)
        {
            frmExclusaoPessoas.MdiParent = this;    
            frmExclusaoPessoas.Show();

        }

        private void itmGerenciamentoPessoasVincularCnh_Click(object sender, EventArgs e)
        {
            frmVinculacaoCnh.MdiParent = this;
            frmVinculacaoCnh.Show();
        }

        private void itmGerenciamentoPessoasHistPessoas_Click(object sender, EventArgs e)
        {
            frmHistoricoPessoas.MdiParent = this;
            frmHistoricoPessoas.Show();
        }

        private void itmGerenciamentoVeiculosCadVeiculo_Click(object sender, EventArgs e)
        {
            frmCadAutomovel.MdiParent = this;
            frmCadAutomovel.Show();
        }

        private void itmGerenciamentoVeiculosHistVeiculo_Click(object sender, EventArgs e)
        {

        }

        private void itmGerenciamentoVeiculosExcluirVeiculo_Click(object sender, EventArgs e)
        {

        }

        private void mnuGerenciamentoLocacoes_Click(object sender, EventArgs e)
        {

        }

        private void itmGerenciamentoLocacoesCadLocacoes_Click(object sender, EventArgs e)
        {
            frmCadLocacao.MdiParent = this;
            frmCadLocacao.Show();
        }

        private void itmGerenciamentoLocacoesHistLocacoes_Click(object sender, EventArgs e)
        {

        }

        private void itmGerenciamentoLocacoesBaixaLocacao_Click(object sender, EventArgs e)
        {

        }
    }
}