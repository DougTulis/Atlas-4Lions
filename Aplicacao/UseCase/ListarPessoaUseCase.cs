
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;

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
            foreach (var item in pessoaRepositorio.Listar())
            {
                Console.WriteLine(item);
            }
        }
        public void ExecutarDadosBreves()
        {
            foreach (var item in pessoaRepositorio.Listar())
            {
                Console.WriteLine(item.ExibirDadosBreves());
            }
        }
        public PessoaDTO ExecutarRecuperarPor(Func<PessoaDTO, bool> filtro)
        {
            var lista = pessoaRepositorio.Listar();
            return lista.FirstOrDefault(filtro);
        }

    }
}
