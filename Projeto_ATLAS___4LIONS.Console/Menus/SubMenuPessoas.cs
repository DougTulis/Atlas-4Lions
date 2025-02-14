using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus
{
    public class SubMenuPessoas
    {
        private readonly IPessoaRepositorio pessoaRepositorio;

        public SubMenuPessoas(IPessoaRepositorio pessoaRepositorio)
        {
            this.pessoaRepositorio = pessoaRepositorio;
        }

        public void Exibir()
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
            Console.Write("4. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Vincular CNH");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("0. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Voltar ao menu inicial");
            Console.WriteLine("Escolha uma opção: ");
            int Escolha = int.Parse(Console.ReadLine());
            ExecutarEscolha(Escolha);

        }
        public void ExecutarEscolha(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    CadastroPessoas cadPessoas = new CadastroPessoas(pessoaRepositorio);
                    cadPessoas.Cadastrar();
                    break;
                case 2:
                    HistoricoPessoas histPessoas = new HistoricoPessoas(pessoaRepositorio);
                    histPessoas.Exibir();
                    break;
                case 3:
                    DeletarPessoas deletarPessoas = new DeletarPessoas(pessoaRepositorio);
                    deletarPessoas.Deletar();
                    break;
                case 4:
                    CadastroCnh cadCnh = new CadastroCnh(pessoaRepositorio);
                    cadCnh.Cadastrar();
                    break;
                case 0:
                    MenuInicial menuInicial = new MenuInicial();
                    menuInicial.Exibir();
                    break;
            }
        }
    }
}