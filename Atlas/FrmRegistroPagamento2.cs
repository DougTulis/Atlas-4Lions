using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
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
    public partial class FrmRegistroPagamento2 : Form
    {
        private int idPendFin;
        private int idParcelaSelecionada;
        private readonly IParcelaRepositorio _parcelaRepositorio;
        private readonly ListarParcelaUseCase _listarParcelaUseCase;
        private readonly IncluirPagamentoUseCase _incluirPagamentoUseCase;
        
        public FrmRegistroPagamento2()
        {
            InitializeComponent();
        }
        public FrmRegistroPagamento2(int _Idpendfin)
        {
            _parcelaRepositorio = new ParcelaRepositorio();
            _listarParcelaUseCase = new ListarParcelaUseCase(_parcelaRepositorio);
            _incluirPagamentoUseCase = new IncluirPagamentoUseCase(_parcelaRepositorio);
            idPendFin = _Idpendfin;
            InitializeComponent();

            MessageBox.Show(Convert.ToString(idPendFin));

            cmbEspeciePagamento.DataSource = Enum.GetValues(typeof(EEspecie));
            cmbEspeciePagamento.SelectedIndex = -1;
            AtualizarGridView();
        }

        private void lblSequenciaParcela_Click(object sender, EventArgs e)
        {

        }

        private void lblValorPago_Click(object sender, EventArgs e)
        {

        }

        private void lblDataPagamento_Click(object sender, EventArgs e)
        {

        }

        private void lblEspeciePagamento_Click(object sender, EventArgs e)
        {

        }

        private void txtParcelaSelecionada_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataPagamento_TextChanged(object sender, EventArgs e)
        {

        }


        private void dgvParcelasPendFinEscolhida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmRegistroPagamento2_Load(object sender, EventArgs e)
        {

        }
        private void cmbEspeciePagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarPagamento_Click(object sender, EventArgs e)
        {
            idParcelaSelecionada = Convert.ToInt16(txtParcelaSelecionada.Text);
            var parcelaSelecionada = (ParcelaDTO)_listarParcelaUseCase.ExecutarRecuperacaoPorId(idParcelaSelecionada);
            parcelaSelecionada.PendenciaFinanceiraId = idPendFin;
            parcelaSelecionada.ValorPago = Convert.ToDecimal(txtValorPago.Text);
            parcelaSelecionada.DataPagamento = Convert.ToDateTime(txtDataPagamento.Text);
            parcelaSelecionada.EspeciePagamento = (EEspecie)cmbEspeciePagamento.SelectedItem;
            _incluirPagamentoUseCase.Executar(parcelaSelecionada);
            MessageBox.Show("OK PAGAMENTO REALIZADO, UPDATE FEITO");
        }

        private void AtualizarGridView()
        {
            dgvParcelasPendFinEscolhida.AutoGenerateColumns = false;
            var dados = _listarParcelaUseCase.ExecutarRecuperacaoPorPendFin(idPendFin).ToList();
            dgvParcelasPendFinEscolhida.DataSource = dados;
            dgvParcelasPendFinEscolhida.Refresh();
        }

        private void dgvParcelasPendFinEscolhida_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvParcelasPendFinEscolhida.Rows[e.RowIndex];
                int idSelecionado = Convert.ToInt16(dgvParcelasPendFinEscolhida.Rows[e.RowIndex].Cells[0].Value);
                txtParcelaSelecionada.Text = Convert.ToString(idSelecionado);

            }
        }
    }
}
