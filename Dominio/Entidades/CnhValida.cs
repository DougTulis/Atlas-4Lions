using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class CnhValida
    {
        public string Numero { get; set; }
        public DateTime Vencimento { get; set; }

        public CnhValida(string numero, DateTime vencimento)
        {
            Numero = numero;
            Vencimento = vencimento;
        }
    }
}
