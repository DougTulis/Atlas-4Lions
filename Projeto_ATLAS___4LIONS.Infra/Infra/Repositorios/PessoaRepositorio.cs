using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.Interface_Adapter;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using Projeto_ATLAS___4LIONS.Infra.Servicos;

namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class PessoaRepositorio : IPessoaRepositorio
    {

        private readonly IMySqlAdaptadorConexao _conexaoAdapter;

        public PessoaRepositorio(IMySqlAdaptadorConexao conexaoAdapter)
        {
            _conexaoAdapter = conexaoAdapter;
        }

        public void Adicionar(Pessoa pessoa)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = @"
                INSERT INTO pessoa (data_criacao,vencimento_cnh,data_registro,id,nome,email,contato,numero_cnh,tipo_pessoa,numero_documento)
                VALUES (@data_criacao,@vencimento_cnh,@data_registro,@id,@nome,@email,@contato,@numero_cnh,@tipo_pessoa,@numero_documento)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", pessoa.Id);
                    cmd.Parameters.AddWithValue("@data_criacao", pessoa.DataCriacao);
                    cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
                    cmd.Parameters.AddWithValue("@email", pessoa.Email);
                    cmd.Parameters.AddWithValue("@contato", pessoa.Contato);
                    cmd.Parameters.AddWithValue("@data_registro", pessoa.DataRegistro);
                    cmd.Parameters.AddWithValue("@tipo_pessoa", pessoa.TipoPessoa.ToString());
                    cmd.Parameters.AddWithValue("@numero_documento", pessoa.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@numero_cnh", pessoa.NumeroCnh ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@vencimento_Cnh", pessoa.VencimentoCnh ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public void Deletar(Guid id)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = "DELETE FROM pessoa WHERE id = @id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool TemLocacaoVinculada(Guid id)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = $"select count(*) from pessoa inner join locacao ON pessoa.id = locacao.locatario_id or pessoa.id = condutor_id where locacao.status_locacao = 'ANDAMENTO' and pessoa.id = @id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int count = Convert.ToInt16(cmd.ExecuteScalar());
                    if (count > 0) { return true; }

                    return false;
                }
            }
        }

        public IEnumerable<Pessoa> ListarTodos()
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
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

        public Pessoa? RecuperarPorId(Guid id)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = "SELECT * FROM pessoa WHERE id = @id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var dataReader = cmd.ExecuteReader())
                    {
                        var lista = PopularLista(dataReader);
                        return lista.FirstOrDefault();
                    }
                }
            }
        }

        public IEnumerable<Pessoa> ListarSemCNH()
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = "SELECT * FROM pessoa WHERE vencimento_cnh IS NULL";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    using (var dataReader = cmd.ExecuteReader())
                    {
                        return PopularLista(dataReader);
                    }
                }
            }
        }

        public void IncluirCNH(Guid id, string numeroCnh, DateTime vencimentoCnh)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = "UPDATE pessoa SET numero_cnh = @numero_cnh, vencimento_cnh = @vencimento_cnh WHERE id = @id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@numero_cnh", numeroCnh);
                    cmd.Parameters.AddWithValue("@vencimento_cnh", vencimentoCnh);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public IEnumerable<Pessoa> PopularLista(MySqlDataReader dataReader)
        {
            var lista = new List<Pessoa>();

            while (dataReader.Read())
            {
                var id = Guid.Parse(dataReader["id"].ToString());
                var dataCriacao = Convert.ToDateTime(dataReader["data_criacao"]);
                var nome = Convert.ToString(dataReader["nome"]);
                var email = Convert.ToString(dataReader["email"]);
                var contato = Convert.ToString(dataReader["contato"]);
                var dataRegistro = Convert.ToDateTime(dataReader["data_registro"]);
                var tipoPessoa = Enum.Parse<ETipoPessoa>(dataReader["tipo_pessoa"].ToString());
                var numeroDocumento = dataReader["numero_documento"].ToString();
                var numeroCnh = dataReader["numero_cnh"]!= DBNull.Value ? dataReader["numero_cnh"].ToString() : null;
                var vencimentoCnh = Convert.ToDateTime(dataReader["vencimento_cnh"] != DBNull.Value ? Convert.ToDateTime(dataReader["vencimento_cnh"]) : null);

                var pessoa = Pessoa.CreateFromDataBase(id, dataCriacao, nome, email, contato, tipoPessoa, numeroDocumento, dataRegistro, numeroCnh, vencimentoCnh);

                lista.Add(pessoa);
            }

            return lista;
        }

    }
}
