using Projeto_ATLAS___4LIONS.Aplicacao.Interface;
using Projeto_ATLAS___4LIONS.Aplicacao.Notificacoes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Dominio.Entidades
{
    public abstract class ModeloAbstrato : IValidacoes
    {
        private List<Notificacao> listaNotificacoes = new List<Notificacao>();

        public IReadOnlyCollection<Notificacao> Notificacoes => listaNotificacoes;
        public int Id { get; set; }
        public DateTime DataCriacao { get;  set; } = DateTime.Now;

        protected void SetNotificacoesLista(List<Notificacao> notificacoes)
        {
            listaNotificacoes = notificacoes;
        }

        public abstract bool Validacao();
    }
}
