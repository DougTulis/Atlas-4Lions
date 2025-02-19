using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
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


        private readonly IPessoaRepositorio _pessoaRepositorio;
        private readonly IListarPessoaUseCase _listarpessoaUseCase;
        private readonly IIncluirCnhUseCase _incluirCnhUseCase;

        public FrmVinculacaoCnh(IPessoaRepositorio pessoaRepositorio, IIncluirCnhUseCase incluirCnhUseCase, IListarPessoaUseCase listarPessoaUseCase)
        {
            _pessoaRepositorio = pessoaRepositorio;
            _listarpessoaUseCase = listarPessoaUseCase;
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
            int idPessoa = Convert.ToInt32(txtPessoa.Text);
            var pessoaDto = _listarpessoaUseCase.ExecutarRecuperarPorId(idPessoa);
            _incluirCnhUseCase.Executar(pessoaDto, txtNumeroCnh.Text, DateTime.Parse(txtVencimentoCnh.Text));
            MessageBox.Show("CNH vinculada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
                int idSelecionado = Convert.ToInt16(dgvVinculacaoCnh.Rows[e.RowIndex].Cells[0].Value);
                txtPessoa.Text = Convert.ToString(idSelecionado);

            }
        }
    }
}
