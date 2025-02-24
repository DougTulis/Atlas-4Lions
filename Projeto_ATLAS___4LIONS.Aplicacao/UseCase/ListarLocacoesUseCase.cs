using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarLocacoesUseCase : IListarLocacoesUseCase
    {

        private readonly ILocacaoRepositorio _locacaoRepositorio;
        public ListarLocacoesUseCase(ILocacaoRepositorio locacaoRepositorio)
        {
            try
            {
                _locacaoRepositorio = locacaoRepositorio;
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }

        public IEnumerable<LocacaoDTO> Executar()
        {
            try
            {
                return _locacaoRepositorio.ListarTodas();
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }

        }
        public IEnumerable<LocacaoDTO> ExecutarRecuperacaoStatusAndamento()
        {
            try
            {
                return _locacaoRepositorio.ListarStatusAndamento();
            }catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }

        }
        public LocacaoDTO? ExecutarRecuperarPorId(Guid id)
        {
            try
            {
                return _locacaoRepositorio.RecuperarPorId(id);
            } catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
    }
}
