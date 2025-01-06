using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
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
        public void Adicionar(AutomovelDTO automovelDto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
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

            if (!automovel.Validacao())
            {
                Thread.Sleep(2000);
                MenuInicial.Exibir();
            }

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

        public void Atualizar(AutomovelDTO objeto)
        {
            throw new NotImplementedException();
        }

        public void Deletar(AutomovelDTO automovelDto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
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
            if (!automovel.ValidarPraDeletar())
            {
                Thread.Sleep(2500);
                MenuInicial.Exibir();
            } 

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
                string? chassi = dataReader["Chassi"] != DBNull.Value ? Convert.ToString(dataReader["Chassi"]) : null;
                string? renavam = dataReader["Renavam"] != DBNull.Value ? Convert.ToString(dataReader["Renavam"]) : null;
                int? oleokm = dataReader["Oleokm"] != DBNull.Value ? (int?)Convert.ToInt32(dataReader["Oleokm"]) : null;
                int? pastilhaFreioKm = dataReader["PastilhaFreioKm"] != DBNull.Value ? (int?)Convert.ToInt32(dataReader["PastilhaFreioKm"]) : null;
                DateTime dataCriacao = Convert.ToDateTime(dataReader["DataCriacao"]);

                var automovel = new AutomovelDTO(modelo, placa, cor, status, chassi, renavam, oleokm, pastilhaFreioKm)
                {
                    Id = id,
                    DataCriacao = dataCriacao
                };

                lista.Add(automovel);
            }
            return lista;
        }

        public void AtualizarStatus(int automovelId, EStatusVeiculo novoStatus)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();
            string sql = "UPDATE automovel SET Status = @Status WHERE Id = @Id";
            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Status", (int)novoStatus);
            cmd.Parameters.AddWithValue("@Id", automovelId);
            cmd.ExecuteNonQuery();
        }

        public AutomovelDTO? RecuperarPor(Func<AutomovelDTO, bool> resultado)
        {
            var automovelDTOLista = Listar();
            return automovelDTOLista.FirstOrDefault(resultado);
        }
    }
}
