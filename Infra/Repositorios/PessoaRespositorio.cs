using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Infra.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class PessoaRespositorio : ICrud<PessoaDTO>

    {
        public void Adicionar(PessoaDTO pessoa)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();
            string sql = @"
                        INSERT INTO pessoa (Nome, Telefone, Email, DataCriacao, DataAtualizacao)
                        VALUES (@Nome, @Telefone, @Email, @DataCriacao, @DataAtualizacao)";

            using (var comando = new MySqlCommand(sql, conexao))
            {
                comando.Parameters.AddWithValue("@Nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@Telefone", pessoa.Contato);
                comando.Parameters.AddWithValue("@Email", pessoa.Email);
                comando.Parameters.AddWithValue("@DataCriacao", DateTime.Now);
                comando.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now);
                comando.ExecuteNonQuery();
            }
        }

        public void Atualizar(PessoaDTO pessoa)
        {
            throw new NotImplementedException();
        }

        public void Deletar(PessoaDTO pessoa)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PessoaDTO> Listar()
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();
            var lista = new List<PessoaDTO>();
            string sql = "SELECT * FROM pessoa";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            using MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                int idPessoa = Convert.ToInt32(dataReader["Id"]);
                string nome = Convert.ToString(dataReader["Nome"]);
                string contato = Convert.ToString(dataReader["Telefone"]);
                string email = Convert.ToString(dataReader["Email"]);
                string cpf = Convert.ToString(dataReader["Cpf"]);
                DateTime nascimento = Convert.ToDateTime(dataReader["Nascimento"]);
                var pessoa = new PessoaDTO(nome, email, contato, nascimento, cpf) { Id = idPessoa};
                lista.Add(pessoa);
            }
            return lista;
        }
    }
}