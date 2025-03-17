using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.Interface_Adapter;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Infra.Servicos;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class TabelaPrecoRepositorio : ITabelaPrecoRepositorio
    {
        private readonly IMySqlAdaptadorConexao _conexaoAdapter;

        public TabelaPrecoRepositorio(IMySqlAdaptadorConexao conexaoAdapter)
        {
            _conexaoAdapter = conexaoAdapter;
        }

        public void Adicionar(TabelaPreco tabelaPreco)
        {

            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = @"
                INSERT INTO tabela_preco (id,data_criacao,descricao, valor)
                VALUES (@id,@data_criacao, @descricao, @valor)";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", tabelaPreco.Id);
                    cmd.Parameters.AddWithValue("@descricao", tabelaPreco.Descricao);
                    cmd.Parameters.AddWithValue("@valor", tabelaPreco.Valor);
                    cmd.Parameters.AddWithValue("@data_criacao  ", tabelaPreco.DataCriacao);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(Guid id)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = "DELETE FROM tabela_preco WHERE id = @id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public IEnumerable<TabelaPreco> ListarTodos()
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM tabela_preco";
                using var cmd = new MySqlCommand(sql, conexao);
                using var dataReader = cmd.ExecuteReader();
                return PopularLista(dataReader);
            }
        }
        public IEnumerable<TabelaPreco> PopularLista(MySqlDataReader dataReader)
        {
            var lista = new List<TabelaPreco>();
            while (dataReader.Read())
            {
                var id = Guid.Parse(dataReader["Id"].ToString());
                var descricao = Convert.ToString(dataReader["Descricao"]);
                var valor = Convert.ToDecimal(dataReader["Valor"]);
                var dataCriacao = Convert.ToDateTime(dataReader["data_criacao"]);

                var tabelaPreco = TabelaPreco.CreateFromDataBase(id, dataCriacao, descricao, valor);

                lista.Add(tabelaPreco);
            }

            return lista;
        }
        public TabelaPreco? RecuperarPorId(Guid idPreco)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM tabela_preco WHERE id = @id";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", idPreco);
                    using (var dataReader = cmd.ExecuteReader())
                    {
                        var lista = PopularLista(dataReader);
                        return lista.FirstOrDefault();
                    }
                }
            }
        }
    }
}