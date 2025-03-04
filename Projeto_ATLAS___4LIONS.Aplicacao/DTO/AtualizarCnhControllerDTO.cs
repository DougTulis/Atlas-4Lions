using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class AtualizarCnhControllerDTO
    {
        public string NumeroCnh { get; set; }
        public DateTime VencimentoCnh { get; set; }

        public AtualizarCnhControllerDTO(string numeroCnh, DateTime vencimentoCnh)
        {
            NumeroCnh = numeroCnh;
            VencimentoCnh = vencimentoCnh;
        }
    }
}
