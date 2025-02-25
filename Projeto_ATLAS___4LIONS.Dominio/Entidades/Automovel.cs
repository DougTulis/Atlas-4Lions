using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Validacoes;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class Automovel : ModeloAbstrato, IContrato
    {
        public string Modelo { get; private set; }
        public string Placa { get; private set; }
        public string Cor { get; private set; }
        public string Ano { get; private set; }
        public EStatusVeiculo Status { get; private set; }
        public string? Chassi { get; private set; }
        public TabelaPreco Preco { get; private set; }
        public string? Renavam { get; private set; }
        public int? Oleokm { get; private set; }
        public int? PastilhaFreioKm { get; private set; }

        //public Automovel()
        //{
        //}

        public Automovel(string modelo, string placa, string cor, EStatusVeiculo status, string ano, string? chassi, string? renavam, int? oleokm, int? pastilhaFreioKm, TabelaPreco preco) : base()
        {
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            Status = status;
            Chassi = chassi;
            Renavam = renavam;
            Oleokm = oleokm;
            PastilhaFreioKm = pastilhaFreioKm;
            Ano = ano;
            Preco = preco;
        }
        public static Automovel Create(string modelo, string placa, string cor, EStatusVeiculo status, string ano, string? chassi, string? renavam, int? oleokm, int? pastilhaFreioKm,TabelaPreco preco)
        {
            return new Automovel(modelo, placa, cor, status, ano, chassi, renavam, oleokm, pastilhaFreioKm, preco);
        }

        public override bool Validacao()
        {

            var contratos = new ContratoValidacoes<Automovel>()
                .ModeloIsOk(this.Modelo, "Insira um modelo válido", "Modelo")
                .PlacaIsOk(this.Placa, "Placa inválida", "Placa");

            if (!contratos.IsValid())
            {
                return false;
            }
            return true;
        }

        public bool ValidarPraDeletar()
        {
            var contratos = new ContratoValidacoes<Automovel>().isCarroALugado(this.Status, "O automóvel está alugado e não pode ser deletado.", "Status");

            if (!contratos.IsValid())
            {
                return false;
            }
            return true;
        }
        public void AlterarParaGaragem()
        {
            Status = EStatusVeiculo.GARAGEM;
        }

        public void AlterarParaAlugado()
        {
            Status = EStatusVeiculo.ALUGADO;
        }

        public override bool Validacao(out string erros)
        {
            throw new NotImplementedException();
        }
    }
}
