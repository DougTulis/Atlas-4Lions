using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> DataNascIsOk(DateTime nascimento, int minAno, string mensagem, string propriedadeNome)
        {
            if (nascimento > DateTime.Now || (DateTime.Now.Year - nascimento.Year) < minAno)
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}
