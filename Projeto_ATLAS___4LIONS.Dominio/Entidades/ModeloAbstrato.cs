using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public abstract class ModeloAbstrato : IValidacoes
    {
        private List<Notificacao> listaNotificacoes = new List<Notificacao>();

        public IReadOnlyCollection<Notificacao> Notificacoes => listaNotificacoes;
        public Guid Id { get; private set; }
        public DateTime DataCriacao { get; private set; }

        protected void SetNotificacoesLista(List<Notificacao> notificacoes)
        {
            listaNotificacoes = notificacoes;
        }
        protected ModeloAbstrato()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.Now;
        }

        public abstract bool Validacao();
    }
}
