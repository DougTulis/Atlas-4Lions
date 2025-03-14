using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface
{
    public interface  ITabelaPrecoRepositorio
    {
        public IEnumerable<TabelaPreco> ListarTodos();
        public IEnumerable<TabelaPreco> PopularLista(MySqlDataReader dataReader);
        public void Adicionar(TabelaPreco objeto);
        public void Deletar(Guid id);
        public TabelaPreco? RecuperarPorId(Guid id);
    }
}
