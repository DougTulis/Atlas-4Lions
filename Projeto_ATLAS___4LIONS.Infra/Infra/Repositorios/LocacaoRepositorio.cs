using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using Projeto_ATLAS___4LIONS.Infra.Servicos;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class LocacaoRepositorio : ILocacaoRepositorio
    {
        public int Adicionar(LocacaoDTO locacaoDto,Pessoa condutor, Pessoa locatario,Automovel automovel)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                var locacao = new Locacao
                {
                    Saida = locacaoDto.Saida,
                    Retorno = locacaoDto.Retorno,
                    TipoLocacao = locacaoDto.TipoLocacao,
                    ValorTotal = locacaoDto.ValorTotal,
                    Locatario = locatario,
                    Condutor = condutor,
                    Automovel = automovel,
                    Status = locacaoDto.Status
                };

                string sql = @"
    INSERT INTO Locacao (Saida, Retorno, TipoLocacao, ValorTotal, LocatarioId, CondutorId, AutomovelId, StatusLocacao)
    VALUES (@Saida, @Retorno, @TipoLocacao, @ValorTotal, @LocatarioId, @CondutorId, @AutomovelId, @statusLocacao);
    SELECT LAST_INSERT_ID();"; // Retorna o ID gerado

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Saida", locacao.Saida);
                    cmd.Parameters.AddWithValue("@Retorno", locacao.Retorno);
                    cmd.Parameters.AddWithValue("@TipoLocacao", (int)locacao.TipoLocacao);
                    cmd.Parameters.AddWithValue("@ValorTotal", locacao.ValorTotal);
                    cmd.Parameters.AddWithValue("@LocatarioId", locacao.Locatario.Id);
                    cmd.Parameters.AddWithValue("@CondutorId", locacao.Condutor.Id);
                    cmd.Parameters.AddWithValue("@AutomovelId", locacao.Automovel.Id);
                    cmd.Parameters.AddWithValue("@statusLocacao", (int)locacao.Status);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public void Deletar(LocacaoDTO locacaoDto)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {

                conexao.Open();

                var locacao = new Locacao
                {
                    Id = locacaoDto.Id
                };

                string sql = "DELETE FROM Locacao WHERE Id = @Id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {

                    cmd.Parameters.AddWithValue("@Id", locacao.Id);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public IEnumerable<LocacaoDTO> ListarTodos()
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                string sql = "SELECT * FROM Locacao";
                using (var cmd = new MySqlCommand(sql, conexao))
                {

                    using (var dataReader = cmd.ExecuteReader())
                    {
                        return PopularLista(dataReader);
                    }

                }
            }
        }

        public IEnumerable<LocacaoDTO> PopularLista(MySqlDataReader dataReader)
        {
            var lista = new List<LocacaoDTO>();

            while (dataReader.Read())
            {
                var locacao = new LocacaoDTO
                {
                    Id = Convert.ToInt32(dataReader["Id"]),
                    Saida = Convert.ToDateTime(dataReader["Saida"]),
                    Retorno = Convert.ToDateTime(dataReader["Retorno"]),
                    TipoLocacao = (ETipoLocacao)Convert.ToInt32(dataReader["TipoLocacao"]),
                    ValorTotal = Convert.ToDecimal(dataReader["ValorTotal"]),
                    IdLocatario = Convert.ToInt32(dataReader["LocatarioId"]),
                    IdCondutor = Convert.ToInt32(dataReader["CondutorId"]),
                    IdAutomovel = Convert.ToInt32(dataReader["AutomovelId"]),
                    Status = (EStatusLocacao)Convert.ToInt32(dataReader["StatusLocacao"])
                };

                lista.Add(locacao);
            }

            return lista;
        }

        public LocacaoDTO? RecuperarPorId(int id)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {

                conexao.Open();

                string sql = "SELECT * FROM Locacao WHERE Id = @Id";
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

        public IEnumerable<LocacaoDTO> ListarPorStatusAndamento()
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {

                conexao.Open();

                string sql = "SELECT * FROM Locacao WHERE statusLocacao = @statusLocacao";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@statusLocacao", (int)EStatusLocacao.ANDAMENTO);
                    using (var dataReader = cmd.ExecuteReader())
                    {
                        var lista = PopularLista(dataReader);
                        return lista;
                    }
                }
            }
        }
        public void AtualizarStatus(int locacaoId, EStatusLocacao novoStatus)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                string sql = "UPDATE locacao SET statusLocacao = @statusLocacao WHERE Id = @Id";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@statusLocacao", (int)novoStatus);
                    cmd.Parameters.AddWithValue("@Id", locacaoId);
                    cmd.ExecuteNonQuery();

                }

            }
        }

    }
}
