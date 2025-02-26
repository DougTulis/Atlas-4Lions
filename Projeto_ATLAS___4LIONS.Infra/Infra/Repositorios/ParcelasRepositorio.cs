using MySql.Data.MySqlClient;
using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
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
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public void AdicionarVarias(IEnumerable<ParcelaDTO> parcelasDto)
        {
            throw new NotImplementedException();
        }

        public void AtualizarPagamentoParcela(Guid idPendenciaFinanceira, int sequencia, decimal valorPago, DateTime dataPagamento, EEspecie especiePagamento)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ParcelaDTO> ListarPorPendencia(int pendenciaId)
        {
            throw new NotImplementedException();
        }
    }
}
