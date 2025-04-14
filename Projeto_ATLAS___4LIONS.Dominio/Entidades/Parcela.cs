using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Validacoes;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System.Globalization;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class Parcela : ModeloAbstrato, IContrato
    {

        public int Sequencia { get;private set; }
        public DateTime DataVencimento { get; private set; }
        public decimal Valor { get; private set; }
        public Guid IdPendenciaFinanceira { get; private set; }
        public DateTime? DataPagamento { get; private set; }
        public decimal? ValorPago { get; private set; }
        public EEspecie? EspeciePagamento { get; private  set; }

       // public Parcela()
       // {
        //}
        private Parcela(int sequencia, DateTime dataVencimento, decimal valor,Guid idPendenciaFinanceira) : base()
        {
            Sequencia = sequencia;
            DataVencimento = dataVencimento;
            Valor = valor;
            IdPendenciaFinanceira = idPendenciaFinanceira;
        }

        private Parcela(Guid id, DateTime dataCriacao, int sequencia, DateTime dataVencimento, decimal valor, Guid idPendenciaFinanceira) : base(id,dataCriacao)
        {
            Sequencia = sequencia;
            DataVencimento = dataVencimento;
            Valor = valor;
            IdPendenciaFinanceira = idPendenciaFinanceira;
        }

        public static Parcela Create(int sequencia, DateTime dataVencimento, decimal valor, Guid idPendenciaFinanceira)
        {
            return new Parcela(sequencia,dataVencimento,valor,idPendenciaFinanceira);
        }

        public static Parcela CreateFromDataBase(Guid id,DateTime dataCriacao, int sequencia, DateTime dataVencimento, decimal valor, Guid idPendenciaFinanceira)
        {
            return new Parcela(id,dataCriacao, sequencia, dataVencimento, valor, idPendenciaFinanceira);
        }
        public override bool Validacao(out string erros)
        {
            erros = "";
            var contratos = new ContratoValidacoes<Parcela>()
           .ValorPagoIsOk(this.Valor, "O valor é obrigatório", "ValorPago");

            if (!contratos.IsValid())
            {
                erros = contratos.CapturadorErros();
                return false;
            }
            return true;
        }
    }
}
