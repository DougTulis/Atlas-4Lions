using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class Automovel : ModeloAbstrato
    {
        public string Modelo { get; private set; }
        public string Placa { get; private set; }
        public string Cor { get; private  set; }
        public EStatusVeiculo Status { get; private set; }
        public decimal ValorDiaria { get; private set; }
        public string? Chassi { get; private set; }
        public string? Renavam { get; private set; }
        public int? Oleokm { get; private set; }
        public int? PastilhaFreioKm { get; private set; }
        public int? CorreiaDentadaKm { get; private set; }
        public int? KmAtual { get; private set; }

        public override bool Validacao()
        {
            throw new NotImplementedException();
        }
    }

}
