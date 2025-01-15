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
    public class LocacaoRepositorio : ICrud<LocacaoDTO>
    {
        public void Adicionar(LocacaoDTO locacaoDto)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                var locacao = new Locacao
                {
                    Saida = locacaoDto.Saida,
                    Retorno = locacaoDto.Retorno,
                    TipoLocacao = locacaoDto.TipoLocacao,
                    ValorTotal = locacaoDto.ValorTotal,
                    Locatario = new Pessoa { Id = locacaoDto.Locatario.Id },
                    Condutor = new Pessoa { Id = locacaoDto.Condutor.Id },
                    Automovel = new Automovel { Id = locacaoDto.Automovel.Id },
                    PendenciaFinanceira = new PendenciaFinanceira { Id = locacaoDto.PendenciaFinanceira.Id },
                    Status = locacaoDto.Status
                };

                string sql = @"
                INSERT INTO Locacao (Saida, Retorno, TipoLocacao, ValorTotal, LocatarioId, CondutorId, AutomovelId, PendenciaFinanceiraId, StatusLocacao)
                VALUES (@Saida, @Retorno, @TipoLocacao, @ValorTotal, @LocatarioId, @CondutorId, @AutomovelId, @PendenciaFinanceiraId, @StatusLocacao)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {

                    cmd.Parameters.AddWithValue("@Saida", locacao.Saida);
                    cmd.Parameters.AddWithValue("@Retorno", locacao.Retorno);
                    cmd.Parameters.AddWithValue("@TipoLocacao", (int)locacao.TipoLocacao);
                    cmd.Parameters.AddWithValue("@ValorTotal", locacao.ValorTotal);
                    cmd.Parameters.AddWithValue("@LocatarioId", locacao.Locatario.Id);
                    cmd.Parameters.AddWithValue("@CondutorId", locacao.Condutor.Id);
                    cmd.Parameters.AddWithValue("@AutomovelId", locacao.Automovel.Id);
                    cmd.Parameters.AddWithValue("@PendenciaFinanceiraId", locacao.PendenciaFinanceira.Id);
                    cmd.Parameters.AddWithValue("@StatusLocacao", (int)locacao.Status);

                    cmd.ExecuteNonQuery();
                    locacaoDto.Id = (int)cmd.LastInsertedId;
                }
            }
        }

        public void Deletar(LocacaoDTO locacaoDto)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {

                conexao.Open();

                var locacao = new Locacao
                {
                    Id = locacaoDto.Id
                };

                string sql = "DELETE FROM Locacao WHERE Id = @Id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {

                    cmd.Parameters.AddWithValue("@Id", locacao.Id);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public IEnumerable<LocacaoDTO> ListarTodos()
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                string sql = "SELECT * FROM Locacao";
                using (var cmd = new MySqlCommand(sql, conexao))
                {

                    using (var dataReader = cmd.ExecuteReader())
                    {
                        return PopularLista(dataReader);
                    }

                }
            }
        }


        public IEnumerable<LocacaoDTO> PopularLista(MySqlDataReader dataReader)
        {
            var lista = new List<LocacaoDTO>();

            while (dataReader.Read())
            {
                var locacao = new LocacaoDTO
                {
                    Id = Convert.ToInt32(dataReader["Id"]),
                    Saida = Convert.ToDateTime(dataReader["Saida"]),
                    Retorno = Convert.ToDateTime(dataReader["Retorno"]),
                    TipoLocacao = (ETipoLocacao)Convert.ToInt32(dataReader["TipoLocacao"]),
                    ValorTotal = Convert.ToDecimal(dataReader["ValorTotal"]),
                    Locatario = new Pessoa { Id = Convert.ToInt32(dataReader["LocatarioId"]) },
                    Condutor = new Pessoa { Id = Convert.ToInt32(dataReader["CondutorId"]) },
                    Automovel = new Automovel { Id = Convert.ToInt32(dataReader["AutomovelId"]) },
                    PendenciaFinanceira = new PendenciaFinanceira { Id = Convert.ToInt32(dataReader["PendenciaFinanceiraId"]) },
                    Status = (EStatusLocacao)Convert.ToInt32(dataReader["StatusLocacao"])
                };

                lista.Add(locacao);
            }

            return lista;
        }

        public LocacaoDTO? RecuperarPorId(int id)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {

                conexao.Open();

                string sql = "SELECT * FROM Locacao WHERE Id = @Id";
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

        public IEnumerable<LocacaoDTO> ListarPorStatusAndamento()
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {

                conexao.Open();

                string sql = "SELECT * FROM Locacao WHERE statusLocacao = @statusLocacao";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@statusLocacao", (int)EStatusLocacao.ANDAMENTO);
                    using (var dataReader = cmd.ExecuteReader())
                    {
                        var lista = PopularLista(dataReader);
                        return lista;
                    }
                }
            }
        }



        public void AtualizarStatus(int locacaoId, EStatusLocacao novoStatus)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();
                string sql = "UPDATE locacao SET statusLocacao = @statusLocacao WHERE Id = @Id";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@statusLocacao", (int)novoStatus);
                    cmd.Parameters.AddWithValue("@Id", locacaoId);
                    cmd.ExecuteNonQuery();

                }

            }
        }

    }
}
