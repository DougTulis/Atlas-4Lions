using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class LocacaoDTO : ModeloAbstrato ,IValidacoes, IContrato
    {
        public DateTime Saida { get; set; }
        public DateTime Retorno { get; set; }
        public ETipoLocacao TipoLocacao { get; set; }
        public Guid TransacaoID { get; private set; } 
        public decimal ValorTotal { get; private set; }
        public int LocatarioId { get; private set; }
        public int CondutorId { get; private set; }  
        public int AutomovelId { get; private set; } 
        public int PagamentoId { get; private set; }
        public LocacaoDTO(DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao, Guid transacaoID, decimal valorTotal, int locatarioId, int condutorId, int automovelId, int pagamentoId)
        {
            
            Saida = saida;
            Retorno = retorno;
            TipoLocacao = tipoLocacao;
            TransacaoID = transacaoID;
            ValorTotal = valorTotal;
            LocatarioId = locatarioId;
            CondutorId = condutorId;
            AutomovelId = automovelId;
            PagamentoId = pagamentoId;
        }
        public IEnumerable<PendenciaFinanceiraDTO> PendenciaFinanceira { get; private set; } = new List<PendenciaFinanceiraDTO>();


        public override bool Validacao()
        {
            throw new NotImplementedException();
        }
    }
}
