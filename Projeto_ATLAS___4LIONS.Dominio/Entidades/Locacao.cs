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
        public Pessoa Locatario { get; private set; }
        public Pessoa Condutor { get; private set; }
        public Automovel Automovel { get; private set; }
        public PendenciaFinanceira PendenciaFinanceira { get; private set; }
        public EStatusLocacao Status { get; private set; }

        public Locacao(DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao, Pessoa locatario, Pessoa condutor, Automovel automovel, EStatusLocacao status) : base()
        {
            Saida = saida;
            Retorno = retorno;
            TipoLocacao = tipoLocacao;
            Locatario = locatario;
            Condutor = condutor;
            Automovel = automovel;
            Status = status;
            ValorTotal = CalcularValorTotal();
        }

        //fabrica
        public static Locacao Create(DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao, Pessoa locatario, Pessoa condutor, Automovel automovel, EStatusLocacao status)
        {
            return new Locacao(saida,retorno,tipoLocacao,locatario,condutor,automovel,status);
        }

        public override bool Validacao()
        {

            var contratos = new ContratoValidacoes<Locacao>().PossuiCnh(Condutor, "A pessoa escolhida precisa ter uma CNH vinculada", "Condutor")
                .SaidaIsOk(this.Saida, this.Retorno, "Data de saída inválida.", "Saida")
                .RetornoIsOk(this.Retorno, this.Saida, "Data de retorno inválida", "Retorno");
            if (!contratos.IsValid())
            {

                return false;
            }

            return true;
        }
        private decimal CalcularValorTotal()
        {
            int dias = (Retorno - Saida).Days;
            return dias * Automovel.Preco.Valor; 

        }

        public void AlterarStatusAndamento()
        {
            Status = EStatusLocacao.ANDAMENTO;
        }

        public void AlterarStatusFinalizado()
        {
            Status = EStatusLocacao.FINALIZADO;
        }

        public override bool Validacao(out string erros)
        {
            throw new NotImplementedException();
        }
    }
}
