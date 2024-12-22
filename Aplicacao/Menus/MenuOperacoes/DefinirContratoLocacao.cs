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
            Console.WriteLine("1. Fim de semana");
            Console.WriteLine("2. Diária");
            Console.WriteLine("3. Mensal");
            Console.WriteLine("4. Semanal");
            Console.WriteLine("5. Anual");
            Console.Write("Determine o tipo da locação: ");
            int escolhaTipoLocacao = int.Parse(Console.ReadLine());
            if (escolhaTipoLocacao == 3 || escolhaTipoLocacao == 5)
            {
                Console.WriteLine("Deseja promover pra contrato? ");
                Console.WriteLine("1. Sim");
                Console.WriteLine("2. Não");
                int escolhaContrato = int.Parse(Console.ReadLine());
            }
            if (escolhaTipoLocacao == 3  && escolhaTipoLocacao == 1)
            {
                return ETipoLocacao.MENSALCONTRATO;
            }

            if (escolhaTipoLocacao == 5 && escolhaTipoLocacao == 1)
            {
                return ETipoLocacao.ANUALCONTRATO;
            }

            if (escolhaTipoLocacao == 1)
            {
                return ETipoLocacao.FIMSEMANA;
            }

            if (escolhaTipoLocacao == 2)
            {
                return ETipoLocacao.DIARIA;
            }

            return ETipoLocacao.FIMSEMANA;




        }
    }
}
