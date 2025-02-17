using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;

using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class IncluirPagamentoUseCase
    {
        private readonly IParcelaRepositorio parcelaRepositorio;
        public IncluirPagamentoUseCase(IParcelaRepositorio parcelaRepositorio)
        {
            this.parcelaRepositorio = parcelaRepositorio;
        }
        public void Executar(ParcelaDTO parcelaDto)
        {
            try
            {
                var parcela = new Parcela
                {
                    Id = parcelaDto.Id,
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
                    return;
                }
                parcelaRepositorio.AtualizarPagamentoParcela(parcelaDto.PendenciaFinanceiraId, parcela.Sequencia, Convert.ToDecimal(parcelaDto.ValorPago), Convert.ToDateTime(parcelaDto.DataPagamento), (EEspecie)parcelaDto.EspeciePagamento);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
