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

        public IEnumerable<ParcelaRegistroPagamentoDTO> ExecutarRecuperacaoPorPendFin(Guid idPendencia)
        {
            try
            {
                var listaParcelasPorPendencia = _parcelaRepositorio.ListarPorPendencia(idPendencia);
                var listaParcelasPorPendenciaDto = listaParcelasPorPendencia.Select(x => new ParcelaRegistroPagamentoDTO
                {
                    Sequencia = Convert.ToInt32(x[0]),
                    Vencimento = Convert.ToDateTime(x[1]),
                    Valor = Convert.ToDecimal(x[2]),
                    Status = x[3].ToString(),
                    Id = Guid.Parse(x[4].ToString()),
                }).ToList();

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
                var parcelaFiltradaDto = new ParcelaDTO(parcelaFiltrada.Id, parcelaFiltrada.Sequencia, parcelaFiltrada.IdPendenciaFinanceira, parcelaFiltrada.DataVencimento, parcelaFiltrada.Valor, parcelaFiltrada.DataPagamento, parcelaFiltrada.ValorPago, parcelaFiltrada.EspeciePagamento);

                return parcelaFiltradaDto;
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }

    }
}
