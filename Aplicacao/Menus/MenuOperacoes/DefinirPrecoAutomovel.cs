using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class DefinirPrecoAutomovel
    {
        public static TabelaPrecoDTO Definir(AutomovelDTO automovel, TabelaPrecoRepositorio precoRepositorio, ListarTabelaPrecoUseCase useCase)
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
            return  useCase.ExecutarRecuperarPorId(escolhaPreco);
        }
    }
}
