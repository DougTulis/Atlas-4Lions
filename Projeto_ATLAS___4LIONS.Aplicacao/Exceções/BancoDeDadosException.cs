using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Exceções
{
    public class BancoDeDadosException : Exception
    {
        public BancoDeDadosException()
        { }

        public BancoDeDadosException(string message)
        : base(message)
        { }

        public BancoDeDadosException(string message, Exception inner)
        : base(message, inner)
        { }
    }
}

