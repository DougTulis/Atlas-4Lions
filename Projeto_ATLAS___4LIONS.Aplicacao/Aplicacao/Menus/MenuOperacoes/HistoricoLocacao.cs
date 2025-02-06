using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{

    public class HistoricoLocacao
    {

        private readonly ILocacaoRepositorio _locacaoRepositorio;

        public HistoricoLocacao(ILocacaoRepositorio locacaoRepositorio)
        {
            _locacaoRepositorio = locacaoRepositorio;
        }

        public void Exibir()
        {
     
            var useCaseListarLocacao = new ListarLocacoesUseCase(_locacaoRepositorio);
            useCaseListarLocacao.Executar();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial");
            Console.ReadKey();
            MenuInicial menuInicial = new MenuInicial();
            menuInicial.Exibir();

        }
    }
}
