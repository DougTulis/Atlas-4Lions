using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface
{
    public interface IParcelaRepositorio
    {
        public IEnumerable<ParcelaDTO> ListarTodos();

        public IEnumerable<ParcelaDTO> PopularLista(MySqlDataReader dataReader);
        public void Adicionar(ParcelaDTO objeto);
        public void Deletar(ParcelaDTO objeto);
        public ParcelaDTO? RecuperarPorId(int id);
        public IEnumerable<ParcelaDTO> ListarPorPendFin(int id);
        public void Atualizar(ParcelaDTO parcelaDto);
    }
}
