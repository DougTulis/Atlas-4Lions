using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarTabelaPrecoUseCase
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
