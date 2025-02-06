using Projeto_ATLAS___4LIONS.Dominio.Entidades;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class DefinirPrecos
    {

        public static IList<TabelaPreco> Definir(int automovelId)
        {

            var lista = new List<TabelaPreco>();
            Console.Clear();
            Console.WriteLine("TABELA DE PREÇOS");
            for (int i = 0; i < 1; i++)
            {
                Console.Write("Insira a descrição (ex: popular 2 portas): ");
                string descricao = Console.ReadLine();
                Console.Write("Valor em R$: ");
                decimal valor = decimal.Parse(Console.ReadLine());
                var preco = new TabelaPreco(descricao, valor, automovelId);
                lista.Add(preco);
            }
            return lista;
        }
    }
}
