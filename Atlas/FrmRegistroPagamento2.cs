using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
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

        private PendenciaFinanceiraDTO _pendenciaFinanceira;

        public FrmRegistroPagamento2()
        {
            InitializeComponent();
        }
        public FrmRegistroPagamento2(int _Idpendfin)
        {
            idPendFin = _Idpendfin;
            InitializeComponent();
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

        private void txtSequenciaParcela_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataPagamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEspeciePagamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvParcelasPendFinEscolhida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmRegistroPagamento2_Load(object sender, EventArgs e)
        {

        }

        public void SetParametros(PendenciaFinanceiraDTO pendfin)
        {
            _pendenciaFinanceira = pendfin;

            txtSequenciaParcela.Text = _pendenciaFinanceira.Id.ToString();
        }
    }
}
