using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarParcelaUseCase
    {
        private readonly IParcelaRepositorio parcelaRepositorio;
        public CadastrarParcelaUseCase(IParcelaRepositorio parcelaRepositorio)
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
                    MenuInicial menuInicial = new MenuInicial();
                    menuInicial.Exibir();
                }
                parcelaRepositorio.Adicionar(parcelaDto);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
