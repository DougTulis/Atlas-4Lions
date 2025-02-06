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

        public void ExecutarDadosCompletos()
        {
            foreach (var item in 
                automovelRepositorio.ListarTodos())
            {
                Console.WriteLine(item);
            }
        }
        public void ExecutarDadosBreves()
        {
            foreach (var item in automovelRepositorio.ListarTodos())
            {
                Console.WriteLine(item.ExibirDadosBreves());
            }
        }

        public void ExecutarStatusGaragem()
        {
            var lista = automovelRepositorio.ListarStatusGaragem();
            foreach (var item in lista)
            {
                Console.WriteLine(item.ExibirDadosBreves());
            }

        }
    }
}
