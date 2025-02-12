using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarPendenciaFinanceiraUseCase
    {

        private readonly IPendenciaFinanceiraRepositorio pendenciaRepositorio;
        public ListarPendenciaFinanceiraUseCase(IPendenciaFinanceiraRepositorio pendenciaRepositorio)
        {
            this.pendenciaRepositorio = pendenciaRepositorio;
        }
        public IEnumerable<PendenciaFinanceiraDTO> Executar()
        {
            return pendenciaRepositorio.ListarTodos();
      
        }
        public PendenciaFinanceiraDTO? ExecutarRecuperarPorId(int id)
        {
            return pendenciaRepositorio.RecuperarPorId(id);
        }
    }
}