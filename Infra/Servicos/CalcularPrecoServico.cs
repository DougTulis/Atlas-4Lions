using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Infra.Servicos
{
    public class CalcularPrecoServico
    {
        public static decimal CalcularPreco(ETipoLocacao tipoLocacao, decimal valorDiaria)
        {
            switch (tipoLocacao)
            {
                case ETipoLocacao.FIMSEMANA:
                    return valorDiaria *= 3;
                case ETipoLocacao.DIARIA:
                    return valorDiaria *= 1;
                case ETipoLocacao.MENSAL:
                    return valorDiaria *= 30;
                case ETipoLocacao.SEMANAL:
                    return valorDiaria *= 7;
                case ETipoLocacao.ANUAL:
                    return valorDiaria *= 365;
                case ETipoLocacao.MENSALCONTRATO:
                    return valorDiaria *= 30;
                case ETipoLocacao.ANUALCONTRATO:
                    return valorDiaria *= 365;
                default:
                    throw new ArgumentException("Tipo de locação invalido", nameof(tipoLocacao));
            }

        }
    }
}