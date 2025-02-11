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
    public partial class FrmVinculacaoCnh : Form
    {


        private readonly IPessoaRepositorio pessoaRepositorio;
        private readonly ListarPessoaUseCase pessoaUseCase;
        public FrmVinculacaoCnh()
        {
            pessoaRepositorio = new PessoaRepositorio();
            pessoaUseCase = new ListarPessoaUseCase(pessoaRepositorio);
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
            var dados = pessoaUseCase.ExecutarRecuperacaoSemCnh();
            dgvVinculacaoCnh.DataSource = dados.ToList();
            dgvVinculacaoCnh.Refresh();
        }

        private void btnSelecionarPessoa_Click(object sender, EventArgs e)
        {
            int idPessoa = Convert.ToInt32(txtPessoa.Text);
            var PessoaDto = pessoaUseCase.ExecutarRecuperarPorId(idPessoa);
            pessoaUseCase.ExecutarRecuperarPorId(idPessoa);

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
    }
}
