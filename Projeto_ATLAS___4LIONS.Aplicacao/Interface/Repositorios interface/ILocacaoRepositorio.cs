using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using System.Collections.Generic;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface
{
    public interface ILocacaoRepositorio
    {
        int Adicionar(LocacaoDTO locacaoDto); 
        void Atualizar(LocacaoDTO locacaoDto);
        void Deletar(int id); 
        LocacaoDTO? RecuperarPorId(int id); 
        IEnumerable<LocacaoDTO> ListarTodas();
        IEnumerable<LocacaoDTO> ListarStatusAndamento();
    }
}
