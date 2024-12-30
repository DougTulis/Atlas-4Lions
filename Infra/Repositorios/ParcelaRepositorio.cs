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
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            var parcela = new Parcela
            {
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
            cmd.Parameters.AddWithValue("@PendenciaFinanceiraId", parcelaDto.PendenciaFinanceiraId);
            cmd.Parameters.AddWithValue("@Sequencia", parcela.Sequencia);
            cmd.Parameters.AddWithValue("@DataVencimento", parcela.DataVencimento);
            cmd.Parameters.AddWithValue("@Valor", parcela.Valor);
            cmd.Parameters.AddWithValue("@DataPagamento", parcela.DataPagamento ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ValorPago", parcela.ValorPago ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@EspeciePagamento", parcela.EspeciePagamento?.ToString() ?? (object)DBNull.Value);
            cmd.ExecuteNonQuery();

            parcelaDto.Id = (int)cmd.LastInsertedId;
        }

        public void Atualizar(ParcelaDTO parcelaDto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            var parcela = new Parcela
            {
                Id = parcelaDto.Id,
                Sequencia = parcelaDto.Sequencia,
                Valor = parcelaDto.Valor,
                DataVencimento = parcelaDto.DataVencimento,
                DataPagamento = parcelaDto.DataPagamento,
                ValorPago = parcelaDto.ValorPago,
                EspeciePagamento = parcelaDto.EspeciePagamento
            };

            string sql = @"
                UPDATE Parcela
                SET Sequencia = @Sequencia, DataVencimento = @DataVencimento, Valor = @Valor, 
                    DataPagamento = @DataPagamento, ValorPago = @ValorPago, EspeciePagamento = @EspeciePagamento
                WHERE Id = @Id";

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Sequencia", parcela.Sequencia);
            cmd.Parameters.AddWithValue("@DataVencimento", parcela.DataVencimento);
            cmd.Parameters.AddWithValue("@Valor", parcela.Valor);
            cmd.Parameters.AddWithValue("@DataPagamento", parcela.DataPagamento ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ValorPago", parcela.ValorPago ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@EspeciePagamento", parcela.EspeciePagamento?.ToString() ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Id", parcela.Id);
            cmd.ExecuteNonQuery();
        }

        public void Deletar(ParcelaDTO parcelaDto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            string sql = "DELETE FROM Parcela WHERE Id = @Id";

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Id", parcelaDto.Id);
            cmd.ExecuteNonQuery();
        }

        public IEnumerable<ParcelaDTO> Listar()
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            var lista = new List<ParcelaDTO>();
            string sql = "SELECT * FROM Parcela";

            using var cmd = new MySqlCommand(sql, conexao);
            using var dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                var parcela = new ParcelaDTO
                {
                    Id = Convert.ToInt32(dataReader["Id"]),
                    PendenciaFinanceiraId = Convert.ToInt32(dataReader["PendenciaFinanceiraId"]),
                    Sequencia = Convert.ToInt32(dataReader["Sequencia"]),
                    Valor = Convert.ToDecimal(dataReader["Valor"]),
                    DataVencimento = Convert.ToDateTime(dataReader["DataVencimento"]),
                    DataPagamento = dataReader["DataPagamento"] != DBNull.Value
                        ? (DateTime?)Convert.ToDateTime(dataReader["DataPagamento"])
                        : null,
                    ValorPago = dataReader["ValorPago"] != DBNull.Value
                        ? (decimal?)Convert.ToDecimal(dataReader["ValorPago"])
                        : null,
                    EspeciePagamento = dataReader["EspeciePagamento"] != DBNull.Value
                        ? Enum.Parse<EEspecie>(dataReader["EspeciePagamento"].ToString())
                        : null
                };

                lista.Add(parcela);
            }

            return lista;
        }

        public ParcelaDTO RecuperarPor(Func<ParcelaDTO, bool> filtro)
        {
            var lista = Listar();
            return lista.FirstOrDefault(filtro);
        }
    }
}
