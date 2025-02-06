using Projeto_ATLAS___4LIONS.Dominio.Notificacoes;

namespace Projeto_ATLAS___4LIONS.Aplicacao.Validacoes
{
    public partial class ContratoValidacoes<T>
    {
        public ContratoValidacoes<T> CpfIsOk(string cpf, short minLenght, string mensagem, string propriedadeNome)
        {
            if (string.IsNullOrEmpty(cpf) || (cpf.Length < minLenght) || !cpf.All(char.IsDigit))
            {
                AddNotification(new Notificacao(mensagem, propriedadeNome));
            }
            return this;
        }
    }
}