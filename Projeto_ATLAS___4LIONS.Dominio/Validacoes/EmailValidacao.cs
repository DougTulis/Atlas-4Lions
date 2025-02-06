using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> EmailIsOk(string email, short minLength, string mensagem, string propriedadeNome)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains(".") || email.Length < minLength)
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}
