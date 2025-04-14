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
                var listaPendencias = _pendenciaRepositorio.ListarTodos();
                var listaPendenciasDto = listaPendencias.Select(x => new PendenciaFinanceiraDTO(x.Id,x.DataCriacao,x.ValorTotal)).ToList();
                return listaPendenciasDto;
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }

        }

        public IEnumerable<RegistroPagamentoDTO> ExecutarPagamentosPendentes()
        {
            try
            {
                var listaPendencias = _pendenciaRepositorio.ListarPagamentosPendente();
                var listaDto = listaPendencias.Select(linha => new RegistroPagamentoDTO
                {
                    Nome = linha[0].ToString(),
                    ValorTotal = (decimal)linha[1],
                    QuantidadeParcelas = Convert.ToInt16(linha[2]),
                    Status = linha[3].ToString(),
                    Id = Guid.Parse(linha[4].ToString())
                }).ToList();

                return listaDto;
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
                var pendenciaFiltrada = _pendenciaRepositorio.RecuperarPorId(id);
                var pendenciaFiltradaDto = new PendenciaFinanceiraDTO(pendenciaFiltrada.Id,pendenciaFiltrada.DataCriacao,pendenciaFiltrada.ValorTotal);
                return pendenciaFiltradaDto;
            }
            catch (MySqlException ex)
            {
                throw new BancoDeDadosException("Erro ao acessar o banco de dados. Detalhes: " + ex.Message);
            }
        }



    }
}