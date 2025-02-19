using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Validacoes;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class Automovel : ModeloAbstrato, IContrato
    {
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Ano { get; set; }
        public EStatusVeiculo Status { get; set; }
        public string? Chassi { get; set; }
        public IList<TabelaPreco> TabelaPrecos { get; set; }
        public string? Renavam { get; set; }
        public int? Oleokm { get; set; }
        public int? PastilhaFreioKm { get; set; }

        public Automovel()
        {
        }
        public Automovel(string modelo, string placa, string cor, EStatusVeiculo status,string ano, string? chassi, string? renavam, int? oleokm, int? pastilhaFreioKm)
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

    }
}
