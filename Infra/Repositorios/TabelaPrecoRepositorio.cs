using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Menus;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Infra.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class TabelaPrecoRepositorio : ICrud<TabelaPrecoDTO>
    {
        public void Adicionar(TabelaPrecoDTO objeto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();


            var tabelaPreco = new TabelaPreco
            {
                Id = objeto.Id,
                AutomovelId = objeto.AutomovelId,
                Descricao = objeto.Descricao,
                Valor = objeto.Valor,

            };

            if (!tabelaPreco.Validacao())
            {
                Thread.Sleep(2000);
                MenuInicial.Exibir();
            }
            
            string sql = @"
                INSERT INTO tabela_preco (Descricao, Valor, AutomovelId)
                VALUES (@Descricao, @Valor, @AutomovelId)";

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Descricao", objeto.Descricao);
            cmd.Parameters.AddWithValue("@Valor", objeto.Valor);
            cmd.Parameters.AddWithValue("@AutomovelId", objeto.AutomovelId);

            cmd.ExecuteNonQuery();
            objeto.Id = (int)cmd.LastInsertedId;

        }

        public void Atualizar(TabelaPrecoDTO objeto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            string sql = @"
                UPDATE tabela_preco
                SET Descricao = @Descricao, Valor = @Valor
                WHERE Id = @Id"; // Usando ID único do preço para a atualização

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Descricao", objeto.Descricao);
            cmd.Parameters.AddWithValue("@Valor", objeto.Valor);
            cmd.Parameters.AddWithValue("@Id", objeto.Id); // Adicione `Id` ao DTO para suporte

            cmd.ExecuteNonQuery();
        }

        public void Deletar(TabelaPrecoDTO objeto)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            string sql = "DELETE FROM tabela_preco WHERE Id = @Id"; // Usando o ID único do preço

            using var cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Id", objeto.Id); // Adicione `Id` ao DTO para suporte

            cmd.ExecuteNonQuery();
        }

        public IEnumerable<TabelaPrecoDTO> Listar()
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            var lista = new List<TabelaPrecoDTO>();
            string sql = "SELECT * FROM tabela_preco";

            using var cmd = new MySqlCommand(sql, conexao);
            using var dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                var tabelaPreco = new TabelaPrecoDTO(
                    Convert.ToString(dataReader["Descricao"]),
                    Convert.ToDecimal(dataReader["Valor"]),
                    Convert.ToInt32(dataReader["AutomovelId"])
                )
                {
                    Id = Convert.ToInt32(dataReader["Id"]) // Captura o ID único do preço
                };

                lista.Add(tabelaPreco);
            }

            return lista;
        }

        public TabelaPrecoDTO RecuperarPor(Func<TabelaPrecoDTO, bool> filtro)
        {
            var lista = Listar();
            return lista.FirstOrDefault(filtro);
        }

        public IEnumerable<TabelaPrecoDTO> ListarPor(Func<TabelaPrecoDTO, bool> filtro)
        {
            var lista = Listar();
            return lista.Where(filtro);
        }

    }
}
