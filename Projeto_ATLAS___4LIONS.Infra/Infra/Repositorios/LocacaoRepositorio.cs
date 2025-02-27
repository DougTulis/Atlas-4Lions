using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.Interface_Adapter;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using Projeto_ATLAS___4LIONS.Infra.Servicos;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class LocacaoRepositorio : ILocacaoRepositorio
    {
        private readonly IMySqlAdaptadorConexao _conexaoAdapter;

        public LocacaoRepositorio(IMySqlAdaptadorConexao conexaoAdapter)
        {
            _conexaoAdapter = conexaoAdapter;
        }

        public void Adicionar(Locacao locacao)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = @"
                INSERT INTO locacao 
                (saida, retorno, tipolocacao, valor_total, locatario_id, condutor_id, automovel_id, status_locacao,pendencia_financeira_id,id)
                VALUES 
                (@saida, @retorno, @tipolocacao, @valor_total, @locatario_id, @condutor_id, @automovel_id, @status_locacao,@pendencia_financeira_id,@id)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", locacao.Id);
                    cmd.Parameters.AddWithValue("@saida", locacao.Saida);
                    cmd.Parameters.AddWithValue("@retorno", locacao.Retorno);
                    cmd.Parameters.AddWithValue("@tipo_locacao", locacao.TipoLocacao);
                    cmd.Parameters.AddWithValue("@valor_total", locacao.ValorTotal);
                    cmd.Parameters.AddWithValue("@locatario_id", locacao.IdLocatario);
                    cmd.Parameters.AddWithValue("@condutor_id", locacao.IdAutomovel);
                    cmd.Parameters.AddWithValue("@automovel_id", locacao.IdAutomovel);
                    cmd.Parameters.AddWithValue("@pendencia_financeira_id", locacao.IdPendenciaFinanceira);
                    cmd.Parameters.AddWithValue("@status_locacao", locacao.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Locacao locacao)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();


                string sql = @"
        UPDATE Locacao 
        SET saida = @saida, retorno = @retorno, tipo_locacao = @tipo_locacao, valor_total = @valor_total, locatario_id = @locatario_id, condutor_id = @condutor_id, automovel_id = @automovel_id, status_locacao = @status_locacao WHERE id = @id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Id", locacao.Id);
                    cmd.Parameters.AddWithValue("@saida", locacao.Saida);
                    cmd.Parameters.AddWithValue("@retorno", locacao.Retorno);
                    cmd.Parameters.AddWithValue("@tipo_locacao", locacao.TipoLocacao);
                    cmd.Parameters.AddWithValue("@valor_total", locacao.ValorTotal);
                    cmd.Parameters.AddWithValue("@locatario_id", locacao.IdLocatario);
                    cmd.Parameters.AddWithValue("@condutor_id", locacao.IdCondutor);
                    cmd.Parameters.AddWithValue("@automovel_id", locacao.IdAutomovel);
                    cmd.Parameters.AddWithValue("@status_locacao", locacao.Status);
                    cmd.Parameters.AddWithValue("@pendencia_financeira_id", locacao.IdPendenciaFinanceira);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Deletar(Guid id)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                string sql = "DELETE FROM Locacao WHERE id = @id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<LocacaoDTO> ListarTodas()
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM locacao";

                using (var cmd = new MySqlCommand(sql, conexao))
                using (var dataReader = cmd.ExecuteReader())
                {
                    return PopularListaDTO(dataReader);
                }
            }
        }
        public LocacaoDTO? RecuperarPorId(Guid id)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM locacao WHERE id = @id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var dataReader = cmd.ExecuteReader())
                    {
                        var lista = PopularListaDTO(dataReader);
                        return lista.FirstOrDefault();
                    }
                }
            }
        }
        private IEnumerable<LocacaoDTO> PopularListaDTO(MySqlDataReader dataReader)
        {
            var lista = new List<LocacaoDTO>();

            while (dataReader.Read())
            {
                var locacaoDto = new LocacaoDTO
                {
                    Id = Guid.Parse(dataReader["id"].ToString()),
                    Saida = Convert.ToDateTime(dataReader["saida"]),
                    Retorno = Convert.ToDateTime(dataReader["retorno"]),
                    TipoLocacao = (ETipoLocacao)Convert.ToInt32(dataReader["tipo_locacao"]),
                    IdLocatario = Guid.Parse(dataReader["locatario_id"].ToString()),
                    IdCondutor = Guid.Parse(dataReader["condutor_id"].ToString()),
                    IdAutomovel = Guid.Parse(dataReader["automovel_id"].ToString()),
                    Status = (EStatusLocacao)Convert.ToInt32(dataReader["statusLocacao"]),

                    //    Chassi = !Convert.IsDBNull(dataReader["chassi"]) ? dataReader["chassi"].ToString() : null,
                };
                lista.Add(locacaoDto);
            }

            return lista;
        }

        public void AtualizarStatusLocacao(int locacaoId, EStatusLocacao novoStatus)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();
                string sql = "UPDATE locacao SET status_locacao = @status WHERE id = @id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@status",novoStatus);
                    cmd.Parameters.AddWithValue("@id", locacaoId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<LocacaoDTO> ListarStatusAndamento()
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM locacao WHERE status_locacao = @status_locacao";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@status_locacao", (int)EStatusLocacao.ANDAMENTO);

                    using (var dataReader = cmd.ExecuteReader())
                    {
                        return PopularListaDTO(dataReader);
                    }
                }
            }
        }
    }
}
