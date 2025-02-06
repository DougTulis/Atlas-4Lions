using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class LocacaoDTO
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime Saida { get; set; }
        public DateTime Retorno { get; set; }
        public ETipoLocacao TipoLocacao { get; set; }
        public decimal ValorTotal { get; set; }
        public Pessoa Locatario { get; set; }
        public Pessoa Condutor { get; set; }
        public Automovel Automovel { get; set; }
        public PendenciaFinanceira PendenciaFinanceira { get; set; }
        public EStatusLocacao Status { get; set; }

        public LocacaoDTO()
        {
        }

        public LocacaoDTO(DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao, decimal valorTotal, Pessoa locatario, Pessoa condutor, Automovel automovel, PendenciaFinanceira pendenciaFinanceira)
        {
            Saida = saida;
            Retorno = retorno;
            TipoLocacao = tipoLocacao;
            ValorTotal = valorTotal;
            Locatario = locatario;
            Condutor = condutor;
            Automovel = automovel;
            PendenciaFinanceira = pendenciaFinanceira;

        }

        public override string? ToString()
        {
            return "ID: " + Id + "\n" +
                "Id do Condutor: " + Condutor.Id + "\n" +
                "Id do Automovel: " + Automovel.Id + "\n" +
                "Valor Total: " + ValorTotal.ToString("F2") + "\n" +
                "Status: " + Status + "\n";
        }
    }
}
