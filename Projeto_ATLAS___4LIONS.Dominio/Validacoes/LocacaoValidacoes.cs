using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> PossuiCnh(Pessoa pessoa, string mensagem, string propriedadeNome)
        {
            if (string.IsNullOrWhiteSpace(pessoa.NumeroCnh) || !pessoa.VencimentoCnh.HasValue)
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}