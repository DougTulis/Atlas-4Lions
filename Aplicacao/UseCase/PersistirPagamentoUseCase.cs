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
    public class PersistirPagamentoUseCase
    {
        private readonly ICrud<PagamentoDTO> pagamentoRepositorio;
        public PersistirPagamentoUseCase(ICrud<PagamentoDTO> pagamentoRepositorio)
        {
            this.pagamentoRepositorio = pagamentoRepositorio;
        }

        public void Executar(PagamentoDTO _pagamento)
        {

            pagamentoRepositorio.Adicionar(_pagamento);
        }
    }
}
