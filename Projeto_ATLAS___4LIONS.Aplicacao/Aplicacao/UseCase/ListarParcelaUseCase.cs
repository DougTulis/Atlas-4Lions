using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
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
        public IEnumerable<ParcelaDTO> ExecutarRecuperacaoPorPendFin(int idPendencia)
        {
          return _parcelaRepositorio.ListarPorPendencia(idPendencia);
        }
        public ParcelaDTO? ExecutarRecuperacaoPorId(int id)
        {
            return _parcelaRepositorio.RecuperarPorId(id);
        }

    }
}
