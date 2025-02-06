using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus
{
    public class SubMenuLocacoes
    {
        private readonly ILocacaoRepositorio _locacaoRepositorio;
        private readonly IPessoaRepositorio _pessoaRepositorio;
        private readonly IAutomovelRepositorio _automovelRepositorio;
        private readonly ITabelaPrecoRepositorio _tabelaPrecoRepositorio;
        private readonly IParcelaRepositorio _parcelaRepositorio;
        private readonly IPendenciaFinanceiraRepositorio _pendenciaFinanceiraRepositorio;

        public SubMenuLocacoes(ILocacaoRepositorio locacaoRepositorio, IPessoaRepositorio pessoaRepositorio, IAutomovelRepositorio automovelRepositorio, ITabelaPrecoRepositorio tabelaPrecoRepositorio, IParcelaRepositorio parcelaRepositorio, IPendenciaFinanceiraRepositorio pendenciaFinanceiraRepositorio)
        {
            _locacaoRepositorio = locacaoRepositorio;
            _pessoaRepositorio = pessoaRepositorio;
            _automovelRepositorio = automovelRepositorio;
            _tabelaPrecoRepositorio = tabelaPrecoRepositorio;
            _parcelaRepositorio = parcelaRepositorio;
            _pendenciaFinanceiraRepositorio = pendenciaFinanceiraRepositorio;
        }

        public void Exibir()
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
            Console.Write("4. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Processar Locação");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("0. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Voltar ao menu inicial");
            Console.WriteLine("Escolha uma opção: ");
            int escolha = int.Parse(Console.ReadLine());
            ExecutarEscolha(escolha);

        }
        public  void ExecutarEscolha(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    CadastroLocacao cadLocacao = new CadastroLocacao(_locacaoRepositorio, _pessoaRepositorio, _automovelRepositorio, _tabelaPrecoRepositorio, _parcelaRepositorio, _pendenciaFinanceiraRepositorio);
                    cadLocacao.Cadastrar();

                    break;
                case 2:
                    HistoricoLocacao histLocacao = new HistoricoLocacao(_locacaoRepositorio);
                    histLocacao.Exibir();
                    break;
                case 3:
                    RegistroPagamento regPagamento = new RegistroPagamento(_pendenciaFinanceiraRepositorio, _parcelaRepositorio);
                    regPagamento.Exibir();
                    break;
                case 4:
                    ProcessamentoLocacao processarLocacao = new ProcessamentoLocacao(_locacaoRepositorio, _automovelRepositorio);
                    processarLocacao.Exibir();
                    break;
                case 0:
                    MenuInicial menuInicial = new MenuInicial();
                    menuInicial.Exibir();
                    break;
            }
        }
    }
}

