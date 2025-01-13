using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface
{
    public interface ICrud<T>
    {
        public IEnumerable<T> ListarTodos();

        public IEnumerable<T> PopularLista(MySqlDataReader dataReader);
        public void Adicionar(T objeto);
        public void Deletar(T objeto);
        public T? RecuperarPorId(int id);
    }
}
