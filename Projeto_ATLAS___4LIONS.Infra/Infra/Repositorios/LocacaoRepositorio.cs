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
                (saida, retorno, tipo_locacao, valor_total, locatario_id, condutor_id, automovel_id, status_locacao,pendencia_financeira_id,id)
                VALUES 
                (@saida, @retorno, @tipo_locacao, @valor_total, @locatario_id, @condutor_id, @automovel_id, @status_locacao,@pendencia_financeira_id,@id)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", locacao.Id);
                    cmd.Parameters.AddWithValue("@saida", locacao.Saida);
                    cmd.Parameters.AddWithValue("@retorno", locacao.Retorno);
                    cmd.Parameters.AddWithValue("@tipo_locacao", locacao.TipoLocacao);
                    cmd.Parameters.AddWithValue("@valor_total", locacao.ValorTotal);
                    cmd.Parameters.AddWithValue("@locatario_id", locacao.IdLocatario);
                    cmd.Parameters.AddWithValue("@condutor_id", locacao.IdCondutor);
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
                    cmd.Parameters.AddWithValue("@id", locacao.Id);
                    cmd.Parameters.AddWithValue("@saida", locacao.Saida);
                    cmd.Parameters.AddWithValue("@retorno", locacao.Retorno);
                    cmd.Parameters.AddWithValue("@tipo_locacao", locacao.TipoLocacao);
                    cmd.Parameters.AddWithValue("@valor_total", locacao.ValorTotal);
                    cmd.Parameters.AddWithValue("@locatario_id", locacao.IdLocatario);
                    cmd.Parameters.AddWithValue("@condutor_id", locacao.IdCondutor);
                    cmd.Parameters.AddWithValue("@automovel_id", locacao.IdAutomovel);
                    cmd.Parameters.AddWithValue("@pendencia_financeira_id", locacao.IdPendenciaFinanceira);
                    cmd.Parameters.AddWithValue("@status_locacao", locacao.Status);
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

        public IEnumerable<Locacao> ListarTodas()
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM locacao";

                using (var cmd = new MySqlCommand(sql, conexao))
                using (var dataReader = cmd.ExecuteReader())
                {
                    return PopularLista(dataReader);
                }
            }
        }
        public Locacao? RecuperarPorId(Guid id)
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
                        var lista = PopularLista(dataReader);
                        return lista.FirstOrDefault();
                    }
                }
            }
        }
        public IEnumerable<Locacao> PopularLista(MySqlDataReader dataReader)
        {
            var lista = new List<Locacao>();

            while (dataReader.Read())
            {

                var id = Guid.Parse(dataReader["id"].ToString());
                var dataCriacao = Convert.ToDateTime(dataReader["data_criacao"]);
                var saida = Convert.ToDateTime(dataReader["saida"]);
                var retorno = Convert.ToDateTime(dataReader["retorno"]);
                var tipoLocacao = Enum.Parse<ETipoLocacao>(dataReader["tipo_locacao"].ToString().ToUpper());
                var idLocatario = Guid.Parse(dataReader["locatario_id"].ToString());
                var idCondutor = Guid.Parse(dataReader["condutor_id"].ToString());
                var valorTotal = decimal.Parse(dataReader["valor_total"].ToString());
                var idAutomovel = Guid.Parse(dataReader["automovel_id"].ToString());
                var status = Enum.Parse<EStatusLocacao>(dataReader["status_locacao"].ToString());
                var pendenciaFinanceiraId = Guid.Parse(dataReader["pendencia_financeira_id"].ToString());
                var locacao = Locacao.CreateFromDataBase(id, dataCriacao, saida, retorno, tipoLocacao, valorTotal, idLocatario, idCondutor, idAutomovel, status, pendenciaFinanceiraId);
            
            lista.Add(locacao);
        }

            return lista;
        }

    public void AtualizarStatusLocacao(Guid locacaoId, EStatusLocacao novoStatus)
    {
        using (var conexao = _conexaoAdapter.ObterConexao())
        {
            conexao.Open();
            string sql = "UPDATE locacao SET status_locacao = @status WHERE id = @id";

            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@status", novoStatus);
                cmd.Parameters.AddWithValue("@id", locacaoId);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public IEnumerable<Locacao> ListarStatusAndamento()
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
                    return PopularLista(dataReader);
                }
            }
        }
    }
}
}
