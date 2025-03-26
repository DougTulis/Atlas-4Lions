using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> DescricaoIsOk(string descricao, string mensagem, string propriedadeNome)
        {
            if (string.IsNullOrWhiteSpace(descricao) || descricao.Length < 3)
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
        public ContratoValidacoes<T> ValorDiariaIsOk(decimal valor, string mensagem, string propriedadeNome)
        {
            if (valor <= 0)
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}

