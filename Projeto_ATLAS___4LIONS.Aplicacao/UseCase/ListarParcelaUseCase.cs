using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Exceções;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;

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
                var listaParcelasPorPendencia = _parcelaRepositorio.ListarPorPendencia(idPendencia);
                var listaParcelasPorPendenciaDto = listaParcelasPorPendencia.Select(x => new ParcelaDTO(x.Sequencia,x.DataVencimento,x.Valor));

                return listaParcelasPorPendenciaDto;
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
                var parcelaFiltrada = _parcelaRepositorio.RecuperarPorId(id);
                var parcelaFiltradaDto = new ParcelaDTO(parcelaFiltrada.Sequencia, parcelaFiltrada.DataVencimento, parcelaFiltrada.Valor);

                return parcelaFiltradaDto;
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }

    }
}
