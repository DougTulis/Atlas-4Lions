using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface
{
    public interface IPessoaRepositorio
    {
        public IEnumerable<PessoaDTO> ListarTodos();

        public IEnumerable<PessoaDTO> PopularLista(MySqlDataReader dataReader);
        public void Adicionar(PessoaDTO objeto);
        public void Deletar(PessoaDTO objeto);
        public PessoaDTO? RecuperarPorId(int id);
        public IEnumerable<PessoaDTO> ListarSemCNH();
        public void IncluirCNH(int id, string numeroCnh, DateTime vencimentoCnh);
    }
}
