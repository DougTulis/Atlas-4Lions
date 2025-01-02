using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class CadastroCnh
    {

        public static void Cadastrar(PessoaDTO pessoa)
        {
            Console.WriteLine("Deseja vincular CNH? ");
            Console.WriteLine("1. Sim");
            Console.WriteLine("2. Não");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Console.Clear();
                Console.Write(" Numero da CNH: ");
                string numeroCnh = Console.ReadLine();
                Console.Write("Vencimento da CNH: ");
                DateTime vencimento = DateTime.Parse(Console.ReadLine());
                pessoa.NumeroCnh = numeroCnh;
                pessoa.VencimentoCnh = vencimento;
            }
        }
    }
}
