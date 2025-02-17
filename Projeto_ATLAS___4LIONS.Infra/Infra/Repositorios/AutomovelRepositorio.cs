using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using Projeto_ATLAS___4LIONS.Infra.Servicos;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class AutomovelRepositorio : IAutomovelRepositorio
    {
        public void Adicionar(AutomovelDTO automovelDto)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                string sql = @"
                        INSERT INTO automovel (Modelo, Placa, Cor, Status, Chassi, Renavam, OleoKm, DataCriacao, PastilhaFreioKm, IdPreco)
                        VALUES (@Modelo, @Placa, @Cor, @Status, @Chassi, @Renavam, @OleoKm, @DataCriacao, @PastilhaFreioKm, @IdPreco)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Modelo", automovelDto.Modelo);
                    cmd.Parameters.AddWithValue("@Placa", automovelDto.Placa);
                    cmd.Parameters.AddWithValue("@Cor", automovelDto.Cor);
                    cmd.Parameters.AddWithValue("@Status", (int)automovelDto.Status);
                    cmd.Parameters.AddWithValue("@Chassi", automovelDto.Chassi);
                    cmd.Parameters.AddWithValue("@Renavam", automovelDto.Renavam);
                    cmd.Parameters.AddWithValue("@OleoKm", automovelDto.Oleokm);
                    cmd.Parameters.AddWithValue("@DataCriacao", automovelDto.DataCriacao);
                    cmd.Parameters.AddWithValue("@PastilhaFreioKm", automovelDto.PastilhaFreioKm);
                    cmd.Parameters.AddWithValue("@IdPreco", automovelDto.IdPreco);

                    cmd.ExecuteNonQuery();
                    automovelDto.Id = (int)cmd.LastInsertedId;
                }
            }
        }

        public void Deletar(AutomovelDTO automovelDto)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                string sql = "DELETE FROM automovel WHERE Id = @id";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", automovelDto.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<AutomovelDTO> ListarTodos()
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
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
                    Id = Convert.ToInt32(dataReader["Id"]),
                    Modelo = dataReader["Modelo"].ToString(),
                    Placa = dataReader["Placa"].ToString(),
                    Cor = dataReader["Cor"].ToString(),
                    Status = Enum.Parse<EStatusVeiculo>(dataReader["Status"].ToString()),
                    Chassi = !Convert.IsDBNull(dataReader["Chassi"]) ? dataReader["Chassi"].ToString() : null,
                    Renavam = !Convert.IsDBNull(dataReader["Renavam"]) ? dataReader["Renavam"].ToString() : null,
                    Oleokm = !Convert.IsDBNull(dataReader["OleoKm"]) ? (int?)Convert.ToInt32(dataReader["OleoKm"]) : null,
                    PastilhaFreioKm = !Convert.IsDBNull(dataReader["PastilhaFreioKm"]) ? (int?)Convert.ToInt32(dataReader["PastilhaFreioKm"]) : null,
                    DataCriacao = Convert.ToDateTime(dataReader["DataCriacao"]),
                    IdPreco = dataReader["IdPreco"] != DBNull.Value ? Convert.ToInt32(dataReader["IdPreco"]) : (int?)null
                };

                lista.Add(automovel);
            }

            return lista;
        }


        public void AtualizarStatus(int automovelId, EStatusVeiculo novoStatus)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                string sql = "UPDATE automovel SET Status = @Status WHERE Id = @Id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Status", (int)novoStatus);
                    cmd.Parameters.AddWithValue("@Id", automovelId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public AutomovelDTO? RecuperarPorId(int id)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM automovel WHERE Id = @id";

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
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM automovel WHERE Status = 1";

                using (var cmd = new MySqlCommand(sql, conexao))
                using (var dataReader = cmd.ExecuteReader())
                {
                    return PopularLista(dataReader);
                }
            }
        }
    }
}
