using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class CadastroCnh
    {
        private readonly IPessoaRepositorio pessoaRepositorio;

        public CadastroCnh(IPessoaRepositorio pessoaRepositorio)
        {
            this.pessoaRepositorio = pessoaRepositorio;
        }

        public void Cadastrar()
        {
            Console.Clear();
            ListarPessoaUseCase useCaseListarPessoa = new ListarPessoaUseCase(pessoaRepositorio);
            IncluirCnhUseCase useCaseIncluirCnh = new IncluirCnhUseCase(pessoaRepositorio);

            useCaseListarPessoa.ExecutarRecuperacaoSemCnh();
            Console.Write("Escolha o ID da pessoa: ");
            int escolha = int.Parse(Console.ReadLine());
            var pessoaFiltrada = pessoaRepositorio.RecuperarPorId(escolha);
            Console.Write("Numero da CNH: ");
            string numero = Console.ReadLine();
            Console.Write("Vencimento: ");
            DateTime vencimento = DateTime.Parse(Console.ReadLine());

            useCaseIncluirCnh.Executar(pessoaFiltrada, numero, vencimento);
            Console.Clear();
            MenuInicial menuInicial = new MenuInicial();
            menuInicial.Exibir();
        }
    }
}
