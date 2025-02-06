using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> CnpjIsOk(string cnpj, short minLenght, string mensagem, string propriedadeNome)
        {
            if (string.IsNullOrEmpty(cnpj) || (cnpj.Length < minLenght) || !cnpj.All(char.IsDigit))
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}