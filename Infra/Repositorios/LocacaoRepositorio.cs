using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
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
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            if (locacaoDto.PendenciaFinanceira == null || locacaoDto.PendenciaFinanceira.Id == 0)
            {
                throw new InvalidOperationException("A Pendência Financeira deve ser criada antes de associá-la à Locação.");
            }

            var locacao = new Locacao
            {
                Saida = locacaoDto.Saida,
                Retorno = locacaoDto.Retorno,
                TipoLocacao = locacaoDto.TipoLocacao,
                ValorTotal = locacaoDto.ValorTotal,
                Locatario = new Pessoa { Id = locacaoDto.Locatario.Id },
                Condutor = new Pessoa { Id = locacaoDto.Condutor.Id },
                Automovel = new Automovel { Id = locacaoDto.Automovel.Id },
                PendenciaFinanceira = new PendenciaFinanceira { Id = locacaoDto.PendenciaFinanceira.Id }
            };

            string sql = @"
                INSERT INTO Locacao (Saida, Retorno, TipoLocacao, ValorTotal, LocatarioId, CondutorId, AutomovelId, PendenciaFinanceiraId)
                VALUES (@Saida, @Retorno, @TipoLocacao, @ValorTotal, @LocatarioId, @CondutorId, @AutomovelId, @PendenciaFinanceiraId);
            ";

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Saida", locacao.Saida);
            cmd.Parameters.AddWithValue("@Retorno", locacao.Retorno);
            cmd.Parameters.AddWithValue("@TipoLocacao", (int)locacao.TipoLocacao);
            cmd.Parameters.AddWithValue("@ValorTotal", locacao.ValorTotal);
            cmd.Parameters.AddWithValue("@LocatarioId", locacao.Locatario.Id);
            cmd.Parameters.AddWithValue("@CondutorId", locacao.Condutor.Id);
            cmd.Parameters.AddWithValue("@AutomovelId", locacao.Automovel.Id);
            cmd.Parameters.AddWithValue("@PendenciaFinanceiraId", locacao.PendenciaFinanceira.Id);

            cmd.ExecuteNonQuery();
            locacaoDto.Id = (int)cmd.LastInsertedId;
        }

        public void Atualizar(LocacaoDTO locacaoDto)
        {
            throw new NotImplementedException();
        }

        public void Deletar(LocacaoDTO locacaoDto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            // Popular o modelo com os dados do DTO
            var locacao = new Locacao
            {
                Id = locacaoDto.Id
            };

            string sql = "DELETE FROM Locacao WHERE Id = @Id";

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Id", locacao.Id);

            cmd.ExecuteNonQuery();
        }

        public IEnumerable<LocacaoDTO> Listar()
        {
            throw new NotImplementedException();
        }

        public LocacaoDTO? RecuperarPor(Func<LocacaoDTO, bool> filtro)
        {
            throw new NotImplementedException();
        }
    }
}
