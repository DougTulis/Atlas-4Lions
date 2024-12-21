using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public class EmailValidacoes
    {
        public bool isEmailValido(string email)
        {
            if (string.IsNullOrEmpty(email) || !email.Contains("@") || !email.Contains("."))
            {
                Console.WriteLine("Email inválido. Insira um endereço de email válido.");
            }
            return true;
        }
    }
}
