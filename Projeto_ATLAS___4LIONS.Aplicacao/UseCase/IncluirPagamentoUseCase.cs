using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class IncluirPagamentoUseCase 
    {
      //  private readonly ParcelaRepositorio parcelaRepositorio;
    //   public IncluirPagamentoUseCase(IParcelaRepositorio parcelaRepositorio)
    //   {
    //       this.parcelaRepositorio = parcelaRepositorio;
    //   }
    //   public void Executar(ParcelaDTO parcelaDto)
    //   {
    //       try
    //       {
    //           var parcela = Parcela.Create(parcelaDto.Sequencia, parcelaDto.DataVencimento, parcelaDto.Valor);
    //
    //
    //           if (!parcela.Validacao())
    //           {
    //               return;
    //           }
    //           parcelaRepositorio.AtualizarPagamentoParcela(parcela.Id, parcela.Sequencia, Convert.ToDecimal//(parcela.ValorPago), Convert.ToDateTime(parcela.DataPagamento), (EEspecie)parcelaDto.EspeciePagamento);
    //       }
    //       catch (MySqlException ex)
    //       {
    //           throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
    //       }
        }
    }

