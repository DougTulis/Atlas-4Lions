using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Infra.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class ParcelaRepositorio : ICrud<ParcelaDTO>
    {
        public void Adicionar(ParcelaDTO objeto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            string sql = @"
                INSERT INTO parcela (PendenciaFinanceiraId,ValorParcela, DataVencimento, DataCriacao)
                VALUES (@PendenciaFinanceiraId, @ValorParcela, @DataVencimento, @DataCriacao)";

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@PendenciaFinanceiraId", objeto.PendenciaFinanceiraId);
            cmd.Parameters.AddWithValue("@ValorParcela", objeto.ValorParcela);
            cmd.Parameters.AddWithValue("@DataVencimento", objeto.DataVencimento);
            cmd.Parameters.AddWithValue("@DataCriacao", objeto.DataCriacao);

            cmd.ExecuteNonQuery();
            objeto.Id = (int)cmd.LastInsertedId;
        }

        public void Atualizar(ParcelaDTO objeto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            string sql = @"
                UPDATE parcela
                SET ValorParcela = @ValorParcela, DataVencimento = @DataVencimento, DataAtualizacao = @DataAtualizacao
                WHERE Id = @Id";

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ValorParcela", objeto.ValorParcela);
            cmd.Parameters.AddWithValue("@DataVencimento", objeto.DataVencimento);
            cmd.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now);
            cmd.Parameters.AddWithValue("@Id", objeto.Id);

            cmd.ExecuteNonQuery();
        }

        public void Deletar(ParcelaDTO objeto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            string sql = "DELETE FROM parcela WHERE Id = @Id";

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Id", objeto.Id);

            cmd.ExecuteNonQuery();
        }

        public IEnumerable<ParcelaDTO> Listar()
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            var lista = new List<ParcelaDTO>();
            string sql = "SELECT * FROM parcela";

            using var cmd = new MySqlCommand(sql, conexao);
            using var dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                var parcela = new ParcelaDTO
                {
                    Id = Convert.ToInt32(dataReader["Id"]),
                    ValorParcela = Convert.ToDecimal(dataReader["ValorParcela"]),
                    DataVencimento = Convert.ToDateTime(dataReader["DataVencimento"]),
                    DataCriacao = Convert.ToDateTime(dataReader["DataCriacao"])
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
