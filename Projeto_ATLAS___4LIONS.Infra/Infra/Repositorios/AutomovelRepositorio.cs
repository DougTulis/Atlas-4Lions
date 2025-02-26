using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.Interface_Adapter;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using Projeto_ATLAS___4LIONS.Infra.Servicos;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class AutomovelRepositorio : IAutomovelRepositorio
    {
        private readonly IMySqlAdaptadorConexao _conexaoAdapter;

        public AutomovelRepositorio(IMySqlAdaptadorConexao conexaoAdapter)
        {
            _conexaoAdapter = conexaoAdapter;
        }

        public void Adicionar(Automovel automovel)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = @"
                        INSERT INTO automovel (id, modelo, placa, cor, status, chassi, renavam, oleo_km, data_criacao, pastilha_freio_Km, id_preco)
                        VALUES (@id, @modelo, @placa, @cor, @status, @chassi, @renavam, @oleo_km, @data_criacao, @pastilha_freio_Km, @id_preco)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", automovel.Id);
                    cmd.Parameters.AddWithValue("@modelo", automovel.Modelo);
                    cmd.Parameters.AddWithValue("@placa", automovel.Placa);
                    cmd.Parameters.AddWithValue("@cor", automovel.Cor);
                    cmd.Parameters.AddWithValue("@status", automovel.Status);
                    cmd.Parameters.AddWithValue("@chassi", automovel.Chassi);
                    cmd.Parameters.AddWithValue("@renavam", automovel.Renavam);
                    cmd.Parameters.AddWithValue("@oleo_km", automovel.Oleokm);
                    cmd.Parameters.AddWithValue("@data_criacao", automovel.DataCriacao);
                    cmd.Parameters.AddWithValue("@pastilha_freio_km", automovel.PastilhaFreioKm);
                    cmd.Parameters.AddWithValue("@id_preco", automovel.IdPreco);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(AutomovelDTO automovelDto)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = "DELETE FROM automovel WHERE id = @id";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", automovelDto.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<AutomovelDTO> ListarTodos()
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM automovel";

                using (var cmd = new MySqlCommand(sql, conexao))
                using (var dataReader = cmd.ExecuteReader())
                {
                    return PopularLista(dataReader);
                }
            }
        }
        public IEnumerable<AutomovelDTO> PopularLista(MySqlDataReader dataReader)
        {
            var lista = new List<AutomovelDTO>();

            while (dataReader.Read())
            {
                var automovel = new AutomovelDTO
                {
                    Id = Guid.Parse(dataReader["id"].ToString()),
                    Modelo = dataReader["modelo"].ToString(),
                    Placa = dataReader["placa"].ToString(),
                    Cor = dataReader["cor"].ToString(),
                    Status = Enum.Parse<EStatusVeiculo>(dataReader["status"].ToString()),
                    Chassi = !Convert.IsDBNull(dataReader["chassi"]) ? dataReader["chassi"].ToString() : null,
                    Renavam = !Convert.IsDBNull(dataReader["renavam"]) ? dataReader["renavam"].ToString() : null,
                    Oleokm = !Convert.IsDBNull(dataReader["oleo_km"]) ? (int?)Convert.ToInt32(dataReader["oleo_km"]) : null,
                    PastilhaFreioKm = !Convert.IsDBNull(dataReader["pastilha_freio_km"]) ? (int?)Convert.ToInt32(dataReader["pastilha_freio_km"]) : null,
                    DataCriacao = Convert.ToDateTime(dataReader["data_criacao"]),
                    IdPreco = Guid.Parse((dataReader["id_preco"].ToString()))
                };

                lista.Add(automovel);
            }

            return lista;
        }


        public void AtualizarStatus(Guid automovelId, EStatusVeiculo novoStatus)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();
                string sql = "UPDATE automovel SET status = @status WHERE id = @id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@status", novoStatus);
                    cmd.Parameters.AddWithValue("@id", automovelId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public AutomovelDTO? RecuperarPorId(Guid id)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM automovel WHERE id = @id";

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

        public IEnumerable<AutomovelDTO> ListarStatusGaragem()
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM automovel WHERE status = 'GARAGEM'";

                using (var cmd = new MySqlCommand(sql, conexao))
                using (var dataReader = cmd.ExecuteReader())
                {
                    return PopularLista(dataReader);
                }
            }
        }
    }
}
