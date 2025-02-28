using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class LocacaoPagamento : ModeloAbstrato2
    {
        public Guid Id { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime Saida { get; private set; }
        public DateTime Retorno { get; private set; }
        public ETipoLocacao TipoLocacao { get; private set; }
        public decimal ValorTotal { get; private set; }
        public Guid IdLocatario { get; private set; }
        public Guid IdCondutor { get; private set; }
        public Guid IdAutomovel { get; private set; }
        public Guid IdPendenciaFinanceira { get; private set; }
        public EStatusLocacao Status { get; private set; }

        public LocacaoPagamento(Guid id, DateTime dataCriacao, DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao, decimal valorTotal, Guid idLocatario, Guid idCondutor, Guid idAutomovel, Guid idPendenciaFinanceira, EStatusLocacao status) : base(id,dataCriacao)
        {
            Id = id;
            DataCriacao = dataCriacao;
            Saida = saida;
            Retorno = retorno;
            TipoLocacao = tipoLocacao;
            ValorTotal = valorTotal;
            IdLocatario = idLocatario;
            IdCondutor = idCondutor;
            IdAutomovel = idAutomovel;
            IdPendenciaFinanceira = idPendenciaFinanceira;
            Status = status;
        }


        //fabrica
        public static LocacaoPagamento Create(Guid id, DateTime dataCriacao, DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao, decimal valorTotal, Guid idLocatario, Guid idCondutor, Guid idAutomovel, Guid idPendenciaFinanceira, EStatusLocacao status)
        {
            return new LocacaoPagamento(id,dataCriacao,saida, retorno, tipoLocacao, valorTotal, idLocatario, idCondutor, idAutomovel,idPendenciaFinanceira,status);
        }

        public override bool Validacao(out string erros)
        {
            erros = "";
            return true; // por enquanto
        }
    }
}
