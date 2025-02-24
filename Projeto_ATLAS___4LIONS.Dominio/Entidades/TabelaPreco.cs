using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class TabelaPreco : ModeloAbstrato, IContrato
    {
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }

        private TabelaPreco(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
        public static TabelaPreco Create(string descricao, decimal valor)
        {
            return new TabelaPreco(descricao,valor);
        }

        //  public TabelaPreco()
        // {
        //  }


        public override bool Validacao()
        {
            return true; // por enquanto
        }
    }
}
