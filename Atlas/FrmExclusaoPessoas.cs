﻿using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;

namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmExclusaoPessoas : Form
    {
        private readonly IDeletarPessoaUseCase _deletarPessoaUseCase;
        private readonly IListarPessoaUseCase _listarPessoaUseCase;

        public FrmExclusaoPessoas(IDeletarPessoaUseCase deletarPessoaUseCase, IListarPessoaUseCase listarPessoaUseCase)
        {
            _deletarPessoaUseCase = deletarPessoaUseCase;
            _listarPessoaUseCase = listarPessoaUseCase;
            InitializeComponent();
            AtualizarGridView();
        }
        private void AtualizarGridView()
        {
            dgvHistoricoPessoasExclusaoPessoas.AutoGenerateColumns = false;
            dgvHistoricoPessoasExclusaoPessoas.DataSource = null;
            var dados = _listarPessoaUseCase.Executar();
            dgvHistoricoPessoasExclusaoPessoas.DataSource = dados.ToList();
            dgvHistoricoPessoasExclusaoPessoas.Update();
            dgvHistoricoPessoasExclusaoPessoas.Refresh();
        }

        private void FrmExclusaoPessoas_Load(object sender, EventArgs e)
        {
        }
        private void dgvHistoricoPessoasExclusaoPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHistoricoPessoasExclusaoPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               

                DataGridViewRow row = dgvHistoricoPessoasExclusaoPessoas.Rows[e.RowIndex];
                var pessoaId = (row.Cells[0].Value.ToString());

                DialogResult resultado = MessageBox.Show(
                    "Deseja realmente excluir esta pessoa?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    RespostaPadrao<string> resposta = _deletarPessoaUseCase.Executar(Guid.Parse(pessoaId));
                    MessageBoxIcon icone = resposta.Procede ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
                    MessageBox.Show(resposta.Dados, resposta.Mensagem, MessageBoxButtons.OK, icone);
                    AtualizarGridView();
                }
            }
        }

        private void FrmExclusaoPessoas_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
