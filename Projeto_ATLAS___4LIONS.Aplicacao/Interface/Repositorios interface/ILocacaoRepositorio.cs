using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System.Collections.Generic;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface
{
    public interface ILocacaoRepositorio
    {
        void Adicionar(Locacao locacaoDto); 
        void Atualizar(Locacao locacaoDto);
        void Deletar(Guid id); 
        LocacaoDTO? RecuperarPorId(Guid id); 
        IEnumerable<LocacaoDTO> ListarTodas();
        IEnumerable<LocacaoDTO> ListarStatusAndamento();
        void AtualizarStatusLocacao(int locacaoId, EStatusLocacao novoStatus);
    }
}
