using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class HistoricoPessoas
    {
        private readonly IPessoaRepositorio pessoaRepositorio;

        public HistoricoPessoas(IPessoaRepositorio pessoaRepositorio)
        {
            this.pessoaRepositorio = pessoaRepositorio;
        }

        public void Exibir()
        {
            var useCase = new ListarPessoaUseCase(pessoaRepositorio);
            foreach (var item in useCase.ExecutarDadosCompletos())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Digite uma tecla para voltar ao menu anterior");
            Console.ReadKey();
            SubMenuPessoas subPessoas = new SubMenuPessoas(pessoaRepositorio);
            subPessoas.Exibir();

        }

    }
}
