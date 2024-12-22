using Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus
{
    public class SubMenuPessoas
    {
        public static void Exibir()
        {
            Console.Clear();
            Console.WriteLine("************************");
            Console.WriteLine("Gerenciamento de Pessoas");
            Console.WriteLine("************************");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("1. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Cadastrar Pessoa");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Historico de Pessoas");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("3. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Excluir Pessoas");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("0. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Voltar ao menu inicial");
            Console.WriteLine("Escolha uma opção: ");
            int Escolha = int.Parse(Console.ReadLine());
            ExecutarEscolha(Escolha);

        }
        static void ExecutarEscolha(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    CadastroPessoas.Cadastrar();
                    break;
                case 2:
                    HistoricoPessoas.Exibir();
                    break;
                case 3:
                    DeletarPessoas.Deletar();
                    break;
                case 0:
                    MenuInicial.Exibir();
                    break;
            }
        }
    }
}