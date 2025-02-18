using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarTabelaPrecoUseCase : IListarTabelaPrecoUseCase
    {

        private readonly ITabelaPrecoRepositorio tabelaRepositorio;
        public ListarTabelaPrecoUseCase(ITabelaPrecoRepositorio tabelaRepositorio)
        {
            this.tabelaRepositorio = tabelaRepositorio;
        }


        public IEnumerable<TabelaPrecoDTO> Executar()
        {
            return tabelaRepositorio.ListarTodos();      
        }

        public TabelaPrecoDTO? ExecutarRecuperarPorId(int id)
        {
            return tabelaRepositorio.RecuperarPorId(id);
        }
    }
}
