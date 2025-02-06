using System.Globalization;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class TabelaPrecoDTO
    {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int AutomovelId { get; set; }


        public TabelaPrecoDTO(string descricao, decimal valor, int automovelId)
        {
            Descricao = descricao;
            Valor = valor;
            AutomovelId = automovelId;
        }

        public TabelaPrecoDTO()
        {
        }

        public override string? ToString()
        {
            return "ID: " + Id + "\n" +
                "Descrição : " + Descricao + ", Valor: R$" + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
