using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus
{
    public class SubMenuVeiculos
    {

        private readonly IAutomovelRepositorio _automovelRepositorio;
        private readonly ITabelaPrecoRepositorio _tabelaPrecoRepositorio;

        public SubMenuVeiculos(IAutomovelRepositorio automovelRepositorio, ITabelaPrecoRepositorio tabelaPrecoRepositorio)
        {
            _automovelRepositorio = automovelRepositorio;
            _tabelaPrecoRepositorio = tabelaPrecoRepositorio;
        }

        public void Exibir()
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("0. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Voltar ao menu inicial");
            Console.WriteLine("Escolha uma opção: ");
            int escolha = int.Parse(Console.ReadLine());
            ExecutarEscolha(escolha);

        }
        public void ExecutarEscolha(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    CadastroVeiculos cadVeiculo = new CadastroVeiculos(_automovelRepositorio,_tabelaPrecoRepositorio);
                    cadVeiculo.Cadastrar();
                    break;
                case 2:
                    HistoricoAutomovel histVeiculo = new HistoricoAutomovel(_automovelRepositorio);
                    histVeiculo.Exibir();
                    break;
                case 3:
                    DeletarAutomovel deletarAutomovel = new DeletarAutomovel();
                    deletarAutomovel.Deletar();
                    break;
                case 0:
                    MenuInicial menuInicial = new MenuInicial();
                    menuInicial.Exibir();
                    break;
            }
        }
    }
}