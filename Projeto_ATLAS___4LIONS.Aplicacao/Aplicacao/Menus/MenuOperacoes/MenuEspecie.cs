using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class MenuEspecie
    {
        public static EEspecie Exibir()
        {
            Console.Clear();
            Console.WriteLine("1. PIX");
            Console.WriteLine("2. DINHEIRO");
            Console.WriteLine("3. DEBITO");
            Console.WriteLine("4. CRÉDITO ");
            Console.Write("Selecione o método de pagamento: ");
            int escolha = int.Parse(Console.ReadLine());
            EEspecie especie = (EEspecie)escolha;
            return especie;
        }
    }
}
