using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarAutomovelUseCase
    {

        private readonly IAutomovelRepositorio automovelRepositorio;
        public ListarAutomovelUseCase(IAutomovelRepositorio automovelRepositorio)
        {
            this.automovelRepositorio = automovelRepositorio;
        }

        public IEnumerable<AutomovelDTO> ExecutarDadosCompletos()
        {
            return automovelRepositorio.ListarTodos();
        }

        public AutomovelDTO? ExecutarRecuperarPorId(int id)
        {
            return automovelRepositorio.RecuperarPorId(id);
        }

        public IEnumerable<AutomovelDTO> ExecutarDadosBreves()
        {
            return automovelRepositorio.ListarTodos();
            
        }

        public IEnumerable<AutomovelDTO> ExecutarStatusGaragem()
        {
           return automovelRepositorio.ListarStatusGaragem();
       
        }
    }
}
