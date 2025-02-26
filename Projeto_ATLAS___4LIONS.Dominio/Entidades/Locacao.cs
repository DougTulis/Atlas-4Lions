using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Validacoes;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class Locacao : ModeloAbstrato, IContrato
    {
        public DateTime Saida { get; private set; }
        public DateTime Retorno { get; private set; }
        public ETipoLocacao TipoLocacao { get; private set; }
        public decimal ValorTotal { get; private  set; }
        public Guid IdLocatario { get; private set; }
        public Guid IdCondutor { get; private set; }
        public Guid IdAutomovel { get; set; }
        public Guid IdPendenciaFinanceira { get; private set; }
        public EStatusLocacao Status { get; private set; }

        public Locacao(DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao, Guid idLocatario, Guid idCondutor, Guid idAutomovel) : base()
        {
            Saida = saida;
            Retorno = retorno;
            TipoLocacao = tipoLocacao;
            IdLocatario = idLocatario;
            IdCondutor = idCondutor;
 
        }
        //fabrica
        public static Locacao Create(DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao, Guid idLocatario, Guid idCondutor, Guid idAutomovel)
        {
            return new Locacao(saida,retorno,tipoLocacao,idLocatario,idCondutor,idAutomovel);
        }

        public override bool Validacao(out string erros)
        {
            erros = "";
            var contratos = new ContratoValidacoes<Locacao>()
                .SaidaIsOk(this.Saida, this.Retorno, "Data de saída inválida.", "Saida")
                .RetornoIsOk(this.Retorno, this.Saida, "Data de retorno inválida", "Retorno");

            if (!contratos.IsValid())
            {
                erros = contratos.CapturadorErros();
                return false;
            }
            return true;
        }
     // private decimal CalcularValorTotal()
     // {
     //     int dias = (Retorno - Saida).Days;
     //     return dias * Automovel.ValorDiaria; 
     //
     // }

        public void AlterarStatusAndamento()
        {
            Status = EStatusLocacao.ANDAMENTO;
        }

        public void AlterarStatusFinalizado()
        {
            Status = EStatusLocacao.FINALIZADO;
        }

 
    }
}
