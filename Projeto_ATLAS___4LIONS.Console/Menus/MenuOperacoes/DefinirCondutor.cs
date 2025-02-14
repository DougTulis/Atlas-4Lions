using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class DefinirCondutor
    {
        public static PessoaDTO Definir(IPessoaRepositorio pessoaRepositorio, ListarPessoaUseCase useCaseListarPessoa)
        {
            Console.Clear();
            foreach (var item in useCaseListarPessoa.ExecutarDadosBreves())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.Write("Selecione o Id do condutor: ");
            int escolhaCondutor = int.Parse(Console.ReadLine());
            var condutorDto = useCaseListarPessoa.ExecutarRecuperarPorId(escolhaCondutor);
            return condutorDto;
        }
    }

}

