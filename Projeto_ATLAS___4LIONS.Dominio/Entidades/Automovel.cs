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
        public Guid IdPreco { get; private set; }
        public string? Renavam { get; private set; }
        public int? Oleokm { get; private set; }
        public int? PastilhaFreioKm { get; private set; }

        //public Automovel()
        //{
        //}

        private Automovel(string modelo, string placa, string cor, EStatusVeiculo status, string ano, string? chassi, string? renavam, int? oleokm, int? pastilhaFreioKm, Guid idPreco) : base()
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
            IdPreco = idPreco;
        }

        private Automovel(Guid id, DateTime dataCriacao, string modelo, string placa, string cor, EStatusVeiculo status, string ano, string? chassi, string? renavam, int? oleokm, int? pastilhaFreioKm, Guid idPreco) : base(id,dataCriacao)
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
            IdPreco = idPreco;
        }


        public static Automovel Create(string modelo, string placa, string cor, EStatusVeiculo status, string ano, string? chassi, string? renavam, int? oleokm, int? pastilhaFreioKm, Guid idPreco)
        {
            return new Automovel(modelo, placa, cor, status, ano, chassi, renavam, oleokm, pastilhaFreioKm, idPreco);
        }
        public static Automovel CreateFromDataBase(Guid id, DateTime dataCriacao, string modelo, string placa, string cor, EStatusVeiculo status, string ano, string? chassi, string? renavam, int? oleokm, int? pastilhaFreioKm, Guid idPreco)
        {
            return new Automovel(id,dataCriacao,modelo, placa, cor, status, ano, chassi, renavam, oleokm, pastilhaFreioKm, idPreco);
        }

        public override bool Validacao(out string erros)
        {
            erros = "";
            var contratos = new ContratoValidacoes<Automovel>()
             .ModeloIsOk(this.Modelo, "Insira um modelo válido", "Modelo")
             .PlacaIsOk(this.Placa, "Placa inválida", "Placa")
             .CorIsOk(this.Cor, "Cor inválida", "Cor")
             .AnoIsOk(this.Ano, "Ano automovel inválido", "Ano");
            

            if (!contratos.IsValid())
            {
                erros = contratos.CapturadorErros();
                return false;
            }
            return true;

        }

        public void AlterarModelo(string modelo)
        {
            Modelo = modelo;
        }


        public void AlterarPlaca(string placa)
        {
            Placa = placa;
        }
        public void AlterarAno(string ano)
        {
            Ano = ano;
        }
        public void AlterarCor(string cor)
        {
            Cor = cor;
        }

        public void AlterarChassi(string chassi)
        {
            Chassi = chassi;
        }
        public void AlterarOleoKm(int oleoKm)
        {
            Oleokm = oleoKm;
        }
        public void AlterarRenavam(string renavam)
        {
            Renavam = renavam;
        }
        public void AlterarPastilhaKm(int pastilhaKm)
        {
            PastilhaFreioKm = pastilhaKm;
        }


        public void AlterarStatusParaGaragem()
        {
            Status = EStatusVeiculo.GARAGEM;
        }

        public void AlterarStatusParaAlugado()
        {
            Status = EStatusVeiculo.ALUGADO;
        }
    }
}
