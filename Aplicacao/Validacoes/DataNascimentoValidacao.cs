using Projeto_ATLAS___4LIONS.Aplicacao.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> DataNascIsOk(DateTime dateTime, string mensagem, string propriedadeNome)
        {
            if (dateTime > DateTime.Now)
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}
