using Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus
{
    public class SubMenuLocacoes
    {
        public static void Exibir()
        {

            Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("Gerenciamento de Locações");
            Console.WriteLine("**************************");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("1. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Nova Locação");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Historico de Locações");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("3. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Registrar Pagamento");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("0. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Voltar ao menu inicial");
            Console.WriteLine("Escolha uma opção: ");
            int escolha = int.Parse(Console.ReadLine());
            ExecutarEscolha(escolha);

        }
        static void ExecutarEscolha(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    CadastroLocacao.Cadastrar();
                    break;
                case 2:
                    HistoricoPessoas.Exibir();
                    break;
                case 3:
                   // DeletarPessoas.Deletar();
                    break;
                case 0:
                    MenuInicial.Exibir();
                    break;
            }
        }
    }
}

