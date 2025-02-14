using Projeto_ATLAS___4LIONS.Aplicacao.Interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus
{
    public class MenuInicial
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;
        private readonly IAutomovelRepositorio _automovelRepositorio;
        private readonly ILocacaoRepositorio _locacaoRepositorio;
        private readonly ITabelaPrecoRepositorio _tabelaPrecoRepositorio;
        private readonly IParcelaRepositorio _parcelaRepositorio;
        private readonly IPendenciaFinanceiraRepositorio _pendenciaFinanceiraRepositorio;

        public MenuInicial()
        {
        }

        public MenuInicial(IPessoaRepositorio pessoaRepositorio, IAutomovelRepositorio automovelRepositorio, ILocacaoRepositorio locacaoRepositorio, ITabelaPrecoRepositorio tabelaPrecoRepositorio, IParcelaRepositorio parcelaRepositorio, IPendenciaFinanceiraRepositorio pendenciaFinanceiraRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
            _automovelRepositorio = automovelRepositorio;
            _locacaoRepositorio = locacaoRepositorio;
            _tabelaPrecoRepositorio = tabelaPrecoRepositorio;
            _parcelaRepositorio = parcelaRepositorio;
            _pendenciaFinanceiraRepositorio = pendenciaFinanceiraRepositorio;
        }

        public void Exibir()
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
        public void ExecutarEscolha(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    SubMenuPessoas subMenuPessoas = new SubMenuPessoas(_pessoaRepositorio);
                    subMenuPessoas.Exibir();
                    break;
                case 2:
                    SubMenuVeiculos subMenuVeiculos = new SubMenuVeiculos(_automovelRepositorio, _tabelaPrecoRepositorio);
                    subMenuVeiculos.Exibir();
                    break;
                case 3:
                    SubMenuLocacoes subMenuLocacoes = new SubMenuLocacoes(_locacaoRepositorio,_pessoaRepositorio,_automovelRepositorio,_tabelaPrecoRepositorio,_parcelaRepositorio,_pendenciaFinanceiraRepositorio);
                    subMenuLocacoes.Exibir();
                    break;

            }
        }
    }
}
