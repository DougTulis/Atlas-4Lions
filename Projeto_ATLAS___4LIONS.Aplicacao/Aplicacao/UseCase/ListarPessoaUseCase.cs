
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarPessoaUseCase
    {
        private readonly IPessoaRepositorio pessoaRepositorio;
        public ListarPessoaUseCase(IPessoaRepositorio pessoaRepositorio)
        {
            this.pessoaRepositorio = pessoaRepositorio;
        }

        public IEnumerable<PessoaDTO> ExecutarDadosCompletos()
        {
            return pessoaRepositorio.ListarTodos();
        }
        public void ExecutarDadosBreves()
        {
            foreach (var item in pessoaRepositorio.ListarTodos())
            {
                Console.WriteLine(item.ExibirDadosBreves());
            }
        }
        public PessoaDTO? ExecutarRecuperarPorId(int id)
        {
            return pessoaRepositorio.RecuperarPorId(id);


        }
        public IEnumerable<PessoaDTO> ExecutarRecuperacaoSemCnh()
        {
          return pessoaRepositorio.ListarSemCNH();


        }


    }
}
