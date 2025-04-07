using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Interface
{
    public interface IPessoaRepositorio
    {
        public IEnumerable<Pessoa> ListarTodos();
        public IEnumerable<Pessoa> PopularLista(MySqlDataReader dataReader);
        public void Adicionar(Pessoa objeto);
        public void AtualizarDados<T>(Guid idPessoa, string campo, T valorNovo);
        public bool NumeroCnhExiste(string numeroCnh);
        public bool NumeroDocumentoExiste(string documento);
        public IEnumerable<Pessoa> ListarComCNH();
        public void Deletar(Guid id);
        public bool TemLocacaoVinculada(Guid id);
        public Pessoa? RecuperarPorId(Guid id);
        public IEnumerable<Pessoa> ListarSemCNH();
        public void IncluirCNH(Guid id, string numeroCnh, DateTime vencimentoCnh);
    }
}
