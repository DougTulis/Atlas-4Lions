using Projeto_ATLAS___4LIONS.Aplicacao.Notificacoes;
using System.Text.RegularExpressions;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> PlacaIsOk(string placaVeiculo,
string message, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(placaVeiculo))
            {
                AddNotification(new Notificacao(message, propertyName));
            }

            string mascara =
@"^[A-Z]{3}[0-9]{4}$|^[A-Z]{3}[0-9][A-Z][0-9]{2}$";

            if (!Regex.IsMatch(placaVeiculo, mascara,
RegexOptions.IgnoreCase))
            {
                AddNotification(new Notificacao(message, propertyName));
            }

            return this;
        }
    }
}