using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class ParcelaDTO
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public int Sequencia { get; set; }
        public Guid PendenciaFinanceiraId { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal Valor { get; set; }
        public DateTime? DataPagamento { get; set; }
        public decimal? ValorPago { get; set; }
        public EEspecie? EspeciePagamento { get; set; }

        public ParcelaDTO(Guid id, int sequencia, Guid pendenciaFinanceiraId, DateTime dataVencimento, decimal valor, DateTime? dataPagamento, decimal? valorPago, EEspecie? especiePagamento)
        {
            Id = id;
            Sequencia = sequencia;
            PendenciaFinanceiraId = pendenciaFinanceiraId;
            DataVencimento = dataVencimento;
            Valor = valor;
            DataPagamento = dataPagamento;
            ValorPago = valorPago;
            EspeciePagamento = especiePagamento;
        }

        public ParcelaDTO()
        {
        }

        public override string? ToString()
        {

            return $"Id: {Id}, Sequência: {Sequencia}, Valor: {Valor:C}, Vencimento: {DataVencimento:dd/MM/yyyy}";
        }


    }
}


