using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarTabelaPrecoUseCase : IListarTabelaPrecoUseCase
    {

        private readonly ITabelaPrecoRepositorio _tabelaRepositorio;
        public ListarTabelaPrecoUseCase(ITabelaPrecoRepositorio tabelaRepositorio)
        {
            _tabelaRepositorio = tabelaRepositorio;
        }

        public IEnumerable<TabelaPrecoDTO> Executar()
        {
            try
            {
                return _tabelaRepositorio.ListarTodos();
            } catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }

        public TabelaPrecoDTO? ExecutarRecuperarPorId(Guid id)
        {
            try
            {
                return _tabelaRepositorio.RecuperarPorId(id);
            } catch(MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
    }
}
