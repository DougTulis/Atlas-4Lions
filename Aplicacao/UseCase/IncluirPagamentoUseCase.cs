using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class IncluirPagamentoUseCase
    {
        private readonly ParcelaRepositorio parcelaRepositorio;
        public IncluirPagamentoUseCase(ParcelaRepositorio parcelaRepositorio)
        {
            this.parcelaRepositorio = parcelaRepositorio;
        }
        public void Executar(ParcelaDTO parcelaDto)
        {
            try
            {
                var parcela = new Parcela
                {
                    PendenciaFinanceiraId = parcelaDto.PendenciaFinanceiraId,
                    Sequencia = parcelaDto.Sequencia,
                    Valor = parcelaDto.Valor,
                    DataVencimento = parcelaDto.DataVencimento,
                    DataPagamento = parcelaDto.DataPagamento,
                    ValorPago = parcelaDto.ValorPago,
                    EspeciePagamento = parcelaDto.EspeciePagamento
                };

                if (!parcela.Validacao())
                {
                    Thread.Sleep(2000);
                    MenuInicial.Exibir();
                }
                parcelaRepositorio.Atualizar(parcelaDto);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
