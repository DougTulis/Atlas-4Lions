using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class PendenciaFinanceira : ModeloAbstrato
    { 

        public decimal ValorTotal { get; set; }
        public IEnumerable<Parcela> Pagamentos { get; set; } = new List<Parcela>();

        public override bool Validacao()
        {
            throw new NotImplementedException();
        }
    }
}
