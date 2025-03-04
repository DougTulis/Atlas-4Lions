using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface
{
    public interface IParcelaService
    {
        void GerarParcelas(PendenciaFinanceira pendenciaFinanceira, int quantidadeParcelas);
    }
}
