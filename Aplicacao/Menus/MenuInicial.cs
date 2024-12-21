using Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus
{
    public class MenuInicial
    {
        public static void Exibir()
        {
            LogoTipo.Exibir();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("1. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Gerenciamento de Pessoas");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Gerenciamento de Veículos");
            Console.Write("Escolha uma opção: ");
            int escolha = int.Parse(Console.ReadLine());
            ExecutarEscolha(escolha);
        }
        static void ExecutarEscolha(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    SubMenuPessoas.Exibir();
                    break;

                case 2:
                    SubMenuVeiculos.Exibir();
                    break;

            }
        }
    }
}
