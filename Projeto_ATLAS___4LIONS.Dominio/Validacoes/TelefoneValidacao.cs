using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> ContatoIsOk(string contato, short minLength, string mensagem, string propriedadeNome)
        {
            if (string.IsNullOrEmpty(contato) || (contato.Length < minLength))
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}
