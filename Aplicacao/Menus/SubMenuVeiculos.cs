using Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus
{
    public class SubMenuVeiculos
    {
            public static void Exibir()
            {
                Console.Clear();
                Console.WriteLine("************************");
                Console.WriteLine("Gerenciamento de Veículos");
                Console.WriteLine("************************");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("1. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Cadastrar Veículo");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("2. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Historico de Veículos");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("3. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Excluir Veículo");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Escolha uma opção: ");
                int Escolha = int.Parse(Console.ReadLine());
                ExecutarEscolha(Escolha);

            }
            static void ExecutarEscolha(int escolha)
            {
                switch (escolha)
                {
                    case 1:
                        CadastroVeiculos.Cadastrar();
                        break;
                }
            }
        }
}
