using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Infra.Servicos;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class TabelaPrecoRepositorio : ITabelaPrecoRepositorio
    {
        public void Adicionar(TabelaPrecoDTO tabelaPrecoDto)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                var tabelaPreco = new TabelaPreco
                {
                    Id = tabelaPrecoDto.Id,
                    Valor = tabelaPrecoDto.Valor,
                    Descricao = tabelaPrecoDto.Descricao,
                    AutomovelId = tabelaPrecoDto.AutomovelId,
                    DataCriacao = DateTime.Now
                };

                string sql = @"
                INSERT INTO tabela_preco (Descricao, Valor, AutomovelId)
                VALUES (@Descricao, @Valor, @AutomovelId)";

                using var cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Descricao", tabelaPrecoDto.Descricao);
                cmd.Parameters.AddWithValue("@Valor", tabelaPrecoDto.Valor);
                cmd.Parameters.AddWithValue("@AutomovelId", tabelaPrecoDto.AutomovelId);

                cmd.ExecuteNonQuery();
                tabelaPrecoDto.Id = (int)cmd.LastInsertedId;
            }
        }

        public void Deletar(TabelaPrecoDTO tabelaPrecoDto)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                var tabelaPreco = new TabelaPreco
                {
                    Id = tabelaPrecoDto.Id,
                    Valor = tabelaPrecoDto.Valor,
                    Descricao = tabelaPrecoDto.Descricao,
                    AutomovelId = tabelaPrecoDto.AutomovelId,
                    DataCriacao = DateTime.Now
                };

                conexao.Open();

                string sql = "DELETE FROM tabela_preco WHERE Id = @Id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {


                    cmd.Parameters.AddWithValue("@Id", tabelaPrecoDto.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<TabelaPrecoDTO> ListarTodos()
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
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
                    Id = Convert.ToInt32(dataReader["Id"]),
                    Descricao = Convert.ToString(dataReader["Descricao"]),
                    Valor = Convert.ToDecimal(dataReader["Valor"]),
                    AutomovelId = Convert.ToInt32(dataReader["AutomovelId"])
                };

                lista.Add(tabelaPreco);
            }

            return lista;
        }

        public TabelaPrecoDTO? RecuperarPorId(int idAutomovel)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                string sql = "SELECT * FROM tabela_preco WHERE AutomovelId = @AutomovelId";
                using var cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@AutomovelId", idAutomovel);

                using (var dataReader = cmd.ExecuteReader())
                {
                    var lista = PopularLista(dataReader);

                    return lista.FirstOrDefault();
                }
            }
        }
    }

}