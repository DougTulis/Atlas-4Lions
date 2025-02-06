using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class DefinirPrecoAutomovel
    {
        public static TabelaPrecoDTO Definir(AutomovelDTO automovel, ITabelaPrecoRepositorio precoRepositorio, ListarTabelaPrecoUseCase useCase)
        {
            Console.WriteLine("\nTabela de Preços para este Automóvel:");
            useCase.ExecutarRecuperarPorId(automovel.Id);
            Console.WriteLine("Deseja continuar? ");
            Console.WriteLine("1. Sim");
            Console.WriteLine("0. Não");
            int escolhaPreco = int.Parse(Console.ReadLine());
            if (escolhaPreco == 0)
            {
            }
            return useCase.ExecutarRecuperarPorId(escolhaPreco);
        }
    }
}
