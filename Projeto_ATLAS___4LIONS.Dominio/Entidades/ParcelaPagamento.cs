using Projeto_ATLAS___4LIONS.Aplicacao.Validacoes;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class ParcelaPagamento : ModeloAbstrato2
    {
        public Guid  Id { get; private set; }
        public DateTime Criacao { get; set; }
        public int Sequencia { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public decimal Valor { get; private set; }
        public Guid IdPendenciaFinanceira { get; private set; }
        public DateTime? DataPagamento { get; private set; }
        public decimal? ValorPago { get; private set; }
        public EEspecie? EspeciePagamento { get; private set; }

        public ParcelaPagamento(Guid id, DateTime criacao, int sequencia, DateTime dataVencimento, decimal valor, Guid idPendenciaFinanceira, DateTime? dataPagamento, decimal? valorPago, EEspecie? especiePagamento) : base(id,criacao)
        {
            Id = id;
            Criacao = criacao;
            Sequencia = sequencia;
            DataVencimento = dataVencimento;
            Valor = valor;
            IdPendenciaFinanceira = idPendenciaFinanceira;
            DataPagamento = dataPagamento;
            ValorPago = valorPago;
            EspeciePagamento = especiePagamento;
        }

        public static ParcelaPagamento Create (Guid id, DateTime criacao, int sequencia, DateTime dataVencimento, decimal valor, Guid idPendenciaFinanceira, DateTime? dataPagamento, decimal? valorPago, EEspecie? especiePagamento)
        {
            return new ParcelaPagamento(id, criacao, sequencia, dataVencimento, valor,idPendenciaFinanceira, dataPagamento, valorPago, especiePagamento);
        }

        public override bool Validacao(out string erros)
        {
            erros = "";
            var contratos = new ContratoValidacoes<Parcela>()
           .ValorPagoIsOk(this.Valor, "O valor é obrigatório", "ValorPago");

            if (!contratos.IsValid())
            {
                erros = contratos.CapturadorErros();
                return false;
            }
            return true;
        }
    }
}
