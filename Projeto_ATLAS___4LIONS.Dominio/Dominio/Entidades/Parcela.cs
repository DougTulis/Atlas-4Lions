using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System.Globalization;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class Parcela : ModeloAbstrato, IContrato
    {

        public int Sequencia { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal Valor { get; set; }
        public int PendenciaFinanceiraId { get; set; }
        public DateTime? DataPagamento { get; set; }
        public decimal? ValorPago { get; set; }
        public EEspecie? EspeciePagamento { get; set; }

        public Parcela()
        {
        }
        public Parcela(int sequencia, DateTime dataVencimento, decimal valor)
        {
            Sequencia = sequencia;
            DataVencimento = dataVencimento;
            Valor = valor;
        }

        public override string? ToString()
        {
            return "Data Vencimento: " + DataVencimento + ", " + "Valor: R$ " + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }

        public override bool Validacao()
        {
            return true;  // por enquanto
        }
    }
}
