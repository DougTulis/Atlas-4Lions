using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarParcelaPorPendFinUseCase
    {
        private readonly IParcelaRepositorio parcelaRepositorio;
        public ListarParcelaPorPendFinUseCase(IParcelaRepositorio parcelaRepositorio)
        {
            this.parcelaRepositorio = parcelaRepositorio;
        }
        public void Executar(int id)
        {
            var lista = parcelaRepositorio.ListarPorPendFin(id);
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
