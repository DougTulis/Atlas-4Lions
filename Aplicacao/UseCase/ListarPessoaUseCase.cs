
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarPessoaUseCase
    {
        private readonly ICrud<PessoaDTO> pessoaRepositorio;
        public ListarPessoaUseCase(ICrud<PessoaDTO> pessoaRepositorio)
        {
            this.pessoaRepositorio = pessoaRepositorio;
        }

        public void ExecutarDadosCompletos()
        {
            foreach (var item in pessoaRepositorio.ListarTodos())
            {
                Console.WriteLine(item);
            }
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
        public void ExecutarRecuperacaoSemCnh()
        {
            PessoaRepositorio pessoaRepositorio = new PessoaRepositorio();
            var lista = pessoaRepositorio.ListarSemCNH();
            foreach (var item in lista)
            {
                Console.WriteLine(item.ExibirDadosBreves());
            }

        }


    }
}
