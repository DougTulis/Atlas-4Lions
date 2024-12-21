using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public static class NomeValidacoes
    {
        public static bool IsNomeValido(string nome)
        {
            if (string.IsNullOrEmpty(nome) || nome.Length < 3)
            {
                Console.WriteLine("Nome inválido. Deve conter pelo menos 3 caracteres.");
                return false;
            }
            return true;
        }
    }
}
