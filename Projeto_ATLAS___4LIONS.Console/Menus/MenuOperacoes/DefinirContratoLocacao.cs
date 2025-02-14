using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class DefinirContratoLocacao
    {
        public static ETipoLocacao Definir()
        {
            Console.Clear();
            Console.WriteLine("1. Contrato");
            Console.WriteLine("2. Diária");
            Console.Write("Determine o tipo da locação: ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    return ETipoLocacao.CONTRATO;
                case 2:
                    return ETipoLocacao.DIARIA;
                default:
                    Thread.Sleep(2000);
                    return Definir();
            }
        }
    }
}
