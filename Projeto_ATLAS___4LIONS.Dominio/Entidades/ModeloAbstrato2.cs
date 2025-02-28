using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public abstract class ModeloAbstrato2 : IValidacoes
    {
        private List<Notificacao> listaNotificacoes = new List<Notificacao>();

        public IReadOnlyCollection<Notificacao> Notificacoes => listaNotificacoes;
        public Guid Id { get; private set; }
        public DateTime DataCriacao { get; private set; }

        protected void SetNotificacoesLista(List<Notificacao> notificacoes)
        {
            listaNotificacoes = notificacoes;
        }
        public abstract bool Validacao(out string erros);

        protected ModeloAbstrato2(Guid id, DateTime dataCriacao)
        {
            Id = id;
            DataCriacao = dataCriacao;
        }
    }
}
