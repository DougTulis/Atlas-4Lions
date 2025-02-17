using System.Globalization;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class TabelaPrecoDTO
    {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }


        public TabelaPrecoDTO(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public TabelaPrecoDTO()
        {
        }

        public override string? ToString()
        {
            return Descricao + " - R$" + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
