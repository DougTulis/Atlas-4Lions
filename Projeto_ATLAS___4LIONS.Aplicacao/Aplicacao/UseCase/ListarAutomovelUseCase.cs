using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarAutomovelUseCase : IListarAutomovelUseCase
    {

        private readonly IAutomovelRepositorio automovelRepositorio;

        public ListarAutomovelUseCase(IAutomovelRepositorio automovelRepositorio)
        {

            this.automovelRepositorio = automovelRepositorio;
        }

        public IEnumerable<AutomovelDTO> ExecutarDadosCompletos()
        {
            try
            {
                return automovelRepositorio.ListarTodos();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }

        public AutomovelDTO? ExecutarRecuperarPorId(int id)
        {
            try
            {
                return automovelRepositorio.RecuperarPorId(id);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);

            }
        }

        public IEnumerable<AutomovelDTO> ExecutarDadosBreves()
        {
            try
            {
                return automovelRepositorio.ListarTodos();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }

        public IEnumerable<AutomovelDTO> ExecutarStatusGaragem()
        {
            try
            {
                return automovelRepositorio.ListarStatusGaragem();
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);

            }

        }
    }
}
