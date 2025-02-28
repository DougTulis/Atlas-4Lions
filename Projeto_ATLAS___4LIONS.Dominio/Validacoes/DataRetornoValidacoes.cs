using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> RetornoIsOk(DateTime retorno, DateTime saida, string mensagem, string propriedadeNome)
        {
            if (retorno < saida || retorno == null || retorno == DateTime.MinValue)
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}
