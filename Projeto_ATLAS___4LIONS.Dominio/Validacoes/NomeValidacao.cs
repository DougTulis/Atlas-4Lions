using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T>
    {


        public ContratoValidacoes<T> NomeIsOk(string nome, short minLength, string mensagem, string propriedadeNome)
        {
            if (string.IsNullOrEmpty(nome) || (nome.Length < minLength))
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}
