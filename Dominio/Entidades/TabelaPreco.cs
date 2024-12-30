using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class TabelaPreco : ModeloAbstrato, IContrato
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int AutomovelId { get; set; }


        public TabelaPreco(string descricao, decimal valor, int automovelId)
        {
            Descricao = descricao;
            Valor = valor;
            AutomovelId = automovelId;
        }

        public TabelaPreco()
        {
        }

        public override bool Validacao()
        {
            return true; // por enquanto
        }
    }
}
