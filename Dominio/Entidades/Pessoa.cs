using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public class Pessoa :  ModeloAbstrato, IContrato
    { 
        public string Nome { get; set; }
        public string  Email { get; set; }
        public string Contato { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }

        public override bool Validacao()
        {
            throw new NotImplementedException();
        }

        // public Endereco Endereco { get; set; }

    }
}
