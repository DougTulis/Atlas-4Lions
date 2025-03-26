using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> IdsObrigatoriosLocacao(Guid locatarioId, Guid condutorId, Guid automovelId, Guid pendenciaId)
        {
            if (locatarioId == Guid.Empty)
                AddNotification(new Notificacao("Locatário é obrigatório.", "IdLocatario"));

            if (condutorId == Guid.Empty)
                AddNotification(new Notificacao("Condutor é obrigatório.", "IdCondutor"));

            if (automovelId == Guid.Empty)
                AddNotification(new Notificacao("Automóvel é obrigatório.", "IdAutomovel"));

            if (pendenciaId == Guid.Empty)
                AddNotification(new Notificacao("Pendência Financeira é obrigatória.", "IdPendenciaFinanceira"));

            return this;
        }
    }
}
