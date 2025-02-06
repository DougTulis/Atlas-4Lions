using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Validacoes;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class Locacao : ModeloAbstrato, IContrato
    {
        public DateTime Saida { get; set; }
        public DateTime Retorno { get; set; }
        public ETipoLocacao TipoLocacao { get; set; }
        public decimal ValorTotal { get; set; }
        public Pessoa Locatario { get; set; }
        public Pessoa Condutor { get; set; }
        public Automovel Automovel { get; set; }
        public PendenciaFinanceira PendenciaFinanceira { get; set; }
        public EStatusLocacao Status { get; set; }

        public Locacao()
        {
        }
        public Locacao(DateTime saida, DateTime retorno, ETipoLocacao tipoLocacao, decimal valorTotal, Pessoa locatario, Pessoa condutor, Automovel automovel, PendenciaFinanceira pendenciaFinanceira, EStatusLocacao status)
        {
            Saida = saida;
            Retorno = retorno;
            TipoLocacao = tipoLocacao;
            ValorTotal = valorTotal;
            Locatario = locatario;
            Condutor = condutor;
            Automovel = automovel;
            PendenciaFinanceira = pendenciaFinanceira;
            Status = status;
        }

        public override bool Validacao()
        {
            var contratos = new ContratoValidacoes<Locacao>().PossuiCnh(Condutor, "A pessoa escolhida precisa ter uma CNH vinculada", "Condutor")
                .SaidaIsOk(this.Saida, this.Retorno, "Data de saída inválida.", "Saida")
                .RetornoIsOk(this.Retorno, this.Saida, "Data de retorno inválida", "Retorno")
;


            if (!contratos.IsValid())
            {
                foreach (var notificacao in contratos.Notificacoes)
                {
                    Console.WriteLine($"Erro em {notificacao.NomePropriedade}: {notificacao.Mensagem}");
                }
                return false;
            }

            return true;
        }

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
