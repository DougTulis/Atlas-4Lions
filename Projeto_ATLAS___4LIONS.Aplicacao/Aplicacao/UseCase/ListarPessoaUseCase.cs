
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarPessoaUseCase : IListarPessoaUseCase
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
        public IEnumerable<PessoaDTO> ExecutarDadosBreves()
        {
            return pessoaRepositorio.ListarTodos();
   
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
