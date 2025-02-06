using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class DefinirLocatario
    {

        public static PessoaDTO Definir(IPessoaRepositorio pessoaRepositorio, ListarPessoaUseCase useCaseListarPessoa)
        {
            useCaseListarPessoa.ExecutarDadosBreves();
            Console.WriteLine();
            Console.Write("Selecione o Id do locatário: ");
            int escolhaLocatario = int.Parse(Console.ReadLine());
            var locatarioDto = useCaseListarPessoa.ExecutarRecuperarPorId(escolhaLocatario);
            return locatarioDto;
        }

    }
}
