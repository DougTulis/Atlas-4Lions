using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class DefinirLocatario
    {
 
        public static PessoaDTO Definir(PessoaRepositorio pessoaRepositorio, ListarPessoaUseCase useCaseListarPessoa)
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
