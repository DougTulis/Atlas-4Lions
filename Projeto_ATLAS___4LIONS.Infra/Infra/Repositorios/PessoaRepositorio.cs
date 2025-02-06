using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Infra.Servicos;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        public void Adicionar(PessoaDTO pessoaDto)
        {
            using (var conexao = new MySqlAdaptadorConexao().ObterConexao())
            {
                conexao.Open();

                var pessoa = new Pessoa
                {
                    Nome = pessoaDto.Nome,
                    Email = pessoaDto.Email,
                    Contato = pessoaDto.Contato,
                    DataNascimento = pessoaDto.DataNascimento,
                    Cpf = pessoaDto.Cpf ?? null,
                    Cnpj = pessoaDto.Cnpj ?? null,
                    DataCriacao = DateTime.Now,
                    NumeroCnh = pessoaDto.NumeroCnh ?? null,
                    VencimentoCnh = pessoaDto.VencimentoCnh ?? null
                };

                string sql = @"
                INSERT INTO pessoa (Nome, Email, Contato, DataNascimento, Cpf, Cnpj, NumeroCnh, VencimentoCnh, DataCriacao)
                VALUES (@Nome, @Email, @Contato, @DataNascimento, @Cpf, @Cnpj, @NumeroCnh, @VencimentoCnh, @DataCriacao)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                    cmd.Parameters.AddWithValue("@Email", pessoa.Email);
                    cmd.Parameters.AddWithValue("@Contato", pessoa.Contato);
                    cmd.Parameters.AddWithValue("@DataNascimento", pessoa.DataNascimento);
                    cmd.Parameters.AddWithValue("@Cpf", pessoa.Cpf ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cnpj", pessoa.Cnpj ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@NumeroCnh", pessoa.NumeroCnh ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@VencimentoCnh", pessoa.VencimentoCnh ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@DataCriacao", pessoa.DataCriacao);

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
                var nome = Convert.ToString(dataReader["Nome"]);
                var email = Convert.ToString(dataReader["Email"]);
                var contato = Convert.ToString(dataReader["Contato"]);
                var dataNascimento = dataReader["DataNascimento"] != DBNull.Value
                    ? Convert.ToDateTime(dataReader["DataNascimento"])
                    : (DateTime?)null; // Opcional para pessoa jurídica
                var cpf = dataReader["Cpf"] != DBNull.Value
                    ? Convert.ToString(dataReader["Cpf"])
                    : null;
                var cnpj = dataReader["Cnpj"] != DBNull.Value
                    ? Convert.ToString(dataReader["Cnpj"])
                    : null;

                var pessoa = new PessoaDTO(nome, email, contato, cpf, cnpj)
                {
                    Id = Convert.ToInt32(dataReader["Id"]),
                    NumeroCnh = dataReader["NumeroCnh"] != DBNull.Value
                        ? Convert.ToString(dataReader["NumeroCnh"])
                        : null,
                    VencimentoCnh = dataReader["VencimentoCnh"] != DBNull.Value
                        ? Convert.ToDateTime(dataReader["VencimentoCnh"])
                        : (DateTime?)null,
                    DataCriacao = Convert.ToDateTime(dataReader["DataCriacao"])
                };

                lista.Add(pessoa);
            }

            return lista;
        }

    }
}
