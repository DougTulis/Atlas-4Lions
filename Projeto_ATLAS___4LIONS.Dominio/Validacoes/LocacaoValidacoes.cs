using Projeto_ATLAS___4LIONS.Dominio.Entidades;
using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> PossuiCnh(Guid condutor, string mensagem, string propriedadeNome)
        {
            
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}