using MySql.Data.MySqlClient;
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
    public class CadastroPessoa
    {
        public static void Cadastrar()
        {
            try
            {
                Console.Clear();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Contato: ");
                string contato = Console.ReadLine();
                Console.Write("Data de nascimento: ");
                DateTime nascimento = DateTime.Parse(Console.ReadLine());
                Console.Write("Cpf: ");
                string cpf = Console.ReadLine();
                var pessoa = new PessoaDTO(nome, email, contato, nascimento, cpf);
                var pessoaRepositorio = new PessoaRepositorio();
                var UseCase = new CadastrarPessoaUseCase(pessoaRepositorio);
                UseCase.Executar(pessoa);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            Console.WriteLine("Pessoa Cadastrada com sucesso... Voltando ao menu principal");
            Thread.Sleep(2500);
            Console.Clear();
            MenuInicial.Exibir();

        }
    }
}
