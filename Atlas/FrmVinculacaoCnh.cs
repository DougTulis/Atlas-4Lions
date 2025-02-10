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
        private FrmVinculacaoCnh2 frmVinculacaoCnh2 = new FrmVinculacaoCnh2();

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

        private void btnVincularCnh_Click(object sender, EventArgs e)
        {
            int idPessoa = Convert.ToInt32(txtPessoa.Text);
            var PessoaDto = pessoaUseCase.ExecutarRecuperarPorId(idPessoa);
            pessoaUseCase.ExecutarRecuperarPorId(idPessoa);
            frmVinculacaoCnh2.MdiParent = this;
            frmVinculacaoCnh2.Show();
        }
    }
}
