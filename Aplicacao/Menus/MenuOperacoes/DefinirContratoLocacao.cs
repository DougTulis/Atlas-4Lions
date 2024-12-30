using Projeto_ATLAS___4LIONS.Aplicacao.UseCase;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using Projeto_ATLAS___4LIONS.Infra.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Console.WriteLine("Opção invalida. tente novamente.");
                    Thread.Sleep(2000);
                    return Definir();
            }
        }
    }
}
