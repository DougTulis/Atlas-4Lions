using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarParcelaUseCase
    {
        private readonly IParcelaRepositorio parcelaRepositorio;
        public ListarParcelaUseCase(IParcelaRepositorio parcelaRepositorio)
        {
            this.parcelaRepositorio = parcelaRepositorio;
        }
        public IEnumerable<ParcelaDTO> ExecutarRecuperacaoPorPendFin(int idPendencia)
        {
          return parcelaRepositorio.ListarPorPendencia(idPendencia);
        }
        public ParcelaDTO? ExecutarRecuperacaoPorId(int id)
        {
            return parcelaRepositorio.RecuperarPorId(id);
        }

    }
}
