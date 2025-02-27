using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface
{
    public interface IListarParcelaUseCase
    {

        public IEnumerable<ParcelaDTO> ExecutarRecuperacaoPorPendFin(Guid idPendencia);
        public ParcelaDTO? ExecutarRecuperacaoPorId(Guid id);
    }
}
