using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Infra.Servicos;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class PendenciaFinanceiraRepositorio : IPendenciaFinanceiraRepositorio
    {
        public void Adicionar(PendenciaFinanceiraDTO pendenciaDto)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                string sql = @"
                INSERT INTO PendenciaFinanceira (TransacaoId, ValorTotal, DataCriacao, LocacaoId)
                VALUES (@TransacaoId, @ValorTotal, @DataCriacao, @LocacaoId)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@TransacaoId", pendenciaDto.TransacaoId);
                    cmd.Parameters.AddWithValue("@ValorTotal", pendenciaDto.ValorTotal);
                    cmd.Parameters.AddWithValue("@DataCriacao", pendenciaDto.DataCriacao);
                    cmd.Parameters.AddWithValue("@LocacaoId", pendenciaDto.IdLocacao);

                    cmd.ExecuteNonQuery();
                    pendenciaDto.Id = (int)cmd.LastInsertedId;
                }
            }
        }

        public void Deletar(PendenciaFinanceiraDTO pendenciaDto)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                string sql = "DELETE FROM PendenciaFinanceira WHERE Id = @Id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Id", pendenciaDto.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<PendenciaFinanceiraDTO> ListarTodos()
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM PendenciaFinanceira";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    using (var dataReader = cmd.ExecuteReader())
                    {
                        return PopularLista(dataReader);
                    }
                }
            }
        }

        public IEnumerable<PendenciaFinanceiraDTO> PopularLista(MySqlDataReader dataReader)
        {
            var lista = new List<PendenciaFinanceiraDTO>();

            while (dataReader.Read())
            {
                var pendencia = new PendenciaFinanceiraDTO
                {
                    Id = Convert.ToInt32(dataReader["Id"]),
                    TransacaoId = Guid.Parse(dataReader["TransacaoId"].ToString()),
                    ValorTotal = Convert.ToDecimal(dataReader["ValorTotal"]),
                    DataCriacao = Convert.ToDateTime(dataReader["DataCriacao"]),
                    IdLocacao = dataReader["LocacaoId"] != DBNull.Value ? Convert.ToInt32(dataReader["LocacaoId"]) : Convert.ToInt16(null)
                };

                lista.Add(pendencia);
            }

            return lista;
        }
        public PendenciaFinanceiraDTO? RecuperarPorId(int id)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM PendenciaFinanceira WHERE Id = @Id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

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
