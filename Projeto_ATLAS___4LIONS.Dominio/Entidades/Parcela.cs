using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System.Globalization;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class Parcela : ModeloAbstrato, IContrato
    {

        public int Sequencia { get;private set; }
        public DateTime DataVencimento { get; private set; }
        public decimal Valor { get; private set; }
        public int PendenciaFinanceiraId { get; private set; }
        public DateTime? DataPagamento { get; private set; }
        public decimal? ValorPago { get; private set; }
        public EEspecie? EspeciePagamento { get; private  set; }

       // public Parcela()
       // {
        //}
        public Parcela(int sequencia, DateTime dataVencimento, decimal valor)
        {
            Sequencia = sequencia;
            DataVencimento = dataVencimento;
            Valor = valor;
        }
        public static Parcela Create(int sequencia, DateTime dataVencimento, decimal valor)
        {
            return new Parcela(sequencia,dataVencimento,valor);
        }


        public override bool Validacao()
        {
            return true;  // por enquanto
        }
    }
}
