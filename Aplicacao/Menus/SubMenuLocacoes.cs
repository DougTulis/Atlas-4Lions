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
            var pessoaRepositorio = new PessoaRepositorio();
            var useCase = new ListarPessoaUseCase(pessoaRepositorio);
            useCase.ExecutarDadosBreves();
        }
    }
}
