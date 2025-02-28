using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;
using System.Linq;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> NumeroDocumentoIsOk(string numeroDocumento, short minLength, string mensagem, string propriedadeNome)
        {
            if (string.IsNullOrEmpty(numeroDocumento) ||
                numeroDocumento.Length != minLength ||
                !numeroDocumento.All(char.IsDigit))
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}
