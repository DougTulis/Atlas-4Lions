using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public  class PendenciaFinanceiraDTO
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public Guid TransacaoId { get; set; }      
        public decimal ValorTotal { get; set; }
        public IList<Parcela> Parcelas { get; private set; } = new List<Parcela>();

        public PendenciaFinanceiraDTO( Guid transacaoId, decimal valorTotal)
        {
      
            TransacaoId = transacaoId;
            ValorTotal = valorTotal;
        }
        public PendenciaFinanceiraDTO()
        {
        }

        public override string? ToString()
        {
            return "Valor: " + ValorTotal + ", " + "Transação ID: " + TransacaoId;
            
        }
    }
}
