using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class HistoricoAutomovel
    {
        public static void Exibir()
        {
            try
            {
                Console.Clear();
                var automovelRepositorio = new AutomovelRepositorio();
                var useCase = new ListarAutomovelUseCase(automovelRepositorio);
                useCase.ExecutarDadosCompletos();
                Console.WriteLine();
                Console.WriteLine("Digite uma tecla para voltar ao menu anterior");
                Console.ReadKey();
                SubMenuVeiculos.Exibir();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

    }
}
