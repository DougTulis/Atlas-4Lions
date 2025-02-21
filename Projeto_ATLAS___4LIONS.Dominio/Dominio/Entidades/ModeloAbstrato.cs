using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public abstract class ModeloAbstrato : IValidacoes
    {
        private List<Notificacao> listaNotificacoes = new List<Notificacao>();

        public IReadOnlyCollection<Notificacao> Notificacoes => listaNotificacoes;
        public int Id { get; private set; }
        public DateTime DataCriacao { get; private set; } = DateTime.Now;

        protected void SetNotificacoesLista(List<Notificacao> notificacoes)
        {
            listaNotificacoes = notificacoes;
        }
        protected ModeloAbstrato()
        {
            Id = 1;
            DataCriacao = DateTime.Now;
        }

        protected ModeloAbstrato(int id, DateTime dataCriacao)
        {
            Id = id;
            DataCriacao = dataCriacao;
        }

        public abstract bool Validacao();
    }
}
