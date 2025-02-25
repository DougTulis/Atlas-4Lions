using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;

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


        public string CapturadorErros()
        {
            string mensagensErro = "";

            foreach (var notificacao in _notificacoes)
            {
                mensagensErro += notificacao.Mensagem + "\n";
            }
            return mensagensErro;
        }
    }
}
