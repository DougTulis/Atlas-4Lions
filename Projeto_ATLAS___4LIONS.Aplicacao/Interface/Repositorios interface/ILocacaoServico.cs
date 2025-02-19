using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface.Servicos
{
    public interface ILocacaoService
    {
        int CadastrarLocacao(PessoaDTO locatarioDto, PessoaDTO condutorDto, AutomovelDTO automovelDto, DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao);
    }
}
