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
            Console.Clear();
            LogoTipo.Exibir();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("1. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Gerenciamento de Pessoas");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Gerenciamento de Veículos");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("3. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Gerenciamento de Locações");
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
                case 3:
                    SubMenuLocacoes.Exibir();
                    break;

            }
        }
    }
}
