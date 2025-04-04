﻿using MySql.Data.MySqlClient;
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
                        INSERT INTO automovel 
                (id, modelo, ano, placa, cor, status, chassi, renavam, oleo_km, data_criacao, pastilha_freio_Km, id_preco)
                VALUES (@id, @modelo, @ano, @placa, @cor, @status, @chassi, @renavam, @oleo_km, @data_criacao, @pastilha_freio_Km, @id_preco)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", automovel.Id);
                    cmd.Parameters.AddWithValue("@modelo", automovel.Modelo);
                    cmd.Parameters.AddWithValue("@placa", automovel.Placa);
                    cmd.Parameters.AddWithValue("@ano", automovel.Ano);
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

        public bool PlacaExiste(string placa)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = "SELECT count(*) FROM automovel WHERE placa = @placa";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@placa", placa);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }

        public void Deletar(Guid id)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = "DELETE FROM automovel WHERE id = @id";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public IEnumerable<Automovel> ListarTodos()
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
        public IEnumerable<Automovel> PopularLista(MySqlDataReader dataReader)
        {
            var lista = new List<Automovel>();

            while (dataReader.Read())
            {
                var id = Guid.Parse(dataReader["id"].ToString());
                var modelo = dataReader["modelo"].ToString();
                var placa = dataReader["placa"].ToString();
                var ano = dataReader["ano"].ToString();
                var cor = dataReader["cor"].ToString();
                var status = Enum.Parse<EStatusVeiculo>(dataReader["status"].ToString());
                var chassi = !Convert.IsDBNull(dataReader["chassi"]) ? dataReader["chassi"].ToString() : null;
                var renavam = !Convert.IsDBNull(dataReader["renavam"]) ? dataReader["renavam"].ToString() : null;
                var oleokm = !Convert.IsDBNull(dataReader["oleo_km"]) ? (int?)Convert.ToInt32(dataReader["oleo_km"]) : null;
                var pastilhaFreioKm = !Convert.IsDBNull(dataReader["pastilha_freio_km"]) ? (int?)Convert.ToInt32(dataReader["pastilha_freio_km"]) : null;
                var dataCriacao = Convert.ToDateTime(dataReader["data_criacao"]);
                var idPreco = Guid.Parse((dataReader["id_preco"].ToString()));

                var automovel = Automovel.CreateFromDataBase(id, dataCriacao, modelo, placa, cor, status, ano, chassi, renavam, oleokm, pastilhaFreioKm, idPreco);
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
        public Automovel? RecuperarPorId(Guid id)
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
        public IEnumerable<Automovel> ListarStatusGaragem()
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
