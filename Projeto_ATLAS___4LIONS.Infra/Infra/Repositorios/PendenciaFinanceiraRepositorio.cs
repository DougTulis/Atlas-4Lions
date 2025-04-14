using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.Interface_Adapter;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using System.Security.Cryptography.X509Certificates;


namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class PendenciaFinanceiraRepositorio : IPendenciaFinanceiraRepositorio
    {
        private readonly ILocacaoRepositorio _locacaoRepositorio;
        private readonly IMySqlAdaptadorConexao _conexaoAdapter;

        public PendenciaFinanceiraRepositorio(ILocacaoRepositorio locacaoRepositorio, IMySqlAdaptadorConexao conexaoAdapter)
        {
            _locacaoRepositorio = locacaoRepositorio;
            _conexaoAdapter = conexaoAdapter;
        }

        public void Adicionar(PendenciaFinanceira pendencia)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();


                string sql = @"
                INSERT INTO pendencia_financeira (id, valor_total, data_criacao)
                VALUES (@id, @valor_total, @data_criacao)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", pendencia.Id);
                    cmd.Parameters.AddWithValue("@valor_total", pendencia.ValorTotal);
                    cmd.Parameters.AddWithValue("@data_criacao", pendencia.DataCriacao);
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public void Deletar(Guid id)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();
                string sql = "DELETE FROM pendencia_financeira WHERE id = @id";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<PendenciaFinanceira> ListarTodos()
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM pendencia_financeira";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    using (var dataReader = cmd.ExecuteReader())
                    {
                        return PopularLista(dataReader);
                    }
                }
            }
        }


        public IList<object[]> ListarPagamentosPendente()
        {
            IList<object[]> lista = new List<object[]>();

            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT p.nome, pendfin.id, pendfin.valor_total, COUNT(pcla.id) AS quantidade_parcelas, CASE WHEN SUM(CASE WHEN pcla.valor_pago IS NULL OR pcla.valor_pago = 0 THEN 1 ELSE 0 END) > 0 THEN 'Pendente' ELSE 'Quitado' END AS status_pagamento FROM pessoa p INNER JOIN locacao l ON l.locatario_id = p.id INNER JOIN pendencia_financeira pendfin ON pendfin.id = l.pendencia_financeira_id INNER JOIN parcela pcla ON pcla.pendencia_financeira_id = pendfin.id GROUP BY p.nome, pendfin.valor_total, pendfin.id;";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    using (var dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new object[]
                            {
                                 dataReader["nome"].ToString(),
                                 Convert.ToDecimal(dataReader["valor_total"]),
                                 Convert.ToInt16(dataReader["quantidade_parcelas"]),
                                 dataReader["status_pagamento"].ToString(),
                                 Guid.Parse(dataReader["id"].ToString())
                            });
                        }
                    }
                }
                return lista;
            }
        }

        //   public IEnumerable<PendenciaFinanceira> ListarPagamentosPendente()
        //   {
        //       using (var conexao = _conexaoAdapter.ObterConexao())
        //       {
        //           conexao.Open();
        //           string sql = "SELECT * FROM pendencia_financeira as pendfin INNER JOIN parcela as p ON pendfin.id = //p.pendencia_financeira_id WHERE p.data_pagamento is null and valor_pago is null and especie_pagamento is null";
        //
        //           using (var cmd = new MySqlCommand(sql, conexao))
        //           {
        //               using (var dataReader = cmd.ExecuteReader())
        //               {
        //                   return PopularLista(dataReader);
        //               }
        //           }
        //       }
        //   }
        public IEnumerable<PendenciaFinanceira> PopularLista(MySqlDataReader dataReader)
        {
            var lista = new List<PendenciaFinanceira>();

            while (dataReader.Read())
            {

                var id = Guid.Parse(dataReader["Id"].ToString());
                var valorTotal = Convert.ToDecimal(dataReader["valor_total"]);
                var dataCriacao = Convert.ToDateTime(dataReader["data_Criacao"]);
                var pendencia = PendenciaFinanceira.CreateFromDataBase(id, dataCriacao, valorTotal);
                lista.Add(pendencia);

            }
            return lista;
        }

        public PendenciaFinanceira? RecuperarPorId(Guid id)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM pendencia_financeira WHERE id = @id";

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
    }
}
