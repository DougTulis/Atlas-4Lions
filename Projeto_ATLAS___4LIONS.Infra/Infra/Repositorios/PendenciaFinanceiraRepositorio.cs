using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.Interface_Adapter;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;


namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class PendenciaFinanceiraRepositorio : IPendenciaFinanceiraRepositorio
    {
        private readonly ILocacaoRepositorio _locacaoRepositorio;
        private readonly IMySqlAdaptadorConexao _conexaoAdapter;

        public PendenciaFinanceiraRepositorio(ILocacaoRepositorio locacaoRepositorio, IMySqlAdaptadorConexao conexaoAdapter)
        {
            _locacaoRepositorio = locacaoRepositorio;
            _conexaoAdapter = conexaoAdapter;
        }

        public void Adicionar(PendenciaFinanceira pendencia)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

         
                string sql = @"
                INSERT INTO pendencia_financeira (id, valor_total, data_criacao)
                VALUES (@id, @valor_total, @data_criacao)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", pendencia.Id);
                    cmd.Parameters.AddWithValue("@valor_total", pendencia.ValorTotal);
                    cmd.Parameters.AddWithValue("@data_criacao", pendencia.DataCriacao);
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public void Deletar(PendenciaFinanceiraDTO pendenciaDto)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();
                string sql = "DELETE FROM PendenciaFinanceira WHERE id = @id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", pendenciaDto.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<PendenciaFinanceiraDTO> ListarTodos()
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
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
                    ValorTotal = Convert.ToDecimal(dataReader["valor_total"]),
                    DataCriacao = Convert.ToDateTime(dataReader["data_Criacao"]),
                };

                lista.Add(pendencia);
            }
            return lista;
        }

        public PendenciaFinanceiraDTO? RecuperarPorId(Guid id)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM pendencia_financeira WHERE id = @id";

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
    }
}
