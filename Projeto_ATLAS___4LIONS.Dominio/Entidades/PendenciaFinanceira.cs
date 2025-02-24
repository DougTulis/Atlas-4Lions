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


        private List<Parcela> GerarParcelas()
        {
            List<Parcela> listaParcelas = new List<Parcela>();

            if (QuantidadeParcelas == 1)
            {
                // 🔹 Se for diária, cria apenas 1 parcela com o valor total
                listaParcelas.Add(Parcela.Create(1, DateTime.Now.AddDays(30), ValorTotal));
            }
            else
            {
                // 🔹 Se for contrato, divide o valor total entre as parcelas
                decimal valorParcela = ValorTotal / QuantidadeParcelas;

                for (int i = 0; i < QuantidadeParcelas; i++)
                {
                    DateTime vencimento = DateTime.Now.AddMonths(i + 1);
                    listaParcelas.Add(Parcela.Create(i + 1, vencimento, valorParcela));
                }
            }

            return listaParcelas;
        }

        public override bool Validacao()
        {
            return true; // por enquanto
        }
    }
}
