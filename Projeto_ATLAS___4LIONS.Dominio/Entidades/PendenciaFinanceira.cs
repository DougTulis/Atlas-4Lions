using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System.Text;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class PendenciaFinanceira : ModeloAbstrato, IContrato
    {
        public decimal ValorTotal { get; private set; }
        public IList<Parcela> Parcelas { get; private set; } = new List<Parcela>();

        public PendenciaFinanceira(decimal valorTotal) : base()
        {
            ValorTotal = valorTotal;
        }

        public PendenciaFinanceira(Guid id, DateTime dataCriacao, decimal valorTotal) : base(id,dataCriacao)
        {
            ValorTotal = valorTotal;
        }

        //public PendenciaFinanceira()
        //{
        //}

        public static PendenciaFinanceira Create(decimal valorTotal)
        {
            return new PendenciaFinanceira(valorTotal);
        }

        public static PendenciaFinanceira CreateFromDataBase(Guid id, DateTime dataCriacao, decimal valorTotal)
        {
            return new PendenciaFinanceira(id,dataCriacao, valorTotal);
        }

        public void AdicionarParcela(Parcela parcela)
        {
            Parcelas.Add(parcela);
        }

        public void RemoverParcela(Parcela parcela)
        {
            Parcelas.Remove(parcela);
        }

        public override bool Validacao(out string erros)
        {
            erros = "";
            return true; // por enquanto
        }


    }
}
