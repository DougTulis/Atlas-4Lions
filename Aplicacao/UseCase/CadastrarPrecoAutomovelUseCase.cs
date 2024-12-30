using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.UseCase
{
    public class CadastrarPrecoAutomovelUseCase
    {
        private readonly ICrud<TabelaPrecoDTO> tabelaRepositorio;
        public CadastrarPrecoAutomovelUseCase(ICrud<TabelaPrecoDTO> tabelaRepositorio)
        {
            this.tabelaRepositorio = tabelaRepositorio;
        }
        public void Executar(TabelaPrecoDTO _preco)
        {
            tabelaRepositorio.Adicionar(_preco);

        }

    }
}
