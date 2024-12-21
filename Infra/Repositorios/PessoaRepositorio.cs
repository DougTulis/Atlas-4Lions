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
    public class PessoaRepositorio : ICrud<PessoaDTO>

    {
        public void Adicionar(PessoaDTO pessoa)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();
            string sql = @"
                        INSERT INTO pessoa (Nome, Contato, Email, DataCriacao, DataNascimento, Cpf)
                        VALUES (@Nome, @Contato, @Email, @DataCriacao, @DataNascimento, @Cpf)";

            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                cmd.Parameters.AddWithValue("@Contato", pessoa.Contato);
                cmd.Parameters.AddWithValue("@Email", pessoa.Email);
                cmd.Parameters.AddWithValue("@DataCriacao", pessoa.DataCriacao);
                cmd.Parameters.AddWithValue("@DataNascimento", pessoa.DataNascimento);
                cmd.Parameters.AddWithValue("@Cpf", pessoa.Cpf);
                cmd.ExecuteNonQuery();
            }
        }

        public void Atualizar(PessoaDTO pessoa)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();

            string sql = @" UPDATE pessoa SET Nome = @Nome, Telefone = @Telefone, Email = @Email,  DataAtualizacao = @DataAtualizacao  WHERE Id = @Id";

            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                cmd.Parameters.AddWithValue("@Telefone", pessoa.Contato);
                cmd.Parameters.AddWithValue("@Email", pessoa.Email);
                cmd.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now);
                cmd.Parameters.AddWithValue("@Id", pessoa.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar(PessoaDTO pessoa)
        {
            using var conexao = new MySqlAdaptadorConexao().ObterConexao();
            conexao.Open();
            string sql = $"DELETE FROM pessoa WHERE Id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", pessoa.Id);
            cmd.ExecuteNonQuery();
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
                string contato = Convert.ToString(dataReader["Contato"]);
                string email = Convert.ToString(dataReader["Email"]);
                string cpf = Convert.ToString(dataReader["Cpf"]);
                DateTime nascimento = Convert.ToDateTime(dataReader["DataNascimento"]);
                DateTime dataCriacao = Convert.ToDateTime(dataReader["DataCriacao"]);
                var pessoa = new PessoaDTO(nome, email, contato, nascimento, cpf) { Id = idPessoa, DataCriacao = dataCriacao};
                lista.Add(pessoa);
            }
            return lista;
        }

        public PessoaDTO RecuperarPor(Func<PessoaDTO, bool> filtro)
        {
            IEnumerable<PessoaDTO> pessoaLista = Listar();

            return pessoaLista.FirstOrDefault(filtro);
        }
    }
}