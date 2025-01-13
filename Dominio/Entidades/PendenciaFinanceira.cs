﻿using Org.BouncyCastle.Ocsp;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class PendenciaFinanceira : ModeloAbstrato, IContrato
    {
        public Guid TransacaoId { get; set; }     
        public decimal ValorTotal { get; set; }
        public IList<Parcela> Parcelas { get; private set; } = new List<Parcela>();

        public PendenciaFinanceira(Guid transacaoId, decimal valorTotal)
        {
            TransacaoId = transacaoId;
            ValorTotal = valorTotal;
        }

        public PendenciaFinanceira()
        {
        }

        public override string? ToString()
        {
            var sb = new StringBuilder();
            foreach (var parcela in Parcelas)
            {
                sb.AppendLine($"Sequência: {parcela.Sequencia}, Valor: {parcela.Valor}, Vencimento: {parcela.DataVencimento.ToString("dd/MM/yyyy")}");

            }
            return sb.ToString();
        }

        public void AdicionarParcela(Parcela parcela)
        {
            Parcelas.Add(parcela);
        }

        public void RemoverParcela(Parcela parcela)
        {
            Parcelas.Remove(parcela);
        }

        public override bool Validacao()
        {
            return true; // por enquanto
        }
    }
}