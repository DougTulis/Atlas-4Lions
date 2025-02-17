using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmBaixaLocacao : Form
    {
        private readonly ILocacaoRepositorio locacaoRepositorio;
        private readonly IAutomovelRepositorio automovelRepositorio;
        private readonly IPessoaRepositorio pessoaRepositorio;
        private readonly ListarLocacoesUseCase listarLocacoesUseCase;
        private readonly AlterarStatusLocacaoUseCase alterarStatusLocacaoUseCase;
        private readonly AlterarStatusVeiculoUseCase alterarStatusAutomovelUseCase;

        public FrmBaixaLocacao()
        {
            InitializeComponent();
            pessoaRepositorio = new PessoaRepositorio();
            locacaoRepositorio = new LocacaoRepositorio(pessoaRepositorio,automovelRepositorio);
            automovelRepositorio = new AutomovelRepositorio();
            listarLocacoesUseCase = new ListarLocacoesUseCase(locacaoRepositorio);
            alterarStatusLocacaoUseCase = new AlterarStatusLocacaoUseCase(locacaoRepositorio);
            alterarStatusAutomovelUseCase = new AlterarStatusVeiculoUseCase(automovelRepositorio);

            AtualizarGridView();
        }

        private void AtualizarGridView()
        {
            dgvBaixaLocacao.AutoGenerateColumns = false;
            dgvBaixaLocacao.DataSource = null;

            var locacoes = listarLocacoesUseCase.ExecutarRecuperacaoStatusAndamento();
            dgvBaixaLocacao.DataSource = locacoes.ToList();

            dgvBaixaLocacao.Update();
            dgvBaixaLocacao.Refresh();
        }

        private void dgvBaixaLocacao_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvBaixaLocacao.Rows[e.RowIndex];
                int idLocacao = Convert.ToInt32(row.Cells[0].Value); 

                DialogResult resultado = MessageBox.Show(
                    "Deseja finalizar esta locação?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    var locacao = listarLocacoesUseCase.ExecutarRecuperarPorId(idLocacao);

                    alterarStatusLocacaoUseCase.Executar(idLocacao, Dominio.ValueObjects.Enums.EStatusLocacao.FINALIZADO);
                    alterarStatusAutomovelUseCase.Executar(locacao.IdAutomovel, Dominio.ValueObjects.Enums.EStatusVeiculo.GARAGEM);

                    MessageBox.Show("Locação finalizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGridView();
                }
            }
        }
    }
}
