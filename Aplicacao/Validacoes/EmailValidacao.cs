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


        public ContratoValidacoes<T> EmailIsOk(string email, short minLength, string mensagem, string propriedadeNome)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains(".") || email.Length < minLength);
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}
