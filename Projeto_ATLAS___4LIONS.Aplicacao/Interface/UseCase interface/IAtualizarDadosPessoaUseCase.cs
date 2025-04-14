using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.RespostaPadrao;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface.UseCase_interface
{
    public interface IAtualizarDadosPessoaUseCase
    {
        public RespostaPadrao<string> Executar<T>(PessoaDTO pessoa, string campoBanco,string campoSelecionado, T dados);

    }
}
