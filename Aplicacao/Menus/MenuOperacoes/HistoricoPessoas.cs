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
    public class HistoricoPessoas
    {
        public static void Exibir()
        {
            try
            {
                var pessoaRepositorio = new PessoaRepositorio();
                var useCase = new ListarPessoaUseCase(pessoaRepositorio);
                useCase.ExecutarDadosCompletos();
                Console.WriteLine("Digite uma tecla para voltar ao menu anterior");
                Console.ReadKey();
                SubMenuPessoas.Exibir();
            
            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

    }
}
