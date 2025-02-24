using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class LocacaoDTO
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime Saida { get; set; }
        public DateTime Retorno { get; set; }
        public ETipoLocacao TipoLocacao { get; set; }
        public decimal ValorTotal { get; set; }
        public Guid IdLocatario { get; set; }
        public Guid IdCondutor { get; set; }
        public Guid IdAutomovel { get; set; }
        public Guid PendenciaFinanceiraId { get; set; }
        public EStatusLocacao Status { get; set; }

        public LocacaoDTO()
        {
        }

        public LocacaoDTO(Guid id, DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao, decimal valorTotal, Guid idLocatario, Guid idCondutor, Guid idAutomovel, Guid pendenciaFinanceiraId, EStatusLocacao status)
        {
            Id = id;
            Saida = saida;
            Retorno = retorno;
            TipoLocacao = tipoLocacao;
            ValorTotal = valorTotal;
            IdLocatario = idLocatario;
            IdCondutor = idCondutor;
            IdAutomovel = idAutomovel;
            PendenciaFinanceiraId = pendenciaFinanceiraId;
            Status = status;

        }
    }
}
