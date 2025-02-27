using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarParcelaUseCase : IListarParcelaUseCase
    {
        private readonly IParcelaRepositorio _parcelaRepositorio;
        public ListarParcelaUseCase(IParcelaRepositorio parcelaRepositorio)
        {
            _parcelaRepositorio = parcelaRepositorio;
        }

        public IEnumerable<ParcelaDTO> ExecutarRecuperacaoPorPendFin(Guid idPendencia)
        {
            try
            {
                return _parcelaRepositorio.ListarPorPendencia(idPendencia);
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }
        public ParcelaDTO? ExecutarRecuperacaoPorId(Guid id)
        {
            try
            {
                return _parcelaRepositorio.RecuperarPorId(id);
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }

    }
}
