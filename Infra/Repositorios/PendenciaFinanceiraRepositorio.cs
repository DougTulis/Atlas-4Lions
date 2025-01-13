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
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                var pendencia = new PendenciaFinanceira(
                    pendenciaDto.TransacaoId,
                    pendenciaDto.ValorTotal
                )
                {
                    DataCriacao = pendenciaDto.DataCriacao
                };

                string sql = @"
                INSERT INTO PendenciaFinanceira (TransacaoId, ValorTotal, DataCriacao)
                VALUES (@TransacaoId, @ValorTotal, @DataCriacao)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {


                    cmd.Parameters.AddWithValue("@TransacaoId", pendencia.TransacaoId);
                    cmd.Parameters.AddWithValue("@ValorTotal", pendencia.ValorTotal);
                    cmd.Parameters.AddWithValue("@DataCriacao", pendencia.DataCriacao);
                    cmd.ExecuteNonQuery();

                    pendenciaDto.Id = (int)cmd.LastInsertedId;
                }
            }
        }

        public void Deletar(PendenciaFinanceiraDTO pendenciaDto)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {

                conexao.Open();

                string sql = "DELETE FROM PendenciaFinanceira WHERE Id = @Id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Id", pendenciaDto.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<PendenciaFinanceiraDTO> ListarTodos()
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
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

        public PendenciaFinanceiraDTO? RecuperarPorId(int id)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                string sql = "SELECT * FROM PendenciaFinanceira WHERE Id = @Id";
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

    }
}
