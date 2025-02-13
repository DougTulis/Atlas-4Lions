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
        public int IdLocatario { get; set; }
        public int IdCondutor { get; set; }
        public int IdAutomovel { get; set; }
        public EStatusLocacao Status { get; set; }

        public LocacaoDTO()
        {
        }

        public LocacaoDTO(DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao, decimal valorTotal, int idLocatario, int idCondutor, int idAutomovel)
        {
            Saida = saida;
            Retorno = retorno;
            TipoLocacao = tipoLocacao;
            ValorTotal = valorTotal;
            IdLocatario = idLocatario;
            IdCondutor = idCondutor;
        }

        public override string? ToString()
        {
            return "ID: " + Id + "\n" +
                "Id do Condutor: " + IdCondutor+ "\n" +
                "Id do Automovel: " + IdAutomovel + "\n" +
                "Valor Total: " + ValorTotal.ToString("F2") + "\n" +
                "Status: " + Status + "\n";
        }
    }
}
