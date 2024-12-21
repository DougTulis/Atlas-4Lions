using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using Projeto_ATLAS___4LIONS.Infra.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class AutomovelRepositorio : ICrud<AutomovelDTO>
    {
        public void Adicionar(AutomovelDTO automovelDTO)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();
            string sql = @"
                        INSERT INTO automovel (Modelo, Placa, Cor, Status, ValorDiaria, Chassi,Renavam,OleoKm,DataCriacao, PastilhaFreioKm)
                        VALUES (@Modelo, @Placa, @Cor, @Status, @ValorDiaria, @Chassi, @Renavam,@OleoKm, @DataCriacao, @PastilhaFreioKm)"
            ;

            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@Modelo", automovelDTO.Modelo);
                cmd.Parameters.AddWithValue("@Placa", automovelDTO.Placa);
                cmd.Parameters.AddWithValue("@Cor", automovelDTO.Cor);
                cmd.Parameters.AddWithValue("@Status", automovelDTO.Status);
                cmd.Parameters.AddWithValue("@ValorDiaria", automovelDTO.ValorDiaria);
                cmd.Parameters.AddWithValue("@Chassi", automovelDTO.Chassi);
                cmd.Parameters.AddWithValue("@Renavam", automovelDTO.Renavam);
                cmd.Parameters.AddWithValue("@OleoKm", automovelDTO.Oleokm);
                cmd.Parameters.AddWithValue("@DataCriacao", automovelDTO.DataCriacao);
                cmd.Parameters.AddWithValue("@PastilhaFreioKm", automovelDTO.PastilhaFreioKm);
                cmd.ExecuteNonQuery();
            }
        }

        public void Atualizar(AutomovelDTO objeto)
        {
            throw new NotImplementedException();
        }

        public void Deletar(AutomovelDTO automovel)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();
            string sql = $"DELETE FROM automovel WHERE Id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", automovel.Id);
            cmd.ExecuteNonQuery();
        }

        public IEnumerable<AutomovelDTO> Listar()
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();
            var lista = new List<AutomovelDTO>();
            string sql = "SELECT * FROM automovel";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                int id = Convert.ToInt32(dataReader["Id"]);
                string modelo = Convert.ToString(dataReader["Modelo"]);
                string placa = Convert.ToString(dataReader["Placa"]);
                string cor = Convert.ToString(dataReader["Cor"]);
                EStatusVeiculo status = (EStatusVeiculo)Convert.ToInt32(dataReader["Status"]);
                decimal valorDiaria = Convert.ToDecimal(dataReader["ValorDiaria"]);
                string? chassi = dataReader["Chassi"] != DBNull.Value ? Convert.ToString(dataReader["Chassi"]) : null;
                string? renavam = dataReader["Renavam"] != DBNull.Value ? Convert.ToString(dataReader["Renavam"]) : null;
                int? oleokm = dataReader["Oleokm"] != DBNull.Value ? (int?)Convert.ToInt32(dataReader["Oleokm"]) : null;
                int? pastilhaFreioKm = dataReader["PastilhaFreioKm"] != DBNull.Value ? (int?)Convert.ToInt32(dataReader["PastilhaFreioKm"]) : null;
                DateTime dataCriacao = Convert.ToDateTime(dataReader["DataCriacao"]);

                var automovel = new AutomovelDTO(modelo, placa, cor, status, valorDiaria, chassi, renavam, oleokm, pastilhaFreioKm)
                {
                    Id = id,
                    DataCriacao = dataCriacao
                };

                lista.Add(automovel);
            }
            return lista;
        }
        public AutomovelDTO? RecuperarPor(Func<AutomovelDTO, bool> resultado)
        {
            var automovelDTOLista = Listar();
            return automovelDTOLista.FirstOrDefault(resultado);
        }
    }
}
