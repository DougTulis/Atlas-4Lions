using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> AnoIsOk(string ano, string mensagem, string propriedadeNome)
        {
            if (!int.TryParse(ano, out int anoInt) || anoInt < 1886 || anoInt > DateTime.Now.Year + 1)
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}
