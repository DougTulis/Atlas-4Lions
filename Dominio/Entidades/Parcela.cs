using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class Parcela : ModeloAbstrato
    {
        public decimal ValorParcela { get; set; }
        public DateTime DataVencimento { get; set; }

        public override bool Validacao()
        {
            throw new NotImplementedException();
        }
    }
}
