using System.Globalization;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class TabelaPrecoDTO
    {

        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public TabelaPrecoDTO(Guid id, DateTime dataCriacao, string descricao, decimal valor)
        {
            Id = id;
            DataCriacao = dataCriacao;
            Descricao = descricao;
            Valor = valor;
        }

        public TabelaPrecoDTO()
        {
        }

        public override string? ToString()
        {
            return Descricao + " - " + Valor.ToString("C");
        }
    }
}
