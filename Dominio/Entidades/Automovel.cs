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
        public string Modelo { get;  set; }
        public string Placa { get;  set; }
        public string Cor { get;   set; }
        public EStatusVeiculo Status { get;  set; }
        public decimal ValorDiaria { get;  set; }
        public string? Chassi { get;  set; }
        public string? Renavam { get;  set; }
        public int? Oleokm { get;  set; }
        public int? PastilhaFreioKm { get;  set; }
        public int? CorreiaDentadaKm { get;  set; }
        public int? KmAtual { get;  set; }

        public Automovel()
        {
        }

        public override bool Validacao()
        {
            throw new NotImplementedException();
        }
    }

}
