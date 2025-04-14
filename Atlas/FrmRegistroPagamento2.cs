using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_ATLAS___4LIONS.Forms
{
    public partial class FrmRegistroPagamento2 : Form
    {
        private Guid idPendFin;
        private readonly IListarParcelaUseCase _listarParcelaUseCase;
        private readonly IIncluirPagamentoUseCase _incluirPagamentoUseCase;

        public FrmRegistroPagamento2()
        {
            InitializeComponent();
        }

        public FrmRegistroPagamento2(Guid _Idpendfin, IIncluirPagamentoUseCase incluirPagamentoUseCase, IListarParcelaUseCase listarParcelaUseCase)
            : this()
        {
            _listarParcelaUseCase = listarParcelaUseCase;
            _incluirPagamentoUseCase = incluirPagamentoUseCase;
            idPendFin = _Idpendfin;

            cmbEspeciePagamento.DataSource = Enum.GetValues(typeof(EEspecie));
            cmbEspeciePagamento.SelectedIndex = -1;

            AtualizarGridView();
        }

        private void btnRegistrarPagamento_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(
                "Deseja realmente registrar o pagamento?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            Guid.TryParse(txtParcelaSelecionada.Text, out var parcelaId);
           
            var parcelaSelecionada = _listarParcelaUseCase.ExecutarRecuperacaoPorId(parcelaId);


            parcelaSelecionada.PendenciaFinanceiraId = idPendFin;
            parcelaSelecionada.ValorPago = decimal.TryParse(txtValorPago.Text, out var valorPago) ? valorPago : 0;
            parcelaSelecionada.DataPagamento = DateTime.TryParse(txtDataPagamento.Text, out var dataPagamento) ? dataPagamento : (DateTime?)null;
            parcelaSelecionada.EspeciePagamento = (EEspecie?)cmbEspeciePagamento.SelectedItem;

            var resultado = _incluirPagamentoUseCase.Executar(parcelaSelecionada);

            MessageBox.Show(resultado.Dados, resultado.Mensagem, MessageBoxButtons.OK,
                resultado.Procede ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (resultado.Procede)
            {
                LimparCampos();

            }
            AtualizarGridView();

        }

        private void AtualizarGridView()
        {
            dgvParcelasPendFinEscolhida.AutoGenerateColumns = false;
            dgvParcelasPendFinEscolhida.DataSource = _listarParcelaUseCase.ExecutarRecuperacaoPorPendFin(idPendFin).ToList();
            dgvParcelasPendFinEscolhida.Refresh();
        }

        private void dgvParcelasPendFinEscolhida_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var valor = dgvParcelasPendFinEscolhida.Rows[e.RowIndex].Cells[0].Value;
                txtParcelaSelecionada.Text = valor.ToString();
            }


            string status = dgvParcelasPendFinEscolhida.CurrentRow.Cells["StatusPagamento"].Value.ToString();

            bool mostrarCampos = status != "Pago";

            lblDataPagamento.Visible = mostrarCampos;
            txtDataPagamento.Visible = mostrarCampos;

            txtParcelaSelecionada.Visible = mostrarCampos;
            lblSequenciaParcela.Visible = mostrarCampos;
            lblValorPago.Visible = mostrarCampos;
            txtValorPago.Visible = mostrarCampos;

            lblEspeciePagamento.Visible = mostrarCampos;
            cmbEspeciePagamento.Visible = mostrarCampos;

            btnRegistrarPagamento.Visible = mostrarCampos;
        }
        private void LimparCampos()
        {
            txtParcelaSelecionada.Clear();
            txtValorPago.Clear();
            txtDataPagamento.Clear();
            cmbEspeciePagamento.SelectedIndex = -1;

        }

        private void dgvParcelasPendFinEscolhida_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblSequenciaParcela_Click(object sender, EventArgs e) { }
        private void txtParcelaSelecionada_TextChanged(object sender, EventArgs e) { }
        private void txtValorPago_TextChanged(object sender, EventArgs e) { }
        private void lblValorPago_Click(object sender, EventArgs e) { }
        private void txtDataPagamento_TextChanged(object sender, EventArgs e) { }
        private void lblEspeciePagamento_Click(object sender, EventArgs e) { }
        private void FrmRegistroPagamento2_Load(object sender, EventArgs e) { }
        private void cmbEspeciePagamento_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblDataPagamento_Click(object sender, EventArgs e) { }
    }
}
