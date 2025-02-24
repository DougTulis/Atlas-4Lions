using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
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
                INSERT INTO tabela_preco (id,descricao, valor)
                VALUES (@id, @descricao, @valor)";

                using var cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", tabelaPreco.Id);
                cmd.Parameters.AddWithValue("@descricao", tabelaPreco.Descricao);
                cmd.Parameters.AddWithValue("@valor", tabelaPreco.Valor);
                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar(TabelaPrecoDTO tabelaPrecoDto)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = "DELETE FROM tabela_preco WHERE id = @id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {


                    cmd.Parameters.AddWithValue("@id", tabelaPrecoDto.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<TabelaPrecoDTO> ListarTodos()
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
        public IEnumerable<TabelaPrecoDTO> PopularLista(MySqlDataReader dataReader)
        {
            var lista = new List<TabelaPrecoDTO>();
            while (dataReader.Read())
            {
                var tabelaPreco = new TabelaPrecoDTO
                {
                    Id = Guid.Parse(dataReader["Id"].ToString()),
                    Descricao = Convert.ToString(dataReader["Descricao"]),
                    Valor = Convert.ToDecimal(dataReader["Valor"]),
                };

                lista.Add(tabelaPreco);
            }

            return lista;
        }
        public TabelaPrecoDTO? RecuperarPorId(Guid idPreco)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM tabela_preco WHERE Id = @Id";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Id", idPreco);
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