using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Servicos
{
    public class CalculoValorLocacaoService : ICalculoValorLocacaoService
    {
        public decimal CalcularValorTotal(DateTime saida, DateTime retorno, decimal precoDiaria, ETipoLocacao tipoLocacao, int quantidadeParcelas)
        {
            if(tipoLocacao == ETipoLocacao.CONTRATO)
            {
                return precoDiaria * quantidadeParcelas;
            }

            int dias = (retorno - saida).Days;
            return dias > 0 ? dias * precoDiaria : precoDiaria; 
        }
    }
}
