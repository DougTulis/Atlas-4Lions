using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Infra.Servicos
{
    public class LançarPendenciaFinanceira
    {
        public static PendenciaFinanceiraDTO GerarPendencia(decimal valorTotal, int parcelas, DateTime dataInicio, ETipoLocacao tipoLocacao, LocacaoDTO locacao)
        {
            var pendencia = new PendenciaFinanceiraDTO { ValorTotal = valorTotal, LocacaoId = locacao.Id };

            var listaParcelas = new List<Parcela>();
            decimal valorParcela = Math.Round(valorTotal / parcelas, 2); //pra arrendodar
            if (tipoLocacao == ETipoLocacao.ANUALCONTRATO || tipoLocacao == ETipoLocacao.MENSALCONTRATO)
            {

                for (int i = 0; i < parcelas; i++)
                {
                    var parcela = new Parcela
                    {
                        ValorParcela = valorParcela,
                        DataVencimento = dataInicio.AddMonths(i)

                    };
                    listaParcelas.Add(parcela);
                }
            }
            else // aqui so vai lançar uma parcela caso nao for contratual 
            {
                var parcela = new Parcela
                {
                    ValorParcela = valorTotal,
                    DataVencimento = dataInicio.AddMonths(1)
                };
                listaParcelas.Add(parcela);
            }
            pendencia.Parcelas = listaParcelas;
            return pendencia;
        }
    }
}
