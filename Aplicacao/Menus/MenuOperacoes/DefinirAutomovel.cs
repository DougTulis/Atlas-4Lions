using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
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
    public class DefinirAutomovel
    {
        public static AutomovelDTO? Definir(AutomovelRepositorio automovelRepositorio, ListarAutomovelUseCase useCaseListarAutomovel)
        {
            Console.Clear();
            useCaseListarAutomovel.ExecutarStatusGaragem();
            Console.Write("Selecione o ID do automovel que será locado:  ");
            int escolhaAutomovel = int.Parse(Console.ReadLine());
            return automovelRepositorio.RecuperarPorId(escolhaAutomovel);
        }
    }
}
