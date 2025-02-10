using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmExclusaoPessoas : Form
    {

        private readonly IPessoaRepositorio repositorio;
        private readonly DeletarPessoaUseCase deletarPessoaUseCase;
        private readonly ListarPessoaUseCase listarPessoaUseCase;
        public FrmExclusaoPessoas()
        {
            repositorio = new PessoaRepositorio();
            listarPessoaUseCase = new ListarPessoaUseCase(repositorio);
            deletarPessoaUseCase = new DeletarPessoaUseCase(repositorio);
            InitializeComponent();
            dgvHistoricoPessoasExclusaoPessoas.AutoGenerateColumns = false;
            AtualizarGridView();

        }

        private void dgvHistoricoPessoasExclusaoPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AtualizarGridView()
        {
            var dados = listarPessoaUseCase.ExecutarDadosCompletos();
            dgvHistoricoPessoasExclusaoPessoas.DataSource = dados.ToList();
            dgvHistoricoPessoasExclusaoPessoas.Refresh();
        }

        private void lblIdPessoaExclusao_Click(object sender, EventArgs e)
        {

        }

        private void txtIdPessoaExclusao_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnExcluirPessoa_Click(object sender, EventArgs e)
        {
            int.TryParse(txtIdPessoaExclusao.Text, out int _idPessoa);
            var pessoaDto = listarPessoaUseCase.ExecutarRecuperarPorId(_idPessoa);            
            deletarPessoaUseCase.Executar(pessoaDto);
            AtualizarGridView();
        }
        private void FrmExclusaoPessoas_Load(object sender, EventArgs e)
        {

        }

      
    }
}
