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


                var automovel = new Automovel
                {
                    Id = automovelDto.Id,
                    Modelo = automovelDto.Modelo,
                    Placa = automovelDto.Placa,
                    Cor = automovelDto.Cor,
                    Status = automovelDto.Status,
                    Chassi = automovelDto.Chassi,
                    Renavam = automovelDto.Renavam,
                    Oleokm = automovelDto.Oleokm,
                    DataCriacao = automovelDto.DataCriacao,
                    PastilhaFreioKm = automovelDto.PastilhaFreioKm

                };

                string sql = @"
                        INSERT INTO automovel (Modelo, Placa, Cor, Status, Chassi,Renavam,OleoKm,DataCriacao, PastilhaFreioKm)
                        VALUES (@Modelo, @Placa, @Cor, @Status, @Chassi, @Renavam,@OleoKm, @DataCriacao, @PastilhaFreioKm)"
                ;
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Modelo", automovel.Modelo);
                    cmd.Parameters.AddWithValue("@Placa", automovel.Placa);
                    cmd.Parameters.AddWithValue("@Cor", automovel.Cor);
                    cmd.Parameters.AddWithValue("@Status", automovel.Status);
                    cmd.Parameters.AddWithValue("@Chassi", automovel.Chassi);
                    cmd.Parameters.AddWithValue("@Renavam", automovel.Renavam);
                    cmd.Parameters.AddWithValue("@OleoKm", automovel.Oleokm);
                    cmd.Parameters.AddWithValue("@DataCriacao", automovel.DataCriacao);
                    cmd.Parameters.AddWithValue("@PastilhaFreioKm", automovel.PastilhaFreioKm);
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

                var automovel = new Automovel
                {
                    Id = automovelDto.Id,
                    Modelo = automovelDto.Modelo,
                    Placa = automovelDto.Placa,
                    Cor = automovelDto.Cor,
                    Status = automovelDto.Status,
                    Chassi = automovelDto.Chassi,
                    Renavam = automovelDto.Renavam,
                    Oleokm = automovelDto.Oleokm,
                    DataCriacao = automovelDto.DataCriacao,
                    PastilhaFreioKm = automovelDto.PastilhaFreioKm
                };

                string sql = $"DELETE FROM automovel WHERE Id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", automovel.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<AutomovelDTO> ListarTodos()
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                var lista = new List<AutomovelDTO>();
                string sql = "SELECT * FROM automovel";
                using (var cmd = new MySqlCommand(sql, conexao))
                {

                    using (var dataReader = cmd.ExecuteReader())
                    {

                        return PopularLista(dataReader);
                    }
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
                    Status = (EStatusVeiculo)Convert.ToInt32(dataReader["Status"]),
                    Chassi = dataReader["Chassi"] != DBNull.Value ? dataReader["Chassi"].ToString() : null,
                    Renavam = dataReader["Renavam"] != DBNull.Value ? dataReader["Renavam"].ToString() : null,
                    Oleokm = dataReader["OleoKm"] != DBNull.Value ? (int?)Convert.ToInt32(dataReader["OleoKm"]) : null,
                    PastilhaFreioKm = dataReader["PastilhaFreioKm"] != DBNull.Value ? (int?)Convert.ToInt32(dataReader["PastilhaFreioKm"]) : null,
                    DataCriacao = Convert.ToDateTime(dataReader["DataCriacao"])
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

                string sql = $"SELECT * FROM automovel WHERE Id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    var lista = PopularLista(dataReader);

                    return lista.FirstOrDefault();
                }
            }
        }


        public IEnumerable<AutomovelDTO> ListarStatusGaragem()
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                var lista = new List<AutomovelDTO>();
                string sql = "SELECT * FROM automovel WHERE Status = 1";
                using (var cmd = new MySqlCommand(sql, conexao))
                {

                    using (var dataReader = cmd.ExecuteReader())
                    {

                        while (dataReader.Read())
                        {
                            var automovel = new AutomovelDTO
                            {
                                Id = Convert.ToInt32(dataReader["Id"]),
                                Modelo = dataReader["Modelo"].ToString(),
                                Placa = dataReader["Placa"].ToString(),
                                Cor = dataReader["Cor"].ToString(),
                                Status = (EStatusVeiculo)Convert.ToInt32(dataReader["Status"]),
                                Chassi = dataReader["Chassi"] != DBNull.Value ? dataReader["Chassi"].ToString() : null,
                                Renavam = dataReader["Renavam"] != DBNull.Value ? dataReader["Renavam"].ToString() : null,
                                Oleokm = dataReader["OleoKm"] != DBNull.Value ? (int?)Convert.ToInt32(dataReader["OleoKm"]) : null,
                                PastilhaFreioKm = dataReader["PastilhaFreioKm"] != DBNull.Value ? (int?)Convert.ToInt32(dataReader["PastilhaFreioKm"]) : null,
                                DataCriacao = Convert.ToDateTime(dataReader["DataCriacao"])
                            };
                            lista.Add(automovel);
                        }

                        return lista;

                    }
                }
            }
        }
    }
}



