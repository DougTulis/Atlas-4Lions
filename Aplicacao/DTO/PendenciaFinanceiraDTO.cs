using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class PendenciaFinanceiraDTO
    {
        public decimal ValorTotal { get; set; }
        public IEnumerable<Parcela> PendenciaFinanceira { get; set; } = new List<Parcela>();

        public override string? ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Valor Total:" + ValorTotal.ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("Parcelas: ");
            foreach (var item in PendenciaFinanceira)
            {
                sb.AppendLine("Valor da parcela: " + item.ValorParcela);
                sb.AppendLine("Data Vencimento: " + item.DataVencimento);
            }
            return sb.ToString();

        }
    }
}
