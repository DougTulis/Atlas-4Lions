using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System.Text;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class PendenciaFinanceira : ModeloAbstrato, IContrato
    {
        public decimal ValorTotal { get; private set; }

        public int QuantidadeParcelas { get; private set; }
        public IList<Parcela> Parcelas { get; private set; } = new List<Parcela>();

        public PendenciaFinanceira(decimal valorTotal, int quantidadeParcelas)
        {
            ValorTotal = valorTotal;
            QuantidadeParcelas = quantidadeParcelas;
        }


        //public PendenciaFinanceira()
        //{
        //}

        public static PendenciaFinanceira Create(decimal valorTotal,int quantidadeParcelas)
        {
            return new PendenciaFinanceira(valorTotal,quantidadeParcelas);
        }
        public void AdicionarParcela(Parcela parcela)
        {
            Parcelas.Add(parcela);
        }

        public void RemoverParcela(Parcela parcela)
        {
            Parcelas.Remove(parcela);
        }

        public override bool Validacao()
        {
            return true; // por enquanto
        }

        public override bool Validacao(out string erros)
        {
            throw new NotImplementedException();
        }
    }
}
