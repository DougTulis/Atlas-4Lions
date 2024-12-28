using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class DefinirPrecos
    {

        public static IList<TabelaPreco> Definir(int automovelId)
        {
      
            var lista = new List<TabelaPreco>();
            Console.Clear();
            Console.WriteLine("TABELA DE PREÇOS");
            Console.Write("Quantos preços você deseja definir ao automovel? ");
            int quantidade = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Insira a descrição (ex: popular 2 portas): ");
                string descricao = Console.ReadLine();
                Console.Write("Valor em R$: ");
                decimal valor = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                var preco = new TabelaPreco(descricao,valor,automovelId);
                lista.Add(preco);
            }
            return lista;
        }
    }
}
