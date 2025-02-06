using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;
using Projeto_ATLAS___4LIONS.Dominio.ValueObjects.Enums;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> isCarroALugado(EStatusVeiculo statusVeiculo, string mensagem, string propriedadeNome)
        {
            if (statusVeiculo == EStatusVeiculo.ALUGADO)
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}
