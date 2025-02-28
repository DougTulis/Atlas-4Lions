using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class IncluirPagamentoUseCase : IIncluirPagamentoUseCase
    {
        private readonly IParcelaRepositorio _parcelaRepositorio;

        public IncluirPagamentoUseCase(IParcelaRepositorio parcelaRepositorio)
        {
            _parcelaRepositorio = parcelaRepositorio;
        }

        public RespostaPadrao<string> Executar(ParcelaDTO parcelaDto)
        {
            try
            {
                var parcelaPagamento = ParcelaPagamento.Create(
                    parcelaDto.Id,
                    parcelaDto.DataCriacao,
                    parcelaDto.Sequencia,
                    parcelaDto.DataVencimento,
                    parcelaDto.Valor,
                    parcelaDto.PendenciaFinanceiraId,
                    parcelaDto.DataPagamento,
                    parcelaDto.ValorPago,
                    parcelaDto.EspeciePagamento
                );

                string erros;
                if (!parcelaPagamento.Validacao(out erros))
                {
                    return RespostaPadrao<string>.Falha(false, "Erros na validação da parcela", erros);
                }

                _parcelaRepositorio.AtualizarPagamentoParcela(
                    parcelaPagamento.Id,
                    parcelaPagamento.Sequencia,
                    parcelaPagamento.ValorPago ?? 0,
                    parcelaPagamento.DataPagamento ?? DateTime.Now,
                    parcelaPagamento.EspeciePagamento ?? EEspecie.DINHEIRO
                );

                return RespostaPadrao<string>.Sucesso(true, "Pagamento registrado com sucesso!");
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
    }
}
