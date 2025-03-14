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
        public Guid IdAutomovel { get; private set; }
        public Guid IdPendenciaFinanceira { get; private set; }
        public EStatusLocacao Status { get; private set; }

        public Locacao(DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao, decimal valorTotal, Guid idLocatario, Guid idCondutor, Guid idAutomovel, EStatusLocacao status,Guid idPendenciaFinanceira) : base()
        {
            Saida = saida;
            Retorno = retorno;
            TipoLocacao = tipoLocacao;
            ValorTotal = valorTotal;
            IdLocatario = idLocatario;
            IdCondutor = idCondutor;
            IdAutomovel = idAutomovel;
            Status = status;
            IdPendenciaFinanceira = idPendenciaFinanceira;
        }

        public Locacao(Guid id, DateTime dataCriacao, DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao, decimal valorTotal, Guid idLocatario, Guid idCondutor, Guid idAutomovel, EStatusLocacao status, Guid idPendenciaFinanceira) : base(id,dataCriacao)
        {
            Saida = saida;
            Retorno = retorno;
            TipoLocacao = tipoLocacao;
            ValorTotal = valorTotal;
            IdLocatario = idLocatario;
            IdCondutor = idCondutor;
            IdAutomovel = idAutomovel;
            Status = status;
            IdPendenciaFinanceira = idPendenciaFinanceira;
        }

        //fabrica
        public static Locacao Create(DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao, decimal valorTotal, Guid idLocatario, Guid idCondutor, Guid idAutomovel, EStatusLocacao status, Guid idPendenciaFinanceira)
        {
            return new Locacao(saida,retorno,tipoLocacao,valorTotal,idLocatario,idCondutor,idAutomovel,status,idPendenciaFinanceira);
        }

        //fabrica from data base
        public static Locacao CreateFromDataBase(Guid id, DateTime dataCriacao, DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao, decimal valorTotal, Guid idLocatario, Guid idCondutor, Guid idAutomovel, EStatusLocacao status, Guid idPendenciaFinanceira)
        {
            return new Locacao(id, dataCriacao, saida, retorno, tipoLocacao, valorTotal, idLocatario, idCondutor, idAutomovel, status, idPendenciaFinanceira);
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

 
    }
}
