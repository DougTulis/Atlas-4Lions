using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Infra.Servicos;
using System;
using System.Collections.Generic;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class PendenciaFinanceiraRepositorio : ICrud<PendenciaFinanceiraDTO>
    {
        public void Adicionar(PendenciaFinanceiraDTO pendenciaDto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            var pendencia = new PendenciaFinanceira(
                pendenciaDto.TransacaoId,
                pendenciaDto.ValorTotal
            )
            {
                DataCriacao = DateTime.Now
            };

            string sql = @"
                INSERT INTO PendenciaFinanceira (TransacaoId, ValorTotal, DataCriacao)
                VALUES (@TransacaoId, @ValorTotal, @DataCriacao)";

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@TransacaoId", pendencia.TransacaoId);
            cmd.Parameters.AddWithValue("@ValorTotal", pendencia.ValorTotal);
            cmd.Parameters.AddWithValue("@DataCriacao", pendencia.DataCriacao);
            cmd.ExecuteNonQuery();

            pendenciaDto.Id = (int)cmd.LastInsertedId;

            foreach (var parcela in pendenciaDto.Parcelas)
            {
                parcela.PendenciaFinanceiraId = pendenciaDto.Id;
                AdicionarParcela(parcela, pendenciaDto.Id, conexao);
            }
        }

        private void AdicionarParcela(Parcela parcela, int pendenciaId, MySqlConnection conexao)
        {
            string sql = @"
                INSERT INTO Parcela (PendenciaFinanceiraId, Sequencia, DataVencimento, Valor, DataPagamento, ValorPago, EspeciePagamento)
                VALUES (@PendenciaFinanceiraId, @Sequencia, @DataVencimento, @Valor, @DataPagamento, @ValorPago, @EspeciePagamento)";

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@PendenciaFinanceiraId", pendenciaId);
            cmd.Parameters.AddWithValue("@Sequencia", parcela.Sequencia);
            cmd.Parameters.AddWithValue("@DataVencimento", parcela.DataVencimento);
            cmd.Parameters.AddWithValue("@Valor", parcela.Valor);
            cmd.Parameters.AddWithValue("@DataPagamento", parcela.DataPagamento ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ValorPago", parcela.ValorPago ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@EspeciePagamento", parcela.EspeciePagamento?.ToString() ?? (object)DBNull.Value);
            cmd.ExecuteNonQuery();
        }

        public void Atualizar(PendenciaFinanceiraDTO pendenciaDto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            var pendencia = new PendenciaFinanceira(
                pendenciaDto.TransacaoId,
                pendenciaDto.ValorTotal
            )
            {
                Id = pendenciaDto.Id
            };

            string sql = @"
                UPDATE PendenciaFinanceira
                SET TransacaoId = @TransacaoId, ValorTotal = @ValorTotal
                WHERE Id = @Id";

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@TransacaoId", pendencia.TransacaoId);
            cmd.Parameters.AddWithValue("@ValorTotal", pendencia.ValorTotal);
            cmd.Parameters.AddWithValue("@Id", pendencia.Id);
            cmd.ExecuteNonQuery();
        }

        public void Deletar(PendenciaFinanceiraDTO pendenciaDto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            string sql = "DELETE FROM PendenciaFinanceira WHERE Id = @Id";

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Id", pendenciaDto.Id);
            cmd.ExecuteNonQuery();
        }

        public IEnumerable<PendenciaFinanceiraDTO> Listar()
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            var lista = new List<PendenciaFinanceiraDTO>();
            string sql = "SELECT * FROM PendenciaFinanceira";

            using var cmd = new MySqlCommand(sql, conexao);
            using var dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                var pendencia = new PendenciaFinanceiraDTO(
                    Guid.Parse(dataReader["TransacaoId"].ToString()),
                    Convert.ToDecimal(dataReader["ValorTotal"])
                )
                {
                    Id = Convert.ToInt32(dataReader["Id"]),
                    DataCriacao = Convert.ToDateTime(dataReader["DataCriacao"])
                };

                lista.Add(pendencia);
            }

            return lista;
        }
        public PendenciaFinanceiraDTO RecuperarPor(Func<PendenciaFinanceiraDTO, bool> filtro)
        {
            var lista = Listar();
            return lista.FirstOrDefault(filtro);
        }
    }
}
