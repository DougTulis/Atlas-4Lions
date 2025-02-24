
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System.Text;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class AutomovelDTO
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
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
        public Guid IdPreco { get; set; }

        public AutomovelDTO()
        {
        }

        public AutomovelDTO(string modelo, string placa, string cor, EStatusVeiculo status,string ano, string? chassi, string? renavam, int? oleokm, int? pastilhaFreioKm, Guid idPreco)
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

    }
}
