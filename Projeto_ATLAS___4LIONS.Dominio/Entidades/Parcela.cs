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
        public PendenciaFinanceira PendenciaFinanceira { get; private set; }
        public DateTime? DataPagamento { get; private set; }
        public decimal? ValorPago { get; private set; }
        public EEspecie? EspeciePagamento { get; private  set; }

       // public Parcela()
       // {
        //}

        public Parcela(int sequencia, DateTime dataVencimento, decimal valor,PendenciaFinanceira pendenciaFinanceira)
        {
            Sequencia = sequencia;
            DataVencimento = dataVencimento;
            Valor = valor;
            PendenciaFinanceira = pendenciaFinanceira;
        }

        public static Parcela Create(int sequencia, DateTime dataVencimento, decimal valor, PendenciaFinanceira pendenciaFinanceira)
        {
            return new Parcela(sequencia,dataVencimento,valor,pendenciaFinanceira);
        }

        public override bool Validacao()
        {
            return true;  // por enquanto
        }

        public override bool Validacao(out string erros)
        {
            throw new NotImplementedException();
        }
    }
}
