using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Infra.Servicos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class LocacaoRepositorio : ICrud<LocacaoDTO>
    {
        public void Adicionar(LocacaoDTO objeto)
        {

            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();


            string sql = @"
                        INSERT INTO locacao (Saida, Retorno, TipoLocacao, TransacaoID, ValorTotal, LocatarioId,CondutorId,AutomovelId,PagamentoId, DataCriacao)
                        VALUES (@Saida, @Retorno, @TipoLocacao, @TransacaoID, @ValorTotal, @LocatarioId,@CondutorId, @AutomovelId,@PagamentoId, @DataCriacao)"
            ;

            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@Saida", objeto.Saida);
                cmd.Parameters.AddWithValue("@Retorno", objeto.Retorno);
                cmd.Parameters.AddWithValue("@TipoLocacao", objeto.TipoLocacao);
                cmd.Parameters.AddWithValue("@TransacaoID", objeto.TransacaoID);
                cmd.Parameters.AddWithValue("@ValorTotal", objeto.ValorTotal.ToString("F2",CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@LocatarioId", objeto.LocatarioId);
                cmd.Parameters.AddWithValue("@CondutorId", objeto.CondutorId);
                cmd.Parameters.AddWithValue("@AutomovelId", objeto.AutomovelId);
                cmd.Parameters.AddWithValue("@PagamentoId", objeto.PagamentoId);
                cmd.Parameters.AddWithValue("@DataCriacao", objeto.DataCriacao);
                cmd.ExecuteNonQuery();
                objeto.Id = (int)cmd.LastInsertedId;
            }
        }

        public void Atualizar(LocacaoDTO objeto)
        {
            throw new NotImplementedException();
        }

        public void Deletar(LocacaoDTO objeto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();
            string sql = $"DELETE FROM locacao WHERE Id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", objeto.Id);
            cmd.ExecuteNonQuery();
        }

        public IEnumerable<LocacaoDTO> Listar()
        {
            throw new NotImplementedException();
        }

        public LocacaoDTO? RecuperarPor(Func<LocacaoDTO, bool> resultado)
        {
            throw new NotImplementedException();
        }
    }
}
