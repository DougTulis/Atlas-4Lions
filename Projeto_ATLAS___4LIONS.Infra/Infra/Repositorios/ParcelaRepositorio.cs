using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.Interface_Adapter;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using Projeto_ATLAS___4LIONS.Infra.Servicos;


namespace Projeto_ATLAS___4LIONS.Infra.Repositorios
{
    public class ParcelaRepositorio : IParcelaRepositorio
    {
        private readonly IMySqlAdaptadorConexao _conexaoAdapter;
public ParcelaRepositorio(IMySqlAdaptadorConexao conexaoAdapter)
        {
            _conexaoAdapter = conexaoAdapter;
        }

        public void Adicionar(ParcelaDTO parcelaDto)
        {
            var parcela = new Parcela
            {
                PendenciaFinanceiraId = parcelaDto.PendenciaFinanceiraId,
                Sequencia = parcelaDto.Sequencia,
                DataVencimento = parcelaDto.DataVencimento,
                Valor = parcelaDto.Valor
            };

            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = @"
                    INSERT INTO Parcela (PendenciaFinanceiraId, Sequencia, DataVencimento, Valor)
                    VALUES (@PendenciaFinanceiraId, @Sequencia, @DataVencimento, @Valor)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@PendenciaFinanceiraId", parcela.PendenciaFinanceiraId);
                    cmd.Parameters.AddWithValue("@Sequencia", parcela.Sequencia);
                    cmd.Parameters.AddWithValue("@DataVencimento", parcela.DataVencimento);
                    cmd.Parameters.AddWithValue("@Valor", parcela.Valor);

                    cmd.ExecuteNonQuery();
                    parcelaDto.Id = (int)cmd.LastInsertedId;
                }
            }
        }

        public void AdicionarVarias(IEnumerable<ParcelaDTO> parcelasDto)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                {
                    try
                    {
                        string sql = @"
                            INSERT INTO Parcela (PendenciaFinanceiraId, Sequencia, DataVencimento, Valor)
                            VALUES (@PendenciaFinanceiraId, @Sequencia, @DataVencimento, @Valor)";

                        using (var cmd = new MySqlCommand(sql, conexao, transacao))
                        {
                            foreach (var parcelaDto in parcelasDto)
                            {
                                var parcela = new Parcela
                                {
                                    PendenciaFinanceiraId = parcelaDto.PendenciaFinanceiraId,
                                    Sequencia = parcelaDto.Sequencia,
                                    DataVencimento = parcelaDto.DataVencimento,
                                    Valor = parcelaDto.Valor
                                };

                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@PendenciaFinanceiraId", parcela.PendenciaFinanceiraId);
                                cmd.Parameters.AddWithValue("@Sequencia", parcela.Sequencia);
                                cmd.Parameters.AddWithValue("@DataVencimento", parcela.DataVencimento);
                                cmd.Parameters.AddWithValue("@Valor", parcela.Valor);

                                cmd.ExecuteNonQuery();
                                parcelaDto.Id = (int)cmd.LastInsertedId;
                            }
                        }

                        transacao.Commit();
                    }
                    catch
                    {
                        transacao.Rollback();
                        throw;
                    }
                }
            }
        }

        public IEnumerable<ParcelaDTO> ListarPorPendencia(int pendenciaId)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = "SELECT * FROM Parcela WHERE PendenciaFinanceiraId = @PendenciaFinanceiraId And ValorPago is NULL";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@PendenciaFinanceiraId", pendenciaId);

                    using (var dataReader = cmd.ExecuteReader())
                    {
                        var lista = new List<ParcelaDTO>();

                        while (dataReader.Read())
                        {
                            lista.Add(new ParcelaDTO
                            {
                                Id = Convert.ToInt32(dataReader["Id"]),
                                PendenciaFinanceiraId = Convert.ToInt32(dataReader["PendenciaFinanceiraId"]),
                                Sequencia = Convert.ToInt32(dataReader["Sequencia"]),
                                DataVencimento = Convert.ToDateTime(dataReader["DataVencimento"]),
                                Valor = Convert.ToDecimal(dataReader["Valor"])
                            });
                        }

                        return lista;
                    }
                }
            }
        }

        public ParcelaDTO? RecuperarPorId(int id)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = "SELECT * FROM Parcela WHERE Id= @Id ";
                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (var dataReader = cmd.ExecuteReader())
                    {
                        var lista = new List<ParcelaDTO>();

                        while (dataReader.Read())
                        {
                            lista.Add(new ParcelaDTO
                            {
                                Id = Convert.ToInt32(dataReader["Id"]),
                                PendenciaFinanceiraId = Convert.ToInt32(dataReader["PendenciaFinanceiraId"]),
                                Sequencia = Convert.ToInt32(dataReader["Sequencia"]),
                                DataVencimento = Convert.ToDateTime(dataReader["DataVencimento"]),
                                Valor = Convert.ToDecimal(dataReader["Valor"])
                            });
                        }

                        return lista.FirstOrDefault();
                    }
                }
            }
        }

        public void AtualizarPagamentoParcela(int idPendenciaFinanceira, int sequencia, decimal valorPago, DateTime dataPagamento, EEspecie especiePagamento)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = @"
        UPDATE parcela 
        SET ValorPago = @ValorPago, 
            DataPagamento = @DataPagamento, 
            EspeciePagamento = @EspeciePagamento 
        WHERE PendenciaFinanceiraId = @PendenciaFinanceiraId and Sequencia = @Sequencia";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@ValorPago", valorPago);
                    cmd.Parameters.AddWithValue("@DataPagamento", dataPagamento);
                    cmd.Parameters.AddWithValue("@EspeciePagamento", especiePagamento);
                    cmd.Parameters.AddWithValue("@PendenciaFinanceiraId", idPendenciaFinanceira.ToString());
                    cmd.Parameters.AddWithValue("@Sequencia", sequencia);
                    cmd.ExecuteNonQuery();

                }
            }
        }


    }
}
