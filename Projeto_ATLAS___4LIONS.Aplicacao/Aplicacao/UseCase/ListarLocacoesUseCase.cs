using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarLocacoesUseCase
    {

        private readonly ILocacaoRepositorio locacaoRepositorio;
        public ListarLocacoesUseCase(ILocacaoRepositorio locacaoRepositorio)
        {
            this.locacaoRepositorio = locacaoRepositorio;
        }

        public IEnumerable<LocacaoDTO> Executar()
        {
           return locacaoRepositorio.ListarTodos();
        
        }

        public void ExecutarRecuperacaoStatusAndamento()
        {
            var lista = locacaoRepositorio.ListarPorStatusAndamento();
            foreach (var item in locacaoRepositorio.ListarPorStatusAndamento())
            {
                Console.WriteLine(item);
            }

        }
        public LocacaoDTO? ExecutarRecuperarPorId(int id)
        {
            return locacaoRepositorio.RecuperarPorId(id);


        }
    }
}
