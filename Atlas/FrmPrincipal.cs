using Microsoft.Extensions.DependencyInjection;
using Projeto_ATLAS___4LIONS.Forms;
using System;
using System.Windows.Forms;

namespace Atlas
{
    public partial class FrmPrincipal : Form
    {
        private readonly IServiceProvider _serviceProvider;

        private FrmCadPessoas _frmCadPessoas;
        private FrmCadAutomovel _frmCadAutomovel;
        private FrmCadLocacao _frmCadLocacao;
        private FrmHistoricoPessoas _frmHistoricoPessoas;
        private FrmExclusaoPessoas _frmExclusaoPessoas;
        private FrmVinculacaoCnh _frmVinculacaoCnh;
        private FrmHistoricoAutomovel _frmHistoricoAutomovel;
        private FrmExclusaoAutomovel _frmExclusaoAutomovel;
        private FrmHistoricoLocacao _frmHistoricoLocacao;
        private FrmBaixaLocacao _frmBaixaLocacao;
        private FrmRegistroPagamento _frmRegistroPagamento;
        private FrmCadastroPreco _frmCadastroPreco;

        public FrmPrincipal(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void AbrirFormulario<T>(ref T form) where T : Form
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

            if (form == null || form.IsDisposed)
            {
              

                form = _serviceProvider.GetRequiredService<T>();
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else
            {
                form.BringToFront();

            }
        }


        private void FormPrincipal_Load(object sender, EventArgs e) { }

        private void flp_principal_Paint(object sender, PaintEventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void lblTitulo_Click(object sender, EventArgs e) { }

        private void nightControlBox1_Click(object sender, EventArgs e) { }

        private void pcbAtlas_Click(object sender, EventArgs e) { }

        private void mnuGerenciamentoPessoas_Click(object sender, EventArgs e) { }

        private void mnuGerenciamentoVeiculos_Click(object sender, EventArgs e) { }

        private void mnuGerenciamentoLocacoes_Click(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void itmGerenciamentoPessoasCadPessoas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ref _frmCadPessoas);
        }

        private void itmGerenciamentoPessoasHistPessoas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ref _frmHistoricoPessoas);
        }

        private void itmGerenciamentoPessoasExcluirPessoas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ref _frmExclusaoPessoas);
        }

        private void itmGerenciamentoPessoasVincularCnh_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ref _frmVinculacaoCnh);
        }

        private void itmGerenciamentoVeiculosCadVeiculo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ref _frmCadAutomovel);
        }

        private void itmGerenciamentoVeiculosHistVeiculo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ref _frmHistoricoAutomovel);
        }

        private void itmGerenciamentoVeiculosExcluirVeiculo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ref _frmExclusaoAutomovel);
        }

        private void itmGerenciamentoVeiculosCadastrarPreco_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ref _frmCadastroPreco);
        }

        private void itmGerenciamentoLocacoesCadLocacoes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ref _frmCadLocacao);
        }

        private void itmGerenciamentoLocacoesHistLocacoes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ref _frmHistoricoLocacao);
        }

        private void itmGerenciamentoLocacoesBaixaLocacao_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ref _frmBaixaLocacao);
        }

        private void itmGerenciamentoLocacoesRegPagamento_Click(object sender, EventArgs e)
        {
            AbrirFormulario(ref _frmRegistroPagamento);
        }
    }
}
