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
            public ContratoValidacoes<T> CnhIsOk(string? cnh, short minLenght, string mensagem, string propriedadeNome)
            {
                if (string.IsNullOrEmpty(cnh) || (cnh.Length < minLenght) || !cnh.All(char.IsDigit))
                {
                    AddNotification(new Notificacao(mensagem, propriedadeNome));
                }
                return this;
            }
        }
    }
