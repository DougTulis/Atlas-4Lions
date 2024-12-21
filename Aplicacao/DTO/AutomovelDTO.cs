using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Validacoes;
using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.DTO
{
    public class AutomovelDTO : ModeloAbstrato , IContrato
    {
        public string Modelo { get; private set; }
        public string Placa { get; private set; }
        public string Cor { get; private set; }
        public EStatusVeiculo Status { get; private set; }
        public decimal ValorDiaria { get; private set; }
        public string? Chassi { get; private set; }
        public string? Renavam { get; private set; }
        public int? Oleokm { get; private set; }
        public int? PastilhaFreioKm { get; private set; }

        public AutomovelDTO(string modelo, string placa, string cor, EStatusVeiculo status, decimal valorDiaria, string? chassi, string? renavam, int? oleokm, int? pastilhaFreioKm)
        {
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            Status = status;
            ValorDiaria = valorDiaria;
            Chassi = chassi;
            Renavam = renavam;
            Oleokm = oleokm;
            PastilhaFreioKm = pastilhaFreioKm;
        }


        public override bool Validacao()
        {
            var contratos = new ContratoValidacoes<AutomovelDTO>()
                .ModeloIsOk(this.Modelo, "Insira um modelo válido", "Modelo");


            if (!contratos.IsValid())
            {
                foreach (var notificacao in contratos.Notificacoes)
                {
                    Console.WriteLine($"Erro em {notificacao.NomePropriedade}: {notificacao.Mensagem}");
                    Thread.Sleep(3000);
                }
                return false;
            }
            return true;
        }

        public bool ValidarParaDelecao()
        {
            var contratos = new ContratoValidacoes<AutomovelDTO>().isCarroALugado(this.Status, "O automóvel está alugado e não pode ser deletado.", "Status");

            if (!contratos.IsValid())
            {
                foreach (var notificacao in contratos.Notificacoes)
                {
                    Console.WriteLine($"Erro em {notificacao.NomePropriedade}: {notificacao.Mensagem}");
                }
                return false;
            }
            return true;
        }


        public override string ToString()
        {
            return $@"
Id: {Id}
Modelo: {Modelo}
Placa: {Placa}
Cor: {Cor}
Status: {Status}
Valor Diária: {ValorDiaria:C}
Chassi: {(string.IsNullOrWhiteSpace(Chassi) ? "Não informado" : Chassi)}
Renavam: {(string.IsNullOrWhiteSpace(Renavam) ? "Não informado" : Renavam)}
Quilometragem do Óleo: {(Oleokm.HasValue ? Oleokm + " km" : "Não informado")}
Quilometragem das Pastilhas de Freio: {(PastilhaFreioKm.HasValue ? PastilhaFreioKm + " km" : "Não informado")}
Adicionado em: {DataCriacao}";
        }
        public string ExibirDadosBreves()
        {
            return $"Id: {Id} | Modelo: {Modelo} | Placa: {Placa} | Valor Diária: {ValorDiaria:C}";
        }

    }
}
