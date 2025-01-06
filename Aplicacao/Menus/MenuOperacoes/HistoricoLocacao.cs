using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class HistoricoLocacao
    {

        public static void Exibir()
        {
            var locacaoRepositorio = new LocacaoRepositorio();
            var useCaseListarLocacao = new ListarLocacoesUseCase(locacaoRepositorio);
            useCaseListarLocacao.Executar();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial");
            Console.ReadKey();
            MenuInicial.Exibir();

        }
    }
}
