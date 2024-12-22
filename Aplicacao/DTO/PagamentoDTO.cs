﻿using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class PagamentoDTO : ModeloAbstrato
    {
        public EEspecie Especie { get; set; }
        public decimal ValorPago { get; set; }
        public DateTime DataPagamento { get; set; }

        public PagamentoDTO(EEspecie especie, decimal valorPago, DateTime dataPagamento)
        {
            Especie = especie;
            ValorPago = valorPago;
            DataPagamento = dataPagamento;
        }
        public override bool Validacao()
        {
            throw new NotImplementedException();
        }
    }
}
