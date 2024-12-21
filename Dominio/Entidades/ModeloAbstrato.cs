using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public abstract class ModeloAbstrato : IValidacoes
    {

        public int Id { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public abstract bool Validacao();
    }
}
