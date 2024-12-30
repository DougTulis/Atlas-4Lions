using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class ParcelaDTO
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public int Sequencia { get; set; }
        public int PendenciaFinanceiraId { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal Valor { get; set; }
        public DateTime? DataPagamento { get; set; }
        public decimal? ValorPago { get; set; }
        public EEspecie? EspeciePagamento { get; set; }

        public ParcelaDTO(int sequencia, DateTime dataVencimento, decimal valor)
        {
            Sequencia = sequencia;
            DataVencimento = dataVencimento;
            Valor = valor;
        }

        public ParcelaDTO()
        {
        }
    }
}
