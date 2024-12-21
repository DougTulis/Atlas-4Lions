using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class DeletarPessoa
    {
        public static void Exibir()
        {
            Console.Clear();
            try
            {
                var repositorioPessoa = new PessoaRepositorio();
                var useCaseListar = new ListarPessoaUseCase(repositorioPessoa);
                var useCaseDeletar = new DeletarPessoaUseCase(repositorioPessoa);

                useCaseListar.ExecutarDadosBreves();
                Console.Write("Informe o ID da pessoa que você deseja deletar: ");
                int escolha  = int.Parse(Console.ReadLine());
                var pessoaFiltrada = repositorioPessoa.RecuperarPor(a => a.Id == escolha);
                useCaseDeletar.Executar(pessoaFiltrada);
                Console.WriteLine("Pessoa deletada com sucesso! Voltando ao menu anterior....");
                Thread.Sleep(2500);
                Console.Clear();
                SubMenuPessoas.Exibir();
            }catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            
        }
    }
}
