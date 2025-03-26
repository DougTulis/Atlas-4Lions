using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface
{
    public interface IListarPessoaUseCase
    {
        public IEnumerable<PessoaDTO> Executar();
        public PessoaDTO? ExecutarRecuperarPorId(Guid id);
        public IEnumerable<PessoaDTO> ExecutarRecuperacaoSemCnh();
        public IEnumerable<PessoaDTO> ExecutarRecuperacaoComCnh();

    }
}
