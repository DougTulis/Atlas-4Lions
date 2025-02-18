using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface
{
    public interface IListarLocacoesUseCase
    {
        public IEnumerable<LocacaoDTO> Executar();
        public IEnumerable<LocacaoDTO> ExecutarRecuperacaoStatusAndamento();
        public LocacaoDTO? ExecutarRecuperarPorId(int id);

    }
}
