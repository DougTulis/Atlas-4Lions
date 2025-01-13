using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Infra.Servicos;
using System;
using System.Collections.Generic;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class PessoaRepositorio : ICrud<PessoaDTO>
    {
        public void Adicionar(PessoaDTO pessoaDto)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                string sql = @"
                INSERT INTO pessoa (Nome, Email, Contato, DataNascimento, Cpf, Cnpj, NumeroCnh, VencimentoCnh, DataCriacao)
                VALUES (@Nome, @Email, @Contato, @DataNascimento, @Cpf, @Cnpj, @NumeroCnh, @VencimentoCnh, @DataCriacao)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Nome", pessoaDto.Nome);
                    cmd.Parameters.AddWithValue("@Email", pessoaDto.Email);
                    cmd.Parameters.AddWithValue("@Contato", pessoaDto.Contato);
                    cmd.Parameters.AddWithValue("@DataNascimento", pessoaDto.DataNascimento);
                    cmd.Parameters.AddWithValue("@Cpf", pessoaDto.Cpf ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cnpj", pessoaDto.Cnpj ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@NumeroCnh", pessoaDto.NumeroCnh ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@VencimentoCnh", pessoaDto.VencimentoCnh ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@DataCriacao", pessoaDto.DataCriacao);

                    cmd.ExecuteNonQuery();
                    pessoaDto.Id = (int)cmd.LastInsertedId;
                }
            }
        }

        public void Deletar(PessoaDTO pessoaDto)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                string sql = "DELETE FROM pessoa WHERE Id = @Id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Id", pessoaDto.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<PessoaDTO> ListarTodos()
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                string sql = "SELECT * FROM pessoa";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    using (var dataReader = cmd.ExecuteReader())
                    {
                        return PopularLista(dataReader);
                    }
                }
            }
        }

        public PessoaDTO? RecuperarPorId(int id)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                string sql = "SELECT * FROM pessoa WHERE Id = @Id";

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

        public IEnumerable<PessoaDTO> ListarSemCNH()
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                string sql = "SELECT * FROM pessoa WHERE NumeroCnh IS NULL";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    using (var dataReader = cmd.ExecuteReader())
                    {
                        return PopularLista(dataReader);
                    }
                }
            }
        }

        public void IncluirCNH(int id, string numeroCnh, DateTime vencimentoCnh)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                string sql = "UPDATE pessoa SET NumeroCnh = @NumeroCnh, VencimentoCnh = @VencimentoCnh WHERE Id = @Id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@NumeroCnh", numeroCnh);
                    cmd.Parameters.AddWithValue("@VencimentoCnh", vencimentoCnh);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<PessoaDTO> PopularLista(MySqlDataReader dataReader)
        {
            var lista = new List<PessoaDTO>();

            while (dataReader.Read())
            {
                var pessoa = new PessoaDTO(
                    Convert.ToString(dataReader["Nome"]),
                    Convert.ToString(dataReader["Email"]),
                    Convert.ToString(dataReader["Contato"]),
                    Convert.ToDateTime(dataReader["DataNascimento"]),
                    dataReader["Cpf"] != DBNull.Value ? Convert.ToString(dataReader["Cpf"]) : null)
                {
                    Id = Convert.ToInt32(dataReader["Id"]),
                    Cnpj = dataReader["Cnpj"] != DBNull.Value ? Convert.ToString(dataReader["Cnpj"]) : null,
                    NumeroCnh = dataReader["NumeroCnh"] != DBNull.Value ? Convert.ToString(dataReader["NumeroCnh"]) : null,
                    VencimentoCnh = dataReader["VencimentoCnh"] != DBNull.Value ? Convert.ToDateTime(dataReader["VencimentoCnh"]) : null,
                    DataCriacao = Convert.ToDateTime(dataReader["DataCriacao"])
                };

                lista.Add(pessoa);
            }

            return lista;
        }
    }
}
