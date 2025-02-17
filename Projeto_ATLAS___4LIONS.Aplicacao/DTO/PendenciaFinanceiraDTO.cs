using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class PendenciaFinanceiraDTO
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public Guid TransacaoId { get; set; }
        public decimal ValorTotal { get; set; }
        public int IdLocacao { get; set; }
        public IList<Parcela> Parcelas { get; private set; } = new List<Parcela>();

        public PendenciaFinanceiraDTO(Guid transacaoId, int locacao)
        {
            TransacaoId = transacaoId;
            IdLocacao = locacao;

        }
        public PendenciaFinanceiraDTO()
        {
        }

        public override string? ToString()
        {
            return "Valor: " + ValorTotal + ", " + "Transação ID: " + TransacaoId;

        }
    }
}
