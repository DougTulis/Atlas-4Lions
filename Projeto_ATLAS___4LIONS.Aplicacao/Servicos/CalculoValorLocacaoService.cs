using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Servicos
{
    public class CalculoValorLocacaoService
    {
        public static decimal CalcularValorTotal(DateTime saida, DateTime retorno, decimal precoDiaria)
        {
            int dias = (retorno - saida).Days;
            return dias > 0 ? dias * precoDiaria : precoDiaria; // Garante pelo menos 1 diária
        }

    }
}
