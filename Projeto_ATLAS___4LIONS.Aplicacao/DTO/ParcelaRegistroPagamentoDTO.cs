using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class ParcelaRegistroPagamentoDTO
    {
        public Guid Id { get; set; }
        public int Sequencia { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal Valor { get; set; }
        public string Status { get; set; }

        public ParcelaRegistroPagamentoDTO()
        {
        }
    }
}
