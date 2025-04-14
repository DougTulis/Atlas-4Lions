using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface
{
    public interface IPendenciaFinanceiraRepositorio
    {
        public IEnumerable<PendenciaFinanceira> ListarTodos();
        public IEnumerable<PendenciaFinanceira> PopularLista(MySqlDataReader dataReader);
        public IList<object[]> ListarPagamentosPendente();
        public void Adicionar(PendenciaFinanceira objeto);
        public void Deletar(Guid id);
        public PendenciaFinanceira? RecuperarPorId(Guid id);
    }
}
