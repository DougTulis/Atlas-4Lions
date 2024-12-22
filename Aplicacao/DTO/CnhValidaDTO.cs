using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class CnhValidaDTO : ModeloAbstrato
    {
        public string Numero { get; set; }
        public DateTime Vencimento { get; set; }

        public CnhValidaDTO(string numero, DateTime vencimento)
        {
            Numero = numero;
            Vencimento = vencimento;
        }

        public override bool Validacao()
        {
            throw new NotImplementedException();
        }
    }

}
