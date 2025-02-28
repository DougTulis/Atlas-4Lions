using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarPendenciaFinanceiraUseCase : IListarPendenciaFinanceiraUseCase
    {

        private readonly IPendenciaFinanceiraRepositorio _pendenciaRepositorio;
        public ListarPendenciaFinanceiraUseCase(IPendenciaFinanceiraRepositorio pendenciaRepositorio)
        {
            _pendenciaRepositorio = pendenciaRepositorio;
        }
        public IEnumerable<PendenciaFinanceiraDTO> Executar()
        {
            try
            {
                return _pendenciaRepositorio.ListarTodos();
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }

        }
        public PendenciaFinanceiraDTO? ExecutarRecuperarPorId(Guid id)
        {
            try
            {
                return _pendenciaRepositorio.RecuperarPorId(id);
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }

    }
}