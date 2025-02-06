using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarPendenciaFinanceiraUseCase
    {
        private readonly IPendenciaFinanceiraRepositorio pendenciaRepositorio;
        public CadastrarPendenciaFinanceiraUseCase(IPendenciaFinanceiraRepositorio pendenciaRepositorio)
        {
            this.pendenciaRepositorio = pendenciaRepositorio;
        }
        public void Executar(PendenciaFinanceiraDTO pendenciaDto)
        {
            try
            {
                var pendencia = new PendenciaFinanceira(
         pendenciaDto.TransacaoId,
         pendenciaDto.ValorTotal
     )
                {
                    DataCriacao = pendenciaDto.DataCriacao
                };
                if (!pendencia.Validacao())
                {
                    Thread.Sleep(2000);
                    MenuInicial menuInicial = new MenuInicial();
                    menuInicial.Exibir();
                }
                pendenciaRepositorio.Adicionar(pendenciaDto);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
