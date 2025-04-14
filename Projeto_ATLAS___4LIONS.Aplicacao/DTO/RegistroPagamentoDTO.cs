using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class RegistroPagamentoDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorTotal { get; set; }
        public int QuantidadeParcelas { get; set; }
        public string Status { get; set; }

        public RegistroPagamentoDTO()
        {
        }


    }
}
