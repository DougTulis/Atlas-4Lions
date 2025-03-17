using MySql.Data.MySqlClient;
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
        Locacao? RecuperarPorId(Guid id);
        IEnumerable<Locacao> PopularLista(MySqlDataReader dataReader);
        IEnumerable<Locacao> ListarTodas();
        IEnumerable<Locacao> ListarStatusAndamento();
        void AtualizarStatusLocacao(Guid locacaoId, EStatusLocacao novoStatus);
    }
}
