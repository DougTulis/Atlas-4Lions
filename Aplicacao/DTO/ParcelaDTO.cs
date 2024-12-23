using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class ParcelaDTO : ModeloAbstrato
    {
        public decimal ValorParcela { get; set; }
        public DateTime DataVencimento { get; set; }

        public int PendenciaFinanceiraId { get; set; }

        public ParcelaDTO(decimal valorParcela, DateTime dataVencimento)
        {
            ValorParcela = valorParcela;
            DataVencimento = dataVencimento;
        }

        public ParcelaDTO() { }
        public override bool Validacao()
        {
            throw new NotImplementedException();
        }
    }
}
