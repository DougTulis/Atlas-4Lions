using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class CadastroCnh
    {

        public static void Cadastrar()
        {
            Console.Clear();
            PessoaRepositorio pessoaRepositorio = new PessoaRepositorio();
            ListarPessoaUseCase useCaseListarPessoa = new ListarPessoaUseCase(pessoaRepositorio);
            IncluirCnhUseCase useCaseIncluirCnh = new IncluirCnhUseCase(pessoaRepositorio);

            useCaseListarPessoa.ExecutarRecuperacaoSemCnh();
            Console.Write("Escolha o ID da pessoa: ");
            int escolha = int.Parse(Console.ReadLine());
            var pessoaFiltrada = pessoaRepositorio.RecuperarPorId(escolha);
            Console.Write("Numero da CNH: ");
            string numero = Console.ReadLine();
            Console.Write("Vencimento: ");
            DateTime vencimento = DateTime.Parse(Console.ReadLine());

            useCaseIncluirCnh.Executar(pessoaFiltrada,numero,vencimento);
            Console.Clear();
            MenuInicial.Exibir();
        }
    }
}
