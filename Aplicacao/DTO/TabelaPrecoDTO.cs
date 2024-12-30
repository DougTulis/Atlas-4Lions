using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override string? ToString()
        {
            return "ID: " + Id + "\n" + 
                "Descrição : " + Descricao + ", Valor: R$" + Valor.ToString("F2",CultureInfo.InvariantCulture); 
        }
    }
}
