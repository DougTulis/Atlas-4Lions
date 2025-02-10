using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;

namespace Projeto_ATLAS___4LIONS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pessoaRepositorio = new PessoaRepositorio();
            var automovelRepositorio = new AutomovelRepositorio();
            var locacaoRepositorio = new LocacaoRepositorio();
            var tabelaPrecoRepositorio = new TabelaPrecoRepositorio();
            var pendenciaFinanceiraRepositorio = new PendenciaFinanceiraRepositorio();
            var parcelaRepositorio = new ParcelaRepositorio();

            MenuInicial menuInicial = new MenuInicial(pessoaRepositorio, automovelRepositorio, locacaoRepositorio, tabelaPrecoRepositorio, parcelaRepositorio, pendenciaFinanceiraRepositorio);
            menuInicial.Exibir();
        }
    }
}
