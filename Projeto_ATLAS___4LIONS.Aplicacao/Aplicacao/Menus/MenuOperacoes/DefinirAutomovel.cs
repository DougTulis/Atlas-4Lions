using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class DefinirAutomovel
    {
        public static AutomovelDTO? Definir(IAutomovelRepositorio automovelRepositorio, ListarAutomovelUseCase useCaseListarAutomovel)
        {
            Console.Clear();
            useCaseListarAutomovel.ExecutarStatusGaragem();
            Console.Write("Selecione o ID do automovel que será locado:  ");
            int escolhaAutomovel = int.Parse(Console.ReadLine());
            return automovelRepositorio.RecuperarPorId(escolhaAutomovel);
        }
    }
}
