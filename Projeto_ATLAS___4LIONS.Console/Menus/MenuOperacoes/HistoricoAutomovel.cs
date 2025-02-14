using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class HistoricoAutomovel
    {
        private readonly IAutomovelRepositorio _automovelRepositorio;

        public HistoricoAutomovel(IAutomovelRepositorio automovelRepositorio)
        {
            _automovelRepositorio = automovelRepositorio;
        }

        public void Exibir()
        {
            Console.Clear();
            var useCase = new ListarAutomovelUseCase(_automovelRepositorio);
            foreach (var item in useCase.ExecutarDadosCompletos())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Digite uma tecla para voltar ao menu anterior");
            Console.ReadKey();
            MenuInicial menuInicial = new MenuInicial();
            menuInicial.Exibir();

        }
    }

}
