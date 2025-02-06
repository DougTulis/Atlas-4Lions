using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class DeletarPessoas
    {

        private readonly IPessoaRepositorio pessoaRepositorio;

        public DeletarPessoas(IPessoaRepositorio pessoaRepositorio)
        {
            this.pessoaRepositorio = pessoaRepositorio;
        }

        public void Deletar()
        {

            Console.Clear();
            var useCaseListar = new ListarPessoaUseCase(pessoaRepositorio);
            var useCaseDeletar = new DeletarPessoaUseCase(pessoaRepositorio);

            useCaseListar.ExecutarDadosBreves();
            Console.Write("Informe o ID da pessoa que você deseja deletar: ");
            int escolha = int.Parse(Console.ReadLine());
            var pessoaFiltrada = pessoaRepositorio.RecuperarPorId(escolha);
            useCaseDeletar.Executar(pessoaFiltrada);
            // "Pessoa adicionada com sucesso!"
            Thread.Sleep(2500);
            Console.Clear();
            SubMenuPessoas subPessoas = new SubMenuPessoas(pessoaRepositorio);
            subPessoas.Exibir();
        }
    }
}
