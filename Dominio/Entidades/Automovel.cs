using Projeto_ATLAS___4LIONS.Aplicacao.DTO;
using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Validacoes;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class Automovel : ModeloAbstrato, IContrato
    {
        public string Modelo { get;  set; }
        public string Placa { get;  set; }
        public string Cor { get;  set; }
        public EStatusVeiculo Status { get; set; }
        public string? Chassi { get;  set; }
        public IList<TabelaPreco> TabelaPrecos { get; set; }
        public string? Renavam { get;  set; }
        public int? Oleokm { get;  set; }
        public int? PastilhaFreioKm { get;  set; }

        public Automovel()
        {
        }
        public Automovel(string modelo, string placa, string cor, EStatusVeiculo status, string? chassi, string? renavam, int? oleokm, int? pastilhaFreioKm)
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

        public bool ValidarPraDeletar()
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

        public decimal CalcularValor(TimeSpan periodo, decimal valorAutomovel)
        {
            return valorAutomovel * periodo.Days;
        }
    }
}
