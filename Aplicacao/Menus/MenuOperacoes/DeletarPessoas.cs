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
    public class DeletarPessoas
    {
        public static void Deletar()
        {
            Console.Clear();
                var repositorioPessoa = new PessoaRepositorio();
                var useCaseListar = new ListarPessoaUseCase(repositorioPessoa);
                var useCaseDeletar = new DeletarPessoaUseCase(repositorioPessoa);

                useCaseListar.ExecutarDadosBreves();
                Console.Write("Informe o ID da pessoa que você deseja deletar: ");
                int escolha  = int.Parse(Console.ReadLine());
                var pessoaFiltrada = repositorioPessoa.RecuperarPorId(escolha);
                useCaseDeletar.Executar(pessoaFiltrada);
            // "Pessoa adicionada com sucesso!"
                Thread.Sleep(2500);
                Console.Clear();
            SubMenuPessoas.Exibir(); 
        }
    }
}
