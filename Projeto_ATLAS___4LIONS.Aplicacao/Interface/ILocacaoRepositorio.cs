using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface
{
    public interface ILocacaoRepositorio
    {
        public IEnumerable<LocacaoDTO> ListarTodos();

        public IEnumerable<LocacaoDTO> PopularLista(MySqlDataReader dataReader);
        public void Adicionar(LocacaoDTO objeto);
        public void Deletar(LocacaoDTO objeto);
        public LocacaoDTO? RecuperarPorId(int id);
        public IEnumerable<LocacaoDTO> ListarPorStatusAndamento();
        public void AtualizarStatus(int locacaoId, EStatusLocacao novoStatus);
    }
}
