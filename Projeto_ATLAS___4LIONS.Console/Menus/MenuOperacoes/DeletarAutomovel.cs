using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class DeletarAutomovel
    {
        private readonly IAutomovelRepositorio _automovelRepositorio;
        public void Deletar()
        {
            Console.Clear();

            var useCaseListar = new ListarAutomovelUseCase(_automovelRepositorio);
            var useCaseDeletar = new DeletarAutomovelUseCase(_automovelRepositorio);
            useCaseListar.ExecutarDadosBreves();
            Console.Write("Informe o ID do veiculo que você deseja deletar: ");
            int escolha = int.Parse(Console.ReadLine());
            var veiculoFiltrado = _automovelRepositorio.RecuperarPorId(escolha);
            useCaseDeletar.Executar(veiculoFiltrado);
            Console.WriteLine("Automovel deletado com sucesso! Voltando ao menu anterior....");
            Thread.Sleep(2500);
            Console.Clear();
            MenuInicial menuInicial = new MenuInicial();
            menuInicial.Exibir();
        }

    }

}
