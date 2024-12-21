using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarAutomovelUseCase
    {
    
            private readonly ICrud<AutomovelDTO> automovelRepositorio;
            public ListarAutomovelUseCase(ICrud<AutomovelDTO> automovelRepositorio)
            {
                this.automovelRepositorio = automovelRepositorio;
            }

            public void ExecutarDadosCompletos()
            {
                foreach (var item in automovelRepositorio.Listar())
                {
                    Console.WriteLine(item);
                }
            }
            public void ExecutarDadosBreves()
            {
                foreach (var item in automovelRepositorio.Listar())
                {
                    Console.WriteLine(item.ExibirDadosBreves());
                }
            }
        }
}
