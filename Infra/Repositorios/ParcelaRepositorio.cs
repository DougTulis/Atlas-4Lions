using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using Projeto_ATLAS___4LIONS.Infra.Servicos;
using System;
using System.Collections.Generic;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class ParcelaRepositorio : ICrud<ParcelaDTO>
    {
        public void Adicionar(ParcelaDTO parcelaDto)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                var parcela = new Parcela
                {
                    PendenciaFinanceiraId = parcelaDto.PendenciaFinanceiraId,
                    Sequencia = parcelaDto.Sequencia,
                    Valor = parcelaDto.Valor,
                    DataVencimento = parcelaDto.DataVencimento,
                    DataPagamento = parcelaDto.DataPagamento,
                    ValorPago = parcelaDto.ValorPago,
                    EspeciePagamento = parcelaDto.EspeciePagamento
                };

                string sql = @"
                    INSERT INTO Parcela (PendenciaFinanceiraId, Sequencia, DataVencimento, Valor, DataPagamento, ValorPago, EspeciePagamento)
                    VALUES (@PendenciaFinanceiraId, @Sequencia, @DataVencimento, @Valor, @DataPagamento, @ValorPago, @EspeciePagamento)";

                using var cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@PendenciaFinanceiraId", parcela.PendenciaFinanceiraId);
                cmd.Parameters.AddWithValue("@Sequencia", parcela.Sequencia);
                cmd.Parameters.AddWithValue("@DataVencimento", parcela.DataVencimento);
                cmd.Parameters.AddWithValue("@Valor", parcela.Valor);
                cmd.Parameters.AddWithValue("@DataPagamento", parcela.DataPagamento ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ValorPago", parcela.ValorPago ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@EspeciePagamento", parcela.EspeciePagamento?.ToString() ?? (object)DBNull.Value);

                cmd.ExecuteNonQuery();
                parcelaDto.Id = (int)cmd.LastInsertedId;
            }
        }

        public void Deletar(ParcelaDTO parcelaDto)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                var parcela = new Parcela
                {
                    PendenciaFinanceiraId = parcelaDto.PendenciaFinanceiraId,
                    Sequencia = parcelaDto.Sequencia,
                    Valor = parcelaDto.Valor,
                    DataVencimento = parcelaDto.DataVencimento,
                    DataPagamento = parcelaDto.DataPagamento,
                    ValorPago = parcelaDto.ValorPago,
                    EspeciePagamento = parcelaDto.EspeciePagamento
                };

                string sql = "DELETE FROM Parcela WHERE Id = @Id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Id", parcelaDto.Id);
                cmd.ExecuteNonQuery();
            }
        }

        }

        public IEnumerable<ParcelaDTO> ListarTodos()
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                string sql = "SELECT * FROM Parcela";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    using (var dataReader = cmd.ExecuteReader())
                    {

                        return PopularLista(dataReader);
                    }
                }
            }

        }
        public IEnumerable<ParcelaDTO> PopularLista(MySqlDataReader dataReader)
        {
            var lista = new List<ParcelaDTO>();

            while (dataReader.Read())
            {
                var parcela = new ParcelaDTO
                {
                    Id = Convert.ToInt32(dataReader["Id"]),
                    PendenciaFinanceiraId = Convert.ToInt32(dataReader["PendenciaFinanceiraId"]),
                    Sequencia = Convert.ToInt32(dataReader["Sequencia"]),
                    Valor = Convert.ToDecimal(dataReader["Valor"]),
                    DataVencimento = Convert.ToDateTime(dataReader["DataVencimento"]),
                    DataPagamento = dataReader["DataPagamento"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(dataReader["DataPagamento"]) : null,
                    ValorPago = dataReader["ValorPago"] != DBNull.Value ? (decimal?)Convert.ToDecimal(dataReader["ValorPago"]) : null,
                    EspeciePagamento = dataReader["EspeciePagamento"] != DBNull.Value
                        ? Enum.Parse<EEspecie>(dataReader["EspeciePagamento"].ToString())
                        : null
                };

                lista.Add(parcela);
            }

            return lista;
        }

        public ParcelaDTO? RecuperarPorId(int id)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                string sql = "SELECT * FROM Parcela WHERE Id = @Id";

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
        public IEnumerable<ParcelaDTO> ListarPorPendFin(int id)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                string sql = "SELECT * FROM parcela WHERE PendenciaFinanceiraId = @PendenciaFinanceiraId AND DataPagamento IS NULL and ValorPago IS NULL and EspeciePagamento is NULL";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@PendenciaFinanceiraId", id);

                using MySqlDataReader dataReader = cmd.ExecuteReader();
                var lista = PopularLista(dataReader);

                return lista;
            }
        }
        public void Atualizar(ParcelaDTO parcelaDto)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                var parcela = new Parcela
                {
                    Id = parcelaDto.Id,
                    PendenciaFinanceiraId = parcelaDto.PendenciaFinanceiraId,
                    Sequencia = parcelaDto.Sequencia,
                    Valor = parcelaDto.Valor,
                    DataVencimento = parcelaDto.DataVencimento,
                    DataPagamento = parcelaDto.DataPagamento,
                    ValorPago = parcelaDto.ValorPago,
                    EspeciePagamento = parcelaDto.EspeciePagamento
                };

                string sql = @"
            UPDATE parcela 
            SET 
                DataPagamento = @DataPagamento, 
                ValorPago = @ValorPago, 
                EspeciePagamento = @EspeciePagamento
            WHERE 
                Id = @Id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@DataPagamento", parcela.DataPagamento ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ValorPago", parcela.ValorPago ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@EspeciePagamento", parcela.EspeciePagamento?.ToString() ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Id", parcela.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
