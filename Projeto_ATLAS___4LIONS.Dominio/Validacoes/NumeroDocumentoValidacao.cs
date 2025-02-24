using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> NumeroDocumentoIsOk(string numeroDocumento, short minLenght, string mensagem, string propriedadeNome)
        {
            if (string.IsNullOrEmpty(numeroDocumento) || (numeroDocumento.Length < minLenght) || !numeroDocumento.All(char.IsDigit))
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}