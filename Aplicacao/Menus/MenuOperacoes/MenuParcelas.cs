using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Menus.MenuOperacoes
{
    public class MenuParcelas
    {
        public static int Exibir(ETipoLocacao tipoLocacao, EEspecie especie)
        {
         
            if (especie == EEspecie.CREDITO && (tipoLocacao == ETipoLocacao.ANUALCONTRATO || tipoLocacao == ETipoLocacao.MENSALCONTRATO))
            {
                Console.Write("Parcelas: ");
                int parcelas = int.Parse(Console.ReadLine());
                return parcelas;
            }
            return 1; // se caso for pix, debito e dinheiro

        }
    }
}
