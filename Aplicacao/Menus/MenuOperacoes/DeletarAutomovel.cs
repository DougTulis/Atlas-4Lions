using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class DeletarAutomovel 
    {
        public static void Deletar()
        {
            Console.Clear();
                var repositorioAutomovel = new AutomovelRepositorio();
                var useCaseListar = new ListarAutomovelUseCase(repositorioAutomovel);
                var useCaseDeletar = new DeletarAutomovelUseCase(repositorioAutomovel);
                useCaseListar.ExecutarDadosBreves();
                Console.Write("Informe o ID do veiculo que você deseja deletar: ");
                int escolha = int.Parse(Console.ReadLine());
                var veiculoFiltrado = repositorioAutomovel.RecuperarPorId(escolha);
                useCaseDeletar.Executar(veiculoFiltrado);
                Console.WriteLine("Automovel deletado com sucesso! Voltando ao menu anterior....");
                Thread.Sleep(2500);
                Console.Clear();
                SubMenuVeiculos.Exibir();
            }

        }
   
    }
