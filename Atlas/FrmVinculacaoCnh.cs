﻿using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;


namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmVinculacaoCnh : Form
    {

        private readonly IListarPessoaUseCase _listarpessoaUseCase;
        private readonly IIncluirCnhUseCase _incluirCnhUseCase;

        public FrmVinculacaoCnh(IListarPessoaUseCase listarpessoaUseCase, IIncluirCnhUseCase incluirCnhUseCase)
        {
            _listarpessoaUseCase = listarpessoaUseCase;
            _incluirCnhUseCase = incluirCnhUseCase;
            InitializeComponent();
            AtualizarGridView();
        }


        private void FrmVinculacaoCnh_Load(object sender, EventArgs e)
        {

        }

        private void dgvVinculacaoCnh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblPessoa_Click(object sender, EventArgs e)
        {

        }

        private void txtPessoa_TextChanged(object sender, EventArgs e)
        {


        }
        private void AtualizarGridView()
        {
            var dados = _listarpessoaUseCase.ExecutarRecuperacaoSemCnh();
            dgvVinculacaoCnh.DataSource = dados.ToList();
            dgvVinculacaoCnh.Refresh();
        }

        private void btnSelecionarPessoa_Click(object sender, EventArgs e)
        {
             Guid.TryParse(txtPessoa.Text, out Guid idPessoa);

            var pessoaDto = _listarpessoaUseCase.ExecutarRecuperarPorId(idPessoa);
            var pessoa = Pessoa.Create(pessoaDto.Nome,pessoaDto.Email, pessoaDto.Contato, pessoaDto.TipoPessoa, pessoaDto.NumeroDocumento, pessoaDto.DataRegistro);

           _incluirCnhUseCase.Executar(pessoa, txtNumeroCnh.Text, DateTime.Parse(txtVencimentoCnh.Text));

        }

        private void txtVencimentoCnh_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblVencimentoCnh_Click(object sender, EventArgs e)
        {

        }

        private void txtVencimentoCnh_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblNumeroCnh_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroCnh_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvVinculacaoCnh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVinculacaoCnh.Rows[e.RowIndex];
                string idSelecionado = row.Cells[0].Value.ToString();
                txtPessoa.Text = idSelecionado;

            }
        }
    }
}
