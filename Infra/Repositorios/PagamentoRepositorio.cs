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
    public class PagamentoRepositorio : ICrud<PagamentoDTO>
    {
        public void Adicionar(PagamentoDTO objeto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            string sql = @"
                INSERT INTO pagamento (Id,Especie, ValorPago, DataPagamento, DataCriacao)
                VALUES (@Id, @Especie, @ValorPago, @DataPagamento, @DataCriacao)";

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Id", objeto.Id);
            cmd.Parameters.AddWithValue("@Especie", objeto.Especie);
            cmd.Parameters.AddWithValue("@ValorPago", objeto.ValorPago);
            cmd.Parameters.AddWithValue("@DataPagamento", objeto.DataPagamento);
            cmd.Parameters.AddWithValue("@DataCriacao", objeto.DataCriacao);

            cmd.ExecuteNonQuery();
            objeto.Id = (int)cmd.LastInsertedId;
        }

        public void Atualizar(PagamentoDTO objeto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            string sql = @" 
                UPDATE pagamento 
                SET Especie = @Especie, ValorPago = @ValorPago, DataPagamento = @DataPagamento 
                WHERE Id = @Id";

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Especie", objeto.Especie);
            cmd.Parameters.AddWithValue("@ValorPago", objeto.ValorPago);
            cmd.Parameters.AddWithValue("@DataPagamento", objeto.DataPagamento);
            cmd.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now);
            cmd.Parameters.AddWithValue("@Id", objeto.Id);
            cmd.ExecuteNonQuery();
        }

        public void Deletar(PagamentoDTO objeto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            string sql = "DELETE FROM pagamento WHERE Id = @Id";
            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Id", objeto.Id);

            cmd.ExecuteNonQuery();
        }

        public IEnumerable<PagamentoDTO> Listar()
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            var lista = new List<PagamentoDTO>();
            string sql = "SELECT * FROM pagamento";
            using var cmd = new MySqlCommand(sql, conexao);
            using var dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int id = Convert.ToInt32(dataReader["Id"]);
                string especie = Convert.ToString(dataReader["Especie"]);
                decimal valorPago = Convert.ToDecimal(dataReader["ValorPago"]);
                DateTime dataPagamento = Convert.ToDateTime(dataReader["DataPagamento"]);
                DateTime dataCriacao = Convert.ToDateTime(dataReader["DataCriacao"]);
                var pagamento = new PagamentoDTO(
                    (EEspecie)Enum.Parse(typeof(EEspecie), especie),
                    valorPago,
                    dataPagamento
                )
                {
                    Id = id,
                    DataCriacao = dataCriacao,
                };

                lista.Add(pagamento);
            }

            return lista;
        }

        public PagamentoDTO RecuperarPor(Func<PagamentoDTO, bool> filtro)
        {
            var lista = Listar();
            return lista.FirstOrDefault(filtro);
        }
    }
}
