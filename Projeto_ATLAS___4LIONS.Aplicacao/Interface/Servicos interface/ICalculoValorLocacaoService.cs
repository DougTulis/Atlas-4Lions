using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface
{
    public interface ICalculoValorLocacaoService
    {
        public decimal CalcularValorTotal(DateTime saida, DateTime retorno, decimal precoDiaria, ETipoLocacao tipoLocacao,int quantidadeParcelas);

    }
}
