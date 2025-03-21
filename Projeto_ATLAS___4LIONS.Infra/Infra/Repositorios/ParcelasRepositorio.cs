﻿using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface.Interface_Adapter;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Infra.Infra.Repositorios
{
    public class ParcelasRepositorio : IParcelaRepositorio
    {
        private readonly IMySqlAdaptadorConexao _conexaoAdapter;

        public ParcelasRepositorio(IMySqlAdaptadorConexao conexaoAdapter)
        {
            _conexaoAdapter = conexaoAdapter;
        }

        public void Adicionar(Parcela parcela)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();

                string sql = @"
                INSERT INTO parcela 
                (id, pendencia_financeira_id, sequencia, valor,data_vencimento,data_pagamento, valor_pago, especie_pagamento,data_criacao)
                VALUES 
                (@id, @pendencia_financeira_id, @sequencia, @valor, @data_vencimento, @data_pagamento, @valor_pago, @especie_pagamento,@data_criacao)";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", parcela.Id);
                    cmd.Parameters.AddWithValue("@pendencia_financeira_id", parcela.IdPendenciaFinanceira);
                    cmd.Parameters.AddWithValue("@valor", parcela.Valor);
                    cmd.Parameters.AddWithValue("@data_vencimento", parcela.DataVencimento);
                    cmd.Parameters.AddWithValue("@data_pagamento", parcela.DataPagamento);
                    cmd.Parameters.AddWithValue("@valor_pago", parcela.Valor);
                    cmd.Parameters.AddWithValue("@especie_pagamento", parcela.EspeciePagamento);
                    cmd.Parameters.AddWithValue("@data_criacao", parcela.DataCriacao);
                    cmd.Parameters.AddWithValue("@sequencia", parcela.Sequencia);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public Parcela? RecuperarPorId(Guid id)
        {
            using (var conexao = _conexaoAdapter.ObterConexao())
            {
                conexao.Open();
                string sql = "SELECT * FROM parcela WHERE id = @id";

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
        public IEnumerable<Parcela> PopularLista(MySqlDataReader dataReader)
        {
            var lista = new List<Parcela>();
            while (dataReader.Read())
            {
                var id = Guid.Parse(dataReader["id"].ToString());
                var dataCriacao = Convert.ToDateTime(dataReader["data_criacao"]);
                var sequencia = Convert.ToInt16(dataReader["sequencia"]);
                var pendenciaFinanceiraId = Guid.Parse(dataReader["pendencia_financeira_id"].ToString());
                var valor = Convert.ToDecimal(dataReader["valor"]);
                var dataVencimento = Convert.ToDateTime(dataReader["data_vencimento"]);
                var dataPagamento = dataReader["data_pagamento"] != DBNull.Value ? Convert.ToDateTime(dataReader["data_pagamento"]) : (DateTime?)null;
                var valorPago = dataReader["valor_pago"] != DBNull.Value ? Convert.ToDecimal(dataReader["valor_pago"]) : (decimal?)null;
                var especiePagamento = dataReader["especie_pagamento"] != DBNull.Value ? Enum.Parse<EEspecie>(dataReader["especie_pagamento"].ToString()) : (EEspecie?)null;
                var parcela = Parcela.CreateFromDataBase(id, dataCriacao, sequencia, dataVencimento, valor, pendenciaFinanceiraId);
                lista.Add(parcela);
            }
            return lista;
        }
            public IEnumerable<Parcela> ListarPorPendencia(Guid pendenciaId)
            {
                using (var conexao = _conexaoAdapter.ObterConexao())
                {
                    conexao.Open();
                    string sql = "SELECT * FROM parcela WHERE pendencia_financeira_id = @pendenciaId";

                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@pendenciaId", pendenciaId);
                        using (var dataReader = cmd.ExecuteReader())
                        {
                            return PopularLista(dataReader);
                        }
                    }
                }
            }
            public void AtualizarPagamentoParcela(Guid idPendenciaFinanceira, int sequencia, decimal valorPago, DateTime dataPagamento, EEspecie especiePagamento)
            {
                using (var conexao = _conexaoAdapter.ObterConexao())
                {
                    conexao.Open();
                    string sql = @"UPDATE parcela SET valor_pago = @valor_pago, data_pagamento = @data_pagamento, especie_pagamento = @especie_pagamento 
                                WHERE pendencia_financeira_id = @pendencia_financeira_id AND sequencia = @sequencia";

                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@pendencia_financeira_id", idPendenciaFinanceira);
                        cmd.Parameters.AddWithValue("@sequencia", sequencia);
                        cmd.Parameters.AddWithValue("@valor_pago", valorPago);
                        cmd.Parameters.AddWithValue("@data_pagamento", dataPagamento);
                        cmd.Parameters.AddWithValue("@especie_pagamento", especiePagamento.ToString());
                        cmd.ExecuteNonQuery();
                    }
                }
            }

        }
    }
