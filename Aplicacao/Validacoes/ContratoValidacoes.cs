using Projeto_ATLAS___4LIONS.Aplicacao.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T> 
    {
        private readonly List<Notificacao> _notificacoes;

        public ContratoValidacoes()
        {
            _notificacoes = new List<Notificacao>();
        }

        public IReadOnlyCollection<Notificacao> Notificacoes => _notificacoes;

        public void AddNotification(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public bool IsValid()
        {
            return _notificacoes.Count == 0;
        }
    }
}
