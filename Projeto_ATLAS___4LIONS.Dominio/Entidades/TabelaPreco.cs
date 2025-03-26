using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Validacoes;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class TabelaPreco : ModeloAbstrato, IContrato
    {
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }

        private TabelaPreco(string descricao, decimal valor) : base()
        {
            Descricao = descricao;
            Valor = valor;
        }

        private TabelaPreco(Guid id, DateTime dataCriacao, string descricao, decimal valor) : base(id,dataCriacao)
        {
            Descricao = descricao;
            Valor = valor;
        }


        public static TabelaPreco Create(string descricao, decimal valor)
        {
            return new TabelaPreco(descricao,valor);
        }
        public static TabelaPreco CreateFromDataBase(Guid id, DateTime dataCriacao, string descricao, decimal valor)
        {
            return new TabelaPreco(id,dataCriacao,descricao, valor);
        }

        //  public TabelaPreco()
        // {
        //  }

        public override bool Validacao(out string erros)
        {
            erros = "";

            var contratos = new ContratoValidacoes<TabelaPreco>()
                .DescricaoIsOk(this.Descricao, "Descrição inválida. Mínimo 3 caracteres.", "Descricao")
                .ValorDiariaIsOk(this.Valor, "Valor da diária deve ser maior que zero.", "Valor");

            if (!contratos.IsValid())
            {
                erros = contratos.CapturadorErros();
                return false;
            }

            return true;
        }

    }
}
