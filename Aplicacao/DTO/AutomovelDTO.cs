using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Validacoes;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class AutomovelDTO 
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Modelo { get;  set; }
        public string Placa { get;  set; }
        public string Cor { get;  set; }
        public EStatusVeiculo Status { get; set; }
        public string? Chassi { get;  set; }
        public IList<TabelaPreco> TabelaPrecos { get; set; }
        public string? Renavam { get;  set; }
        public int? Oleokm { get;  set; }
        public int? PastilhaFreioKm { get;  set; }

        public AutomovelDTO()
        {
        }

        public AutomovelDTO(string modelo, string placa, string cor, EStatusVeiculo status, string? chassi, string? renavam, int? oleokm, int? pastilhaFreioKm)
        {
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            Status = status;
            Chassi = chassi;
            Renavam = renavam;
            Oleokm = oleokm;
            PastilhaFreioKm = pastilhaFreioKm;
        }
        public override string? ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Id: " + Id);
            sb.AppendLine("Modelo: " + Modelo);
            sb.AppendLine("Placa: " + Placa);
            sb.AppendLine("Cor: " + Cor);
            sb.AppendLine("Status: " + Status);
            sb.AppendLine("Chassi: " + (string.IsNullOrEmpty(Chassi) ? "Não informado" : Chassi));
            sb.AppendLine("Renavam: " + (string.IsNullOrEmpty(Renavam) ? "Não informado" : Renavam));
            sb.AppendLine("Oleo: " + (Oleokm.HasValue ? Oleokm.ToString() : "Não informado"));
            sb.AppendLine("Pastilha Freio: " + (PastilhaFreioKm.HasValue ? PastilhaFreioKm.ToString() : "Não informado"));

            return sb.ToString();   
        }
        public string ExibirDadosBreves()
        {
            return $"Id: {Id} | Modelo: {Modelo} | Placa: {Placa} ";
        }

    }
}
