using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class ListarLocacoesUseCase
    {

        private readonly ICrud<LocacaoDTO> locacaoRepositorio;
        public ListarLocacoesUseCase(ICrud<LocacaoDTO> locacaoRepositorio)
        {
            this.locacaoRepositorio = locacaoRepositorio;
        }

        public void Executar()
        {
            foreach (var item in locacaoRepositorio.Listar())
            {
                Console.WriteLine(item);
            }
        }
    }
}
