using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Infra.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class PendenciaFinanceiraRepositorio : ICrud<PendenciaFinanceiraDTO>
    {
        public void Adicionar(PendenciaFinanceiraDTO objeto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            string sql = @"
                INSERT INTO pendenciafinanceira (ValorTotal, LocacaoId, DataCriacao)
                VALUES (@ValorTotal,@LocacaoId, @DataCriacao)";

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ValorTotal", objeto.ValorTotal);
            cmd.Parameters.AddWithValue("@LocacaoId", objeto.LocacaoId);
            cmd.Parameters.AddWithValue("@DataCriacao", objeto.DataCriacao);

            
            cmd.ExecuteNonQuery();
            objeto.Id = (int)cmd.LastInsertedId;
        }

        public void Atualizar(PendenciaFinanceiraDTO objeto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            string sql = @"
                UPDATE pendenciafinanceira
                SET ValorTotal = @ValorTotal
                WHERE Id = @Id";

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ValorTotal", objeto.ValorTotal);
            cmd.Parameters.AddWithValue("@Id", objeto.Id);

            cmd.ExecuteNonQuery();
        }

        public void Deletar(PendenciaFinanceiraDTO objeto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            string sql = "DELETE FROM pendenciafinanceira WHERE Id = @Id";

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Id", objeto.Id);

            cmd.ExecuteNonQuery();
        }

        public IEnumerable<PendenciaFinanceiraDTO> Listar()
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            var lista = new List<PendenciaFinanceiraDTO>();
            string sql = "SELECT * FROM pendenciafinanceira";

            using var cmd = new MySqlCommand(sql, conexao);
            using var dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                var pendencia = new PendenciaFinanceiraDTO
                {
                    Id = Convert.ToInt32(dataReader["Id"]),
                    ValorTotal = Convert.ToDecimal(dataReader["ValorTotal"]),
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
