using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Dominio.Validacoes.Interface_Validacoes
{
    public interface IValidacaoTeste
    {
        bool Validacao(out string erro);
    }
}
