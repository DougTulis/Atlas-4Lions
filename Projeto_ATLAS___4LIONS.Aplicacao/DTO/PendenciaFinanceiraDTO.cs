using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class PendenciaFinanceiraDTO
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public decimal ValorTotal { get; set; }
        public IList<Parcela> Parcelas { get; private set; } = new List<Parcela>();

        public PendenciaFinanceiraDTO()
        {
        }
        public PendenciaFinanceiraDTO(decimal valorTotal)
        {
            ValorTotal = valorTotal;
        }
    }
}
